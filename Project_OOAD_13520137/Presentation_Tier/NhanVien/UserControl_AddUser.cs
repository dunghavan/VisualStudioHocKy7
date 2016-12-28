using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using DTO;

namespace Presentation_Tier
{
    public partial class UserControl_AddUser : UserControl
    {
        private static UserControl_AddUser _instance;
        public static UserControl_AddUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddUser();
                return _instance;
            }
        }
        public UserControl_AddUser()
        {
            InitializeComponent();

            //Khởi tạo item cho comboBox mã loại nhân viên:
            comboBox_maLoaiNV.Properties.Items.Add("QLK");
            comboBox_maLoaiNV.Properties.Items.Add("BH");
            comboBox_maLoaiNV.Properties.Items.Add("NH");
            comboBox_maLoaiNV.Properties.Items.Add("KT");
            comboBox_maLoaiNV.Properties.Items.Add("AD");
            comboBox_maLoaiNV.Properties.Items.Add("FULL");
            comboBox_maLoaiNV.SelectedItem = "BH";

            //Khởi tạo item cho conboBox năm sinh:
            for (int i = 1900; i < 2017; i++)
            {
                comboBox_namSinh.Properties.Items.Add(i.ToString());
            }
            comboBox_namSinh.SelectedItem = "1995";

            //Mặc định giới tính nam:
            radioBtn_Nam.Checked = true;
            radio_kichHoat.Checked = true;
            textEdit_maNV.Focus();
        }

        //Tạo các biến lưu giá trị trên màn hình:
        string tempMaNV, tempHoTen, tempNamSinh, tempSDT, tempEmail = null, tempMaLoaiNV, tempUsername, tempPassword;

        bool tempIsActive = false;
        bool tempGioiTinh = false;
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListUser.Instance);
            UserControl_ListUser.Instance.BringToFront();

            //Enable/disable các btn:
            UserControl_ListButton_User.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_User.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_User.Instance.btn_Xoa.Enabled = false;
        }

        public void resetAllField()
        {
            textEdit_maNV.Text = null;
            textEdit_hoTen.Text = null;
            comboBox_namSinh.Text = "1996";
            radioBtn_Nam.Select();
            textEdit_SDT.Text = null;
            textEdit_email.Text = null;
            textEdit_username.Text = null;
            textEdit_password.Text = null;
            textEdit_confirmPassword.Text = null;
            radio_voHieuHoa.Select();

        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(checkAddNewInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                NhanVien tempNhanVien = new NhanVien(tempMaNV, tempHoTen, Convert.ToInt32(tempNamSinh), tempGioiTinh,
                                                    tempSDT, tempEmail, tempUsername, tempPassword, tempMaLoaiNV, tempIsActive);
                bool inserted = false;
                inserted = UserControl_ListUser.objNVBus.addNhanVien(tempNhanVien);
                if (inserted)
                {
                    //Trở về màn hình List:
                    Form parentForm = this.FindForm();
                    UserControl_ListUser.Instance.loadDanhSachNV();
                    if(!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListUser.Instance))
                        ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListUser.Instance);
                    UserControl_ListUser.Instance.BringToFront();

                    UserControl_ListUser.Instance.label_notification.Text = "Thêm thành công!";

                    //Enable/disable các btn:
                    UserControl_ListButton_User.Instance.btn_themMoi.Enabled = true;
                    UserControl_ListButton_User.Instance.btn_Edit.Enabled = false;
                    UserControl_ListButton_User.Instance.btn_Xoa.Enabled = false;
                }
                else
                    XtraMessageBox.Show("Thêm không thành công!");
            }
            else
            {
                
            }
        }

        private bool checkAddNewInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                //KIỂM TRA MÃ NHÂN VIÊN:
                tempMaNV = textEdit_maNV.Text;
                foreach(DataRow dr in UserControl_ListUser.tableNhanVien.Rows)
                    if(tempMaNV == dr["MaNV"].ToString())
                    {
                        XtraMessageBox.Show("Mã nhân viên đã tồn tại!");
                        return false;
                    }
                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regexMaNV = new Regex(@"^[a-zA-Z0-9]$");
                if (tempMaNV.Length == 0)
                {
                    XtraMessageBox.Show("Hãy nhập mã nhân viên!");
                    return false;
                }
                for (int i = 0; i < tempMaNV.Length; i++)
                {
                    if (tempMaNV[i].ToString() == " ") //Kiểm tra khoảng trắng
                    {
                        XtraMessageBox.Show("Mã nhân viên không được chứa ký tự space!");
                        return false;
                    }
                    if (!regexMaNV.IsMatch(tempMaNV[i].ToString())) //Kiểm tra không thuộc regex đã tạo
                    {
                        XtraMessageBox.Show("Mã nhân viên không hợp lệ!");
                        return false;
                    }
                }

                //KIỂM TRA HỌ TÊN:
                tempHoTen = textEdit_hoTen.Text;
                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regexHoTen = new Regex(@"^[a-zA-Z\sáàảãạăắằẳẵặâấầẩẫậúùủũụưứừửữựéèẻẽẹêếềểễệíìỉĩịýỳỷỹỵóòỏõọôốồổỗộơớờởỡợđĐ]$");
                for (int i = 0; i < tempHoTen.Length; i++)
                {
                    if (!regexHoTen.IsMatch(tempHoTen[i].ToString()))
                    {
                        XtraMessageBox.Show("Họ tên nhân viên không hợp lệ!");
                        return false;
                    }
                }

                //KIỂM TRA NĂM SINH:
                tempNamSinh = comboBox_namSinh.SelectedItem.ToString();

                Regex regexNamSinh = new Regex(@"^[0-9]$");
                for (int i = 0; i < tempNamSinh.Length; i++)
                    if (!regexNamSinh.IsMatch(tempNamSinh[i].ToString()))
                    {
                        XtraMessageBox.Show("Năm sinh không hợp lệ!");
                        return false;
                    }
                if (Int64.Parse(tempNamSinh) < 1900 || Int64.Parse(tempNamSinh) > 2016)
                {
                    XtraMessageBox.Show("Năm sinh không hợp lệ!");
                    return false;
                }

                //KIỂM TRA SDT:
                tempSDT = textEdit_SDT.Text;
                Regex regexSDT = new Regex(@"^[0-9]$");
                for (int i = 0; i < tempSDT.Length; i++)
                    if (!regexSDT.IsMatch(tempSDT[i].ToString()))
                    {
                        XtraMessageBox.Show("Số điện thoại không hợp lệ!");
                        return false;
                    }
                if (tempSDT.Length < 8 || tempSDT.Length > 12)
                {
                    XtraMessageBox.Show("Số điện thoại phải từ 8 đến 12 số!");
                    return false;
                }

                //KIỂM TRA EMAIL:
                tempEmail = textEdit_email.Text;
                //try
                //{
                //    var addr = new System.Net.Mail.MailAddress(tempEmail);
                //}
                //catch
                //{
                //    XtraMessageBox.Show("Email không hợp lệ!");
                //    return false;
                //}
                string regexEmail = (@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
                if (tempEmail.Length > 0)
                {
                    Match matches = Regex.Match(tempEmail, regexEmail);
                    if (!matches.Success)
                    {
                        XtraMessageBox.Show("Email không hợp lệ!");
                        return false;
                    }
                }

                //KIỂM TRA MÃ LOẠI NV:
                bool isExist = false;
                tempMaLoaiNV = comboBox_maLoaiNV.SelectedItem.ToString();
                foreach (string item in comboBox_maLoaiNV.Properties.Items)
                    if (tempMaLoaiNV.Equals(item.ToString()))
                        isExist = true;
                if (isExist == false)
                {
                    XtraMessageBox.Show("Mã loại NV không hợp lệ!");
                    return false;
                }

                //KIỂM TRA USERNAME:
                tempUsername = textEdit_username.Text;

                foreach (DataRow dr in UserControl_ListUser.tableNhanVien.Rows)
                    if (tempUsername == dr["Username"].ToString())
                    {
                        XtraMessageBox.Show("Username đã tồn tại!");
                        return false;
                    }
                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regexUsername = new Regex(@"^[a-zA-Z0-9]$");
                if (tempUsername.Length > 0) //Đã nhập username
                    for (int i = 0; i < tempUsername.Length; i++)
                    {
                        if (tempUsername[i].ToString() == " ") //Kiểm tra khoảng trắng
                        {
                            XtraMessageBox.Show("Username không được chứa ký tự space!");
                            return false;
                        }
                        if (!regexUsername.IsMatch(tempUsername[i].ToString())) //Kiểm tra không thuộc regex đã tạo
                        {
                            XtraMessageBox.Show("Username không hợp lệ!");
                            return false;
                        }
                    }

                //KIỂM TRA PASSWORD VÀ CONFIRM PASSWORD:
                if (textEdit_password.Text != textEdit_confirmPassword.Text)
                {
                    XtraMessageBox.Show("Confirm Password không khớp!");
                    return false;
                }
                if (textEdit_password.Text.Length < 6 || textEdit_password.Text.Length > 20)
                {
                    XtraMessageBox.Show("Password phải từ 6-20 ký tự!");
                    return false;
                }
                else
                    tempPassword = textEdit_password.Text; // Get password:

                // Get giới tính:
                tempGioiTinh = (radioBtn_Nam.Checked == true) ? true : false;
                
                // Get isACtive:
                tempIsActive = (radio_kichHoat.Checked == true) ? true : false;
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi check thông tin: " + ex.Message);
                return false;
            }
        }
    }
}
