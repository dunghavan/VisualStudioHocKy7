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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class UC_HoaDonSi : UserControl
    {
        public UC_HoaDonSi()
        {
            InitializeComponent();
            LoadData();
            ToggleUI(true);
        }


        private static UC_HoaDonSi _instance;
        public static UC_HoaDonSi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_HoaDonSi();
                return _instance;
            }
        }

        NhanVienBUS nvBUS = new NhanVienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        DonDatHangBUS ddhBUS = new DonDatHangBUS();
        HoaDonBUS hdBUS = new HoaDonBUS();
        ThamSoBUS tsBUS = new ThamSoBUS();
        Regex regexMaKH = new Regex(@"^[a-zA-Z0-9]$");

        


        public void LoadData()
        {

            //cbb_NV2.DataSource = nvBUS.getAllNhanVien();
            txt_TenNV2.Text = UserControl_Login.login_User.hoTen;
            //cbb_NV2.ValueMember = "MaNV";
            cbb_KH2.DataSource = khBUS.Load_DSKhachHang();
            cbb_KH2.DisplayMember = "HoTen";
            cbb_KH2.ValueMember = "MaKH";
            cbb_MaDDH.DataSource = ddhBUS.Load_DSDonDatHang_TheoMaDDH();
            cbb_MaDDH.DisplayMember = "MaDDH";
            cbb_MaDDH.ValueMember = "MaDDH";
            gridControl_HD.DataSource = hdBUS.Load_CTHoaDonSi(cbb_MaDDH.SelectedValue.ToString());
            txt_ChietKhau.Text = tsBUS.GetChietKhau().ToString();

        }
        

        // tạo đơn đặt hàng trước
        public void ToggleUI(bool isAdd = false)
        {
            if (isAdd)
            {
                //TODO show UI tao don dat hang
                groupControl_ThemHD.Visible = true;
                btn_ThemHD.Visible = true;
                btn_Huy.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                cbb_KH.Visible = false;
                txt_TenNV.Visible = false;
                dtp_NgayLap.Visible = false;
                txt_TongTien.Visible = false;
                txt_ChietKhau.Visible = false;
                gridControl_HD.Visible = false;
                btn_HoanTat.Visible = false;
                btn_HuyHD.Visible = false;


            }
            else
            {
                //TODO show UI hien thi thong tin chi tiet
                //.Location = _groupControl_DDH_normalPosition;
                groupControl_ThemHD.Visible = false;
                btn_ThemHD.Visible = false;
                btn_Huy.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                cbb_KH.Visible = true;
                txt_TenNV2.Visible = true;
                dtp_NgayLap.Visible = true;
                txt_TongTien.Visible = true;
                txt_ChietKhau.Visible = true;
                gridControl_HD.Visible = true;
                btn_HoanTat.Visible = true;
            }
        }
       
        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            double ChietKhau = (double)(int.Parse(txt_ChietKhau.Text))/100;
            int tongtien = 0;

           
            if (txt_maHD2.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập Mã Đơn Đặt Hàng !");
                txt_maHD2.Focus();
            }
            
            else
            {
               
                    if(hdBUS.KT_maHD(txt_maHD2.Text) == null)
                {

                        if (hdBUS.Insert_HoaDon(txt_maHD2.Text,
                                                 dtp_NgayLap.Value,
                                                 UserControl_Login.login_User.maNhanVien,
                                                 cbb_KH2.SelectedValue.ToString(),
                                                 0,
                                                 ""))
                        {
                            cbb_KH.Text = cbb_KH2.Text;
                            //cbb_NV.Text = cbb_NV2.Text;
                            dtp_NgayLap2.Text = dtp_NgayLap.Text;
                            txt_TenNV.Text = txt_TenNV2.Text;
                            ToggleUI(false);
                            //txt_ChietKhau.Text = "30%";
                            gridControl_HD.DataSource = hdBUS.Load_CTHoaDonSi(cbb_MaDDH.Text);

                            for (int i = 0; i < int.Parse(gv_DSHD.RowCount.ToString()); i++)
                            {
                                hdBUS.Insert_CTHoaDon(txt_maHD2.Text,
                                                       gv_DSHD.GetRowCellValue(i, "MaSP").ToString(),
                                                       int.Parse(gv_DSHD.GetRowCellValue(i, "SoLuong").ToString()),
                                                       int.Parse(gv_DSHD.GetRowCellValue(i, "ThanhTien").ToString()),
                                                       "");
                            }
                            for (int i = 0; i < int.Parse(gv_DSHD.RowCount.ToString()); i++)
                            {
                                tongtien += int.Parse(gv_DSHD.GetRowCellValue(i, "ThanhTien").ToString());
                            }

                            txt_TongTien.Text = (tongtien * (1 - ChietKhau)).ToString();

                        }
                        else
                        {

                        }

                    }
                
                
                
                else
                {
                    XtraMessageBox.Show("Mã hóa đơn đã tồn tại, vui lòng nhập mã khác !");
                }
            }   
            
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListHoaDon.Instance);
            UC_ListHoaDon.Instance.BringToFront();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
            
        {
            hdBUS.Update_TongTienHD(txt_maHD2.Text, int.Parse(txt_TongTien.Text));
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListHoaDon.Instance);
            UC_ListHoaDon.Instance.BringToFront();
            UC_ListHoaDon.Instance.LoadData();
            
        }

        private void btn_HuyHD_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListHoaDon.Instance);
            UC_ListHoaDon.Instance.BringToFront();
            UC_ListHoaDon.Instance.LoadData();
        }
    }
}
