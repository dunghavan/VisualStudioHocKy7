using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class UC_AddHoaDonLe : UserControl
    {
        public UC_AddHoaDonLe()
        {
            InitializeComponent();
            LoadData();
            ToggleUI(true);
        }

        private static UC_AddHoaDonLe _instance;
        public static UC_AddHoaDonLe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_AddHoaDonLe();
                return _instance;
            }
        }
        int soluong = 0;
        int tongtien = 0;
        int sl_truocCN = 0;
        
        SanPhamBUS spBUS = new SanPhamBUS();
        HoaDonBUS hdBUS = new HoaDonBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        
        public void LoadData()
        {
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTHD.DataSource = hdBUS.Load_DSCT_TheoMaHD(txt_maHD2.Text);
            txt_SL.Enabled = false;
            cbb_NV2.DataSource = nvBUS.getAllNhanVien();
            cbb_NV2.DisplayMember = "HoTen";
            cbb_NV2.ValueMember = "MaNV";
            cbb_KH2.DataSource = khBUS.Load_DSKhachHang();
            cbb_KH2.DisplayMember = "HoTen";
            cbb_KH2.ValueMember = "MaKH";


        }

        private void btn_ThemHĐ_Click(object sender, EventArgs e)
        {
            if (txt_maHD2.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập Mã Đơn Đặt Hàng !");
                txt_maHD2.Focus();
            }
            else
            {

                if (hdBUS.KT_maHD(txt_maHD2.Text) == null)
                {
                    if (hdBUS.Insert_HoaDon(txt_maHD2.Text,
                                            dtpNgayLap.Value,
                                            cbb_NV2.SelectedValue.ToString(),
                                            cbb_KH2.SelectedValue.ToString(),
                                            0,
                                            ""))
                    {
                        txt_maHD.Text = txt_maHD2.Text;
                        cbb_KH.Text = cbb_KH2.Text;
                        cbb_NV.Text = cbb_NV2.Text;
                        
                        ToggleUI(false);
                    }
                    else
                    {
                        //TODO show thong bao
                    }

                }
                else
                {
                    XtraMessageBox.Show("Mã đơn đặt hàng đã tồn tại, vui lòng nhập mã khác !");
                }
            }

        }

        public void ToggleUI(bool isAdd = false)
        {
            if (isAdd)
            {
                //TODO show UI tao don dat hang
                groupControl_HD.Visible = false;
                groupControl_ThemHD.Visible = true;
                btn_ThemHD.Visible = true;
                btn_Huy.Visible = true;
                groupControl_SanPham.Visible = false;
                gc_DMSP.Visible = false;
                gc_CTHD.Visible = false;
                txtTongthanhtoan.Visible = false;
                btn_HoanTat.Visible = false;

            }
            else
            {
                //TODO show UI hien thi thong tin chi tiet
                //.Location = _groupControl_DDH_normalPosition;
                groupControl_HD.Visible = true;
                groupControl_ThemHD.Visible = false;
                btn_ThemHD.Visible = false;
                btn_Huy.Visible = false;
                groupControl_SanPham.Visible = true;
                gc_DMSP.Visible = true;
                gc_CTHD.Visible = true;
                label_tongthanhtoan.Visible = true;
                txtTongthanhtoan.Visible = true;
                lb_thongbao.Visible = true;
                btn_HoanTat.Visible = true;

            }
        }

        private void gv_DMSP_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_DMSP.GetDataRow(e.RowHandle);
            soluong = int.Parse(row["SoLuong"].ToString());
            UpdateThongtinSPView(row["MaSP"].ToString(),
                row["TenSP"].ToString(),
                row["DonGia"].ToString(),
                row["SoLuong"].ToString());
            txt_SL.Enabled = true;
            btnThemSP.Enabled = true;
            btnXoaSP.Enabled = false;
            btn_CapNhat.Enabled = false;
        }

        private void UpdateThongtinSPView(string maSP, string tenSP, string dongia, string soluongtong)
        {
            txt_maSP.Text = maSP;
            txt_TenSP.Text = tenSP;
            txt_DonGia.Text = dongia;
            txt_SL.Text = string.Format("{0}", 1);
            txt_SL.Maximum = int.Parse(soluongtong);
            txt_ThanhTien.Text = (int.Parse(txt_DonGia.Text) * int.Parse(txt_SL.Text)).ToString();
        }

        private void txt_SL_ValueChanged(object sender, EventArgs e)
        {
            int thanhtien = 0;
            thanhtien = int.Parse(txt_DonGia.Text) * Convert.ToInt32(txt_SL.Value);
            txt_ThanhTien.Text = thanhtien.ToString();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            
            spBUS.updateSLSanPham(txt_maSP.Text, soluong - Convert.ToInt32(txt_SL.Value));
            //txt_maDDH.Text = gv_CTDDH.Columns[0].ToString();
            //txt_maDDH.Text = gv_DMSP.GetRowCellValue(0, "TenSP").ToString();
            if (int.Parse(gv_CTHD.RowCount.ToString()) != 0)
            {
                for (int i = 0; i < int.Parse(gv_CTHD.RowCount.ToString()); i++)
                {
                    if ((txt_maHD.Text == (gv_CTHD.GetRowCellValue(i, "MaHD").ToString())) && (txt_maSP.Text == (gv_CTHD.GetRowCellValue(i, "MaSP").ToString())))
                    {
                        hdBUS.Update_CT_HoaDon(txt_maHD.Text,
                                               txt_maSP.Text,
                                               Convert.ToInt32(txt_SL.Value) + int.Parse(gv_CTHD.GetRowCellValue(i, "SoLuong").ToString()),
                                               int.Parse(txt_ThanhTien.Text) + int.Parse(gv_CTHD.GetRowCellValue(i, "ThanhTien").ToString()),"");

                                             
                    }
                    else
                    {
                        hdBUS.Insert_CTHoaDon(txt_maHD.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text), "");
                        
                    }
                }
            }
            else
            {
                hdBUS.Insert_CTHoaDon(txt_maHD.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text), "");
            }

            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTHD.DataSource = hdBUS.Load_DSCT_TheoMaHD(txt_maHD.Text);
            tongtien = 0;
            for (int i = 0; i < int.Parse(gv_CTHD.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTHD.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
           
        }


        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            soluong = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            
           spBUS.updateSLSanPham(txt_maSP.Text, soluong + Convert.ToInt32(txt_SL.Value));
            hdBUS.Delete_CT_HoaDon(txt_maHD.Text, txt_maSP.Text);
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTHD.DataSource = hdBUS.Load_DSCT_TheoMaHD(txt_maHD.Text);
            tongtien = 0;
            for (int i = 0; i < int.Parse(gv_CTHD.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTHD.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
            
            
        }

        private void gv_CTHD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_CTHD.GetDataRow(e.RowHandle);
            txt_maSP.Text = row["MaSP"].ToString();
            txt_TenSP.Text = row["TenSP"].ToString();
            txt_DonGia.Text = row["DonGia"].ToString();
            txt_SL.Value = int.Parse(row["SoLuong"].ToString());
            txt_ThanhTien.Text = row["ThanhTien"].ToString();
            txt_SL.Enabled = true;

            sl_truocCN = int.Parse(row["SoLuong"].ToString());
            
            btnThemSP.Enabled = false;
            btn_CapNhat.Enabled = true;
            btnXoaSP.Enabled = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            soluong = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            spBUS.updateSLSanPham(txt_maSP.Text, soluong + sl_truocCN - Convert.ToInt32(txt_SL.Value));
            hdBUS.Update_CT_HoaDon(txt_maHD.Text, 
                                   txt_maSP.Text, 
                                   Convert.ToInt32(txt_SL.Value), 
                                   int.Parse(txt_ThanhTien.Text),"");
        
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTHD.DataSource = hdBUS.Load_DSCT_TheoMaHD(txt_maHD.Text);
            tongtien = 0;
            for (int i = 0; i < int.Parse(gv_CTHD.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTHD.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListHoaDon.Instance);
            UC_ListHoaDon.Instance.BringToFront();
        }
    }
}
