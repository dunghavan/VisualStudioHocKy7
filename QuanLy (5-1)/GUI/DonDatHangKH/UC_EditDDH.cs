using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;


namespace GUI
{
    public partial class UC_EditDDH : UserControl
    {
        public UC_EditDDH()
        {
            InitializeComponent();
            LoadData();
            
            
        }
        private static UC_EditDDH _instance;
        public static UC_EditDDH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_EditDDH();
                return _instance;
            }
        }
        int tongtien = 0;
        
        int soluong = 0;
        int SLTonToiThieu;
        SanPham sp = new SanPham();
        int sl_truocCN = 0;
        int thanhtien_truocCN = 0;
        SanPhamBUS spBUS = new SanPhamBUS();
        DonDatHangBUS ddhBUS = new DonDatHangBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        ThamSoBUS tsBUS = new ThamSoBUS();
        string maEdit = UC_ListDonDatHang.Instance.maDDH_edit;
        
        //string maEdit = "002";
            
        
        public void LoadData()
        {
            SLTonToiThieu = tsBUS.GetSLTonToiThieu();
            gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(maEdit);
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            txt_maNV.Text = UserControl_Login.login_User.hoTen;
            txt_maDDH.Text = maEdit;
           
            cbb_KH.DataSource = khBUS.Load_DSKhachHang();
            cbb_KH.DisplayMember = "HoTen";
            cbb_KH.ValueMember = "MaKH";
            cbb_KH.Enabled = true;
            //cbb_NV.Enabled = true;
            dtp_NgayGiao.Enabled = true;
            for (int i = 0; i < int.Parse(gv_CTDDH.RowCount.ToString()); i++)
            {


                tongtien += int.Parse(gv_CTDDH.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
        }
        private void txt_SL_ValueChanged(object sender, EventArgs e)
        {
            

            //int max = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            //if (Convert.ToInt32(txt_SL.Value) > max)
            //{
            //    txt_SL.Value = max;
            //}
                int thanhtien = 0;
                thanhtien = int.Parse(txt_DonGia.Text) * Convert.ToInt32(txt_SL.Value);
                txt_ThanhTien.Text = thanhtien.ToString();
            
            
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            spBUS.updateSLSanPham(txt_maSP.Text, soluong - Convert.ToInt32(txt_SL.Value));
            //txt_maDDH.Text = gv_CTDDH.Columns[0].ToString();
            //txt_maDDH.Text = gv_DMSP.GetRowCellValue(0, "TenSP").ToString();
            if (int.Parse(gv_CTDDH.RowCount.ToString()) != 0)
            {
                for (int i = 0; i < int.Parse(gv_CTDDH.RowCount.ToString()); i++)
                {
                    if ((txt_maDDH.Text == (gv_CTDDH.GetRowCellValue(i, "MaDDH").ToString())) && (txt_maSP.Text == (gv_CTDDH.GetRowCellValue(i, "MaSP").ToString())))
                    {
                        ddhBUS.Update_CT_DonDatHang(txt_maDDH.Text,
                                                    txt_maSP.Text,
                                                    Convert.ToInt32(txt_SL.Value) + int.Parse(gv_CTDDH.GetRowCellValue(i, "SoLuong").ToString()),
                                                    int.Parse(txt_ThanhTien.Text) + int.Parse(gv_CTDDH.GetRowCellValue(i, "ThanhTien").ToString()));
                    }
                    else
                    {
                        ddhBUS.Insert_CT_DonDatHang(txt_maDDH.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text), "");
                    }
                }
            }
            else
            {
                ddhBUS.Insert_CT_DonDatHang(txt_maDDH.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text), "");
            }

            

            
            ddhBUS.Update_TongTienDDH(txt_maDDH.Text, int.Parse(txtTongthanhtoan.Text));
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);
            for (int i = 0; i < int.Parse(gv_CTDDH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTDDH.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
           
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            tongtien -= int.Parse(txt_ThanhTien.Text);
            spBUS.updateSLSanPham(txt_maSP.Text, soluong + Convert.ToInt32(txt_SL.Value));
            ddhBUS.Delete_CT_DonDatHang(txt_maDDH.Text, txt_maSP.Text);
            txtTongthanhtoan.Text = tongtien.ToString();
            ddhBUS.Update_TongTienDDH(txt_maDDH.Text, int.Parse(txtTongthanhtoan.Text));
            lb_thongbao.Text = "Sản phẩm đã xóa khỏi chi tiết đơn đặt hàng!";
            lb_thongbao.Visible = true;
            txtTongthanhtoan.Text = tongtien.ToString();
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);
            lb_thongbao.Text = "";
        }
        

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {


            soluong = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            spBUS.updateSLSanPham(txt_maSP.Text, soluong + sl_truocCN - Convert.ToInt32(txt_SL.Value));
            ddhBUS.Update_CT_DonDatHang(txt_maDDH.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text));
            
            
            ddhBUS.Update_TongTienDDH(txt_maDDH.Text, int.Parse(txtTongthanhtoan.Text));
            gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);
            tongtien = 0;
            for (int i = 0; i < int.Parse(gv_CTDDH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTDDH.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
            gc_DMSP.DataSource = spBUS.getAllSanPham();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            ddhBUS.Update_DonDatHang(txt_maDDH.Text,
                                      dtpNgayLap_PDH.Value,
                                      UserControl_Login.login_User.maNhanVien,
                                      cbb_KH.SelectedValue.ToString(),
                                      int.Parse(txtTongthanhtoan.Text),
                                      dtp_NgayGiao.Value,
                                      "");
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListDonDatHang.Instance);
            UC_ListDonDatHang.Instance.BringToFront();
            UC_ListDonDatHang.Instance.LoadDonDatHang();
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
            txt_SL.Maximum = int.Parse(soluongtong)-SLTonToiThieu;
            txt_ThanhTien.Text = (int.Parse(txt_DonGia.Text) * int.Parse(txt_SL.Text)).ToString();
        }

        private void gv_CTDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_CTDDH.GetDataRow(e.RowHandle);
            txt_maSP.Text = row["MaSP"].ToString();
            txt_TenSP.Text = row["TenSP"].ToString();
            txt_DonGia.Text = row["DonGia"].ToString();
            txt_SL.Value = int.Parse(row["SoLuong"].ToString());
            txt_ThanhTien.Text = row["ThanhTien"].ToString();
            txt_SL.Enabled = true;
            sl_truocCN = int.Parse(row["SoLuong"].ToString());
            thanhtien_truocCN = int.Parse(row["ThanhTien"].ToString());
            btnThemSP.Enabled = false;
            btn_CapNhat.Enabled = true;
            btnXoaSP.Enabled = true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListDonDatHang.Instance);
            UC_ListDonDatHang.Instance.BringToFront();
        }
    }
}
