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

namespace GUI
{
    public partial class UC_SuaHoaDonLe : UserControl
    {
        public UC_SuaHoaDonLe()
        {
            InitializeComponent();
        }
        private static UC_SuaHoaDonLe _instance;
        public static UC_SuaHoaDonLe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_SuaHoaDonLe();
                return _instance;
            }
        }

        int tongtien = 0;
        int soluong = 0;
        int sl_truocCN = 0;
        int thanhtien_truocCN = 0;
        SanPhamBUS spBUS = new SanPhamBUS();
        HoaDonBUS hdBUS = new HoaDonBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        string maEdit = UC_ListHoaDon.Instance.maHD_edit;
        //string maEdit = "002";

        private void UC_EditDDH_Load(object sender, EventArgs e)
        {

            gc_CTHD.DataSource = hdBUS.Load_DSCT_TheoMaHD(txt_maHD.Text);
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            cbb_NV.DataSource = nvBUS.getAllNhanVien();
            txt_maHD.Text = maEdit;
            cbb_NV.DisplayMember = "HoTen";
            cbb_NV.ValueMember = "MaNV";
            cbb_KH.DataSource = khBUS.Load_DSKhachHang();
            cbb_KH.DisplayMember = "HoTen";
            cbb_KH.ValueMember = "MaKH";
            cbb_KH.Enabled = true;
            cbb_NV.Enabled = true;
            dtpNgayLap_HD.Enabled = true;
            for (int i = 0; i < int.Parse(gv_CTHD.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTHD.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
        }

        private void txt_SL_ValueChanged(object sender, EventArgs e)
        {
            int thanhtien = 0;
            thanhtien = int.Parse(txt_DonGia.Text) * Convert.ToInt32(txt_SL.Value);
            txt_ThanhTien.Text = thanhtien.ToString();
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

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            spBUS.updateSLSanPham(txt_maSP.Text, soluong - Convert.ToInt32(txt_SL.Value));
            if (int.Parse(gv_CTHD.RowCount.ToString()) != 0)
            {
                for (int i = 0; i < int.Parse(gv_CTHD.RowCount.ToString()); i++)
                {
                    if ((txt_maHD.Text == (gv_CTHD.GetRowCellValue(i, "MaHD").ToString())) && (txt_maSP.Text == (gv_CTHD.GetRowCellValue(i, "MaSP").ToString())))
                    {
                        hdBUS.Update_CT_HoaDon(txt_maHD.Text,
                                               txt_maSP.Text,
                                               Convert.ToInt32(txt_SL.Value) + int.Parse(gv_CTHD.GetRowCellValue(i, "SoLuong").ToString()),
                                               int.Parse(txt_ThanhTien.Text) + int.Parse(gv_CTHD.GetRowCellValue(i, "ThanhTien").ToString()), "");


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
                                   int.Parse(txt_ThanhTien.Text), "");
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTHD.DataSource = hdBUS.Load_DSCT_TheoMaHD(txt_maHD.Text);
            tongtien = 0;
            for (int i = 0; i < int.Parse(gv_CTHD.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTHD.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            hdBUS.Update_TongTienHD(txt_maHD.Text,
                                    int.Parse(txtTongthanhtoan.Text));
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListHoaDon.Instance);
            UC_ListHoaDon.Instance.BringToFront();
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
    }
}
