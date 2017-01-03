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
using DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace GUI
{
    public partial class UC_AddDDH : UserControl
    {
       
        public UC_AddDDH()
        {
            InitializeComponent();

            LoadData();
            ToggleUI(true);
        }

        // tạo đơn đặt hàng trước
        public void ToggleUI(bool isAdd = false)
        {
            if (isAdd)
            {
                //TODO show UI tao don dat hang
                groupControl_DDH.Visible = false;
                groupControl_ThemDDH.Visible = true;
                btn_ThemDDH.Visible = true;
                btn_Huy.Visible = true;
                groupControl_SanPham.Visible = false;
                gc_DMSP.Visible = false;
                gc_CTDDH.Visible = false;
                
                txtTongthanhtoan.Visible = false;
                btn_HoanTat.Visible = false;

            }
            else
            {
                //TODO show UI hien thi thong tin chi tiet
                //.Location = _groupControl_DDH_normalPosition;
                groupControl_DDH.Visible = true;
                groupControl_ThemDDH.Visible = false;
                btn_ThemDDH.Visible = false;
                btn_Huy.Visible = false;
                groupControl_SanPham.Visible = true;
                gc_DMSP.Visible = true;
                gc_CTDDH.Visible = true;
                label_tongthanhtoan.Visible = true;
                txtTongthanhtoan.Visible = true;
                lb_thongbao.Visible = true;
                btn_HoanTat.Visible = true;

            }
        }

        private static UC_AddDDH _instance;
        public static UC_AddDDH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_AddDDH();
                return _instance;
            }
        }

        int tongtien = 0;
        int soluong = 0;
        SanPham sp = new SanPham();
        int sl_truocCN = 0;
        int thanhtien_truocCN = 0;
        SanPhamBUS spBUS = new SanPhamBUS();
        DonDatHangBUS ddhBUS = new DonDatHangBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        // khởi tạo dữ liệu
        public void LoadData()
        {
            //SanPhamBUS spBUS = new SanPhamBUS();
            //DonDatHangBUS ddhBUS = new DonDatHangBUS();
            //NhanVienBUS nvBUS = new NhanVienBUS();
            //KhachHangBUS khBUS = new KhachHangBUS();
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            //gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);
            txt_SL.Enabled = false;
            cbb_NV2.DataSource = nvBUS.getAllNhanVien();
            cbb_NV2.DisplayMember = "HoTen";
            cbb_NV2.ValueMember = "MaNV";
            cbb_KH2.DataSource = khBUS.Load_DSKhachHang();
            cbb_KH2.DisplayMember = "HoTen";
            cbb_KH2.ValueMember = "MaKH";


        }

        // khi click 1 dòng trong danh mục hiển thị lên các textbox
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

        // tính thành tiền khi số lượng sản phẩm thay đổi
        private void txt_SL_ValueChanged(object sender, EventArgs e)
        {
            int thanhtien = 0;
            thanhtien = int.Parse(txt_DonGia.Text) * Convert.ToInt32(txt_SL.Value);
            txt_ThanhTien.Text = thanhtien.ToString();
        }

        // thêm sản phẩm vào chi tiết đơn đặt hàng
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            //tongtien += int.Parse(txt_ThanhTien.Text);   
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

            

            txtTongthanhtoan.Text = tongtien.ToString();
            ddhBUS.Update_TongTienDDH(txt_maDDH.Text, int.Parse(txtTongthanhtoan.Text));
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);
            for (int i = 0; i < int.Parse(gv_CTDDH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTDDH.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
            

        }

        // thêm đơn đặt hàng
        private void btn_ThemDDH_Click(object sender, EventArgs e)
        {
            //DonDatHangBUS ddhBUS = new DonDatHangBUS();
            //txt_maDDH.Text = ddhBUS.KT_maDDH("001");
            //string maddh = ddhBUS.KT_maDDH("khongco");
            //XtraMessageBox.Show(maddh);
            if (txt_maDDH2.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập Mã Đơn Đặt Hàng !");
                txt_maDDH2.Focus();
            }
            else
            {
                if (ddhBUS.KT_maDDH(txt_maDDH2.Text) == null)
                {
                    int no = 20000000;
                    // kiểm tra công nợ
                    if (ddhBUS.Insert_DonDatHang(txt_maDDH2.Text
                        , dtpNgayLap_PDH.Value,
                        cbb_NV2.SelectedValue.ToString(),
                        cbb_KH2.SelectedValue.ToString(),
                        0, dtp_NgayGiao2.Value, "",
                        no))
                    {
                        txt_maDDH.Text = txt_maDDH2.Text;
                        cbb_KH.Text = cbb_KH2.Text;
                        cbb_NV.Text = cbb_NV2.Text;
                        dtp_NgayGiao.Text = dtp_NgayGiao2.Text;
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

        // xóa 1 sản phẩm trong chi tiết đơn đặt hàng
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            soluong = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            tongtien -= int.Parse(txt_ThanhTien.Text);
            spBUS.updateSLSanPham(txt_maSP.Text, soluong + Convert.ToInt32(txt_SL.Value));
            ddhBUS.Delete_CT_DonDatHang(txt_maDDH.Text, txt_maSP.Text);
            txtTongthanhtoan.Text = tongtien.ToString();
            ddhBUS.Update_TongTienDDH(txt_maDDH.Text, int.Parse(txtTongthanhtoan.Text));

            txtTongthanhtoan.Text = tongtien.ToString();

            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);
            for (int i = 0; i < int.Parse(gv_CTDDH.RowCount.ToString()); i++)
            {

                tongtien += int.Parse(gv_CTDDH.GetRowCellValue(i, "ThanhTien").ToString());
            }
            
        }

        // lấy thông tin của 1 dòng đổ vào textbox sản phẩm
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
            thanhtien_truocCN=int.Parse(row["ThanhTien"].ToString());
            btnThemSP.Enabled = false;
            btn_CapNhat.Enabled = true;
            btnXoaSP.Enabled = true;
            



        }

        // cập nhật sản phẩm trong chi tiết đơn đặt hàng
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {


            soluong = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            spBUS.updateSLSanPham(txt_maSP.Text, soluong + sl_truocCN - Convert.ToInt32(txt_SL.Value));
            ddhBUS.Update_CT_DonDatHang(txt_maDDH.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text));
            //ddhBUS.Update_TongTienDDH(txt_maDDH.Text, int.Parse(txtTongthanhtoan.Text));
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);
            tongtien = 0;
            for (int i = 0; i < int.Parse(gv_CTDDH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTDDH.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongthanhtoan.Text = tongtien.ToString();
           
            //gc_CTDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);

        }

        //update thông tin đơn đặt hàng và trở về màn hình trước
        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            ddhBUS.Update_DonDatHang(txt_maDDH.Text,
                                      dtpNgayLap_PDH.Value,
                                      cbb_NV.SelectedValue.ToString(),
                                      cbb_KH.SelectedValue.ToString(),
                                      int.Parse(txtTongthanhtoan.Text),
                                      dtp_NgayGiao.Value,
                                      "");
            MainForm.mainPanel.Controls.Add(UC_ListDonDatHang.Instance);
            UC_ListDonDatHang.Instance.BringToFront();
        }

        // hủy không tạo đơn đặt hàng

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            MainForm.mainPanel.Controls.Add(UC_ListDonDatHang.Instance);
            UC_ListDonDatHang.Instance.BringToFront();
        }


    }
}
