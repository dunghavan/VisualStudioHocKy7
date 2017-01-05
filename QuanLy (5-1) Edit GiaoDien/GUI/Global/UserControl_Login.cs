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
using DTO;
namespace GUI
{
    public partial class UserControl_Login : UserControl
    {
        private static UserControl_Login _instance;
        public static UserControl_Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Login();
                return _instance;
            }
        }
        public UserControl_Login()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

        }

        public static NhanVien login_User;
        private void btn_login_Click(object sender, EventArgs e)
        {
            //Load danh sách các user:
            UserControl_ListUser.tableNhanVien = UserControl_ListUser.objNVBus.getAllNhanVien();
            Form parentForm = this.FindForm();
            string tempUsername = null;
            string tempPassword = null;
            login_User = new NhanVien();
            bool checkLogin = false;
            bool exist = false;
            try //check username và password:
            {
                foreach (DataRow dr in UserControl_ListUser.tableNhanVien.Rows)
                {
                    tempUsername = dr["Username"].ToString().Trim();
                    tempPassword = dr["Password"].ToString().Trim();
                    //if (String.Compare(textEdit_username.Text, tempUsername) == 0 && String.Compare(textEdit_password.Text, tempPassword) == 0)
                    if (String.Compare(textEdit_username.Text, tempUsername) == 0)
                    {
                        exist = true;
                        if (dr["IsActive"].ToString() == "False")
                        {
                            XtraMessageBox.Show("Tài khoản này đã được ngừng kích hoạt!");
                        }
                        else
                        {
                            checkLogin = true;
                            login_User.maNhanVien = dr["MaNV"].ToString();
                            login_User.hoTen = dr["HoTen"].ToString();
                            login_User.namSinh = Int32.Parse(dr["NamSinh"].ToString());
                            login_User.gioiTinh = (bool)dr["GioiTinh"];
                            login_User.soDienThoai = dr["SoDT"].ToString();
                            login_User.email = dr["Email"].ToString();
                            login_User.maLoaiNV = dr["MaLoaiNV"].ToString();
                            login_User.username = dr["Username"].ToString().Trim();
                            login_User.password = dr["Password"].ToString();
                            break;
                        }
                    }
                }

                if (checkLogin)
                {
                    //((MainForm)parentForm).label_size.Text = "Kích thước size: " + ((MainForm)parentForm).Size;
                    ((MainForm)parentForm).hyperlink_dangXuat.Visible = true;
                    ((MainForm)parentForm).label_usernameLogin.Text = "Bạn đã đăng nhập với tài khoản: " + login_User.username;
                    ((MainForm)parentForm).label_usernameLogin.Visible = true;
                    ((MainForm)parentForm).tabPanel.Visible = true;
                    //((MainForm)parentForm).panelControl1.Hide();
                    UserControl_Login.Instance.Hide();
                    ((MainForm)parentForm).buttonPanel.Show();
                    //
                    ((MainForm)parentForm).panel38.Hide();
                    ((MainForm)parentForm).mainPanel.BringToFront();
                    ((MainForm)parentForm).buttonPanel.BringToFront();
                    //
                    ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_MainEmpty.Instance);
                    UserControl_MainEmpty.Instance.BringToFront();

                    disableAllButton();
                    switch(login_User.maLoaiNV)
                    {
                        case "QKL":
                            ((MainForm)parentForm).tabPanel.SelectedPage = ((MainForm)parentForm).tabQLK;
                            ((MainForm)parentForm).btn_BCTonKho.Enabled = true;
                            break;
                        case "BH":
                            ((MainForm)parentForm).tabPanel.SelectedPage = ((MainForm)parentForm).tabBH;
                            ((MainForm)parentForm).btn_donDatHang.Enabled = true;
                            ((MainForm)parentForm).btn_HDBanHangLe.Enabled = true;
                            ((MainForm)parentForm).btn_HDBanHangSi.Enabled = true;
                            ((MainForm)parentForm).btn_phieuGiaoHang.Enabled = true;
                            ((MainForm)parentForm).btn_QLKhachHang.Enabled = true;
                            break;
                        case "NH":
                            ((MainForm)parentForm).tabPanel.SelectedPage = ((MainForm)parentForm).tabNH;
                            ((MainForm)parentForm).btn_donNhapHang.Enabled = true;
                            ((MainForm)parentForm).btn_HDNhapHang.Enabled = true;
                            ((MainForm)parentForm).btn_QLSanPham.Enabled = true;
                            ((MainForm)parentForm).btn_QLNhaCC.Enabled = true;
                            break;
                        case "KT":
                            ((MainForm)parentForm).tabPanel.SelectedPage = ((MainForm)parentForm).tabKeToan;
                            ((MainForm)parentForm).btn_BCCongNoKH.Enabled = true;
                            ((MainForm)parentForm).btn_BCDoanhThu.Enabled = true;
                            ((MainForm)parentForm).btn_phieuThu.Enabled = true;
                            ((MainForm)parentForm).btn_phieuChi.Enabled = true;
                            break;
                        case "AD":
                            ((MainForm)parentForm).tabPanel.SelectedPage = ((MainForm)parentForm).tabAdmin;
                            ((MainForm)parentForm).btn_BackUpCSDL.Enabled = true;
                            ((MainForm)parentForm).btn_RestoreCSDL.Enabled = true;
                            break;
                        default:
                            ((MainForm)parentForm).tabPanel.SelectedPage = ((MainForm)parentForm).tabQLK;
                            enableAllButton();
                            break;
                    }
                }
                else
                    if(!exist)
                        XtraMessageBox.Show("Sai Username hoặc password!");
                //MessageBox.Show(((MainForm)parentForm).Size.ToString());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi Login:" + ex.Message);
            }
        }
        private void disableAllButton()
        {
            Form parentForm = this.FindForm();
            // Bán hàng:
            ((MainForm)parentForm).btn_donDatHang.Enabled = false; ;
            ((MainForm)parentForm).btn_HDBanHangSi.Enabled = false;
            ((MainForm)parentForm).btn_HDBanHangLe.Enabled = false;
            ((MainForm)parentForm).btn_phieuGiaoHang.Enabled = false;
            ((MainForm)parentForm).btn_QLKhachHang.Enabled = false;
            //Nhập hàng:
            ((MainForm)parentForm).btn_donNhapHang.Enabled = false;
            ((MainForm)parentForm).btn_HDNhapHang.Enabled = false;
            ((MainForm)parentForm).btn_QLSanPham.Enabled = false;
            ((MainForm)parentForm).btn_QLNhaCC.Enabled = false;
            //Quản lý kho:
            ((MainForm)parentForm).btn_BCTonKho.Enabled = false;
            //Kế toán:
            ((MainForm)parentForm).btn_BCCongNoKH.Enabled = false;
            ((MainForm)parentForm).btn_BCDoanhThu.Enabled = false;
            ((MainForm)parentForm).btn_phieuThu.Enabled = false;
            ((MainForm)parentForm).btn_phieuChi.Enabled = false;
            //Admin:
            ((MainForm)parentForm).btn_BackUpCSDL.Enabled = false;
            ((MainForm)parentForm).btn_RestoreCSDL.Enabled = false;
            //Hệ thống:
            ((MainForm)parentForm).btn_QLNV.Enabled = false;
            ((MainForm)parentForm).btn_thayDoiQuyDinh.Enabled = false;
        }
        private void enableAllButton()
        {
            Form parentForm = this.FindForm();
            // Bán hàng:
            ((MainForm)parentForm).btn_donDatHang.Enabled = true; ;
            ((MainForm)parentForm).btn_HDBanHangSi.Enabled = true;
            ((MainForm)parentForm).btn_HDBanHangLe.Enabled = true;
            ((MainForm)parentForm).btn_phieuGiaoHang.Enabled = true;
            ((MainForm)parentForm).btn_QLKhachHang.Enabled = true;
            //Nhập hàng:
            ((MainForm)parentForm).btn_donNhapHang.Enabled = true;
            ((MainForm)parentForm).btn_HDNhapHang.Enabled = true;
            ((MainForm)parentForm).btn_QLSanPham.Enabled = true;
            ((MainForm)parentForm).btn_QLNhaCC.Enabled = true;
            //Quản lý kho:
            ((MainForm)parentForm).btn_BCTonKho.Enabled = true;
            //Kế toán:
            ((MainForm)parentForm).btn_BCCongNoKH.Enabled = true;
            ((MainForm)parentForm).btn_BCDoanhThu.Enabled = true;
            ((MainForm)parentForm).btn_phieuThu.Enabled = true;
            ((MainForm)parentForm).btn_phieuChi.Enabled = true;
            //Admin:
            ((MainForm)parentForm).btn_BackUpCSDL.Enabled = true;
            ((MainForm)parentForm).btn_RestoreCSDL.Enabled = true;
            //Hệ thống:
            ((MainForm)parentForm).btn_QLNV.Enabled = true;
            ((MainForm)parentForm).btn_thayDoiQuyDinh.Enabled = true;
        }

        private void textEdit_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
        }

        private void textEdit_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
        }
    }
}
