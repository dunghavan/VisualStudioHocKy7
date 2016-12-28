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
using System.Text.RegularExpressions;
using DTO;

namespace Presentation_Tier
{
    public partial class UserControl_EditUser : UserControl
    {
        private static UserControl_EditUser _instance;
        public static UserControl_EditUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditUser();
                return _instance;
            }
        }
        //Tạo các biến lưu giá trị trên màn hình:
        string tempMaNV, tempHoTen, tempNamSinh, tempSDT, tempEmail = null, tempMaLoaiNV, tempUsername, temPassword;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_QLUser.Instance);
            UserControl_QLUser.Instance.BringToFront();
        }

        bool tempGioiTinh = false;
        public UserControl_EditUser()
        {
            InitializeComponent();
        }
        public void loadDataFromGridview()
        {
            try
            {
                //Khởi tạo item cho comboBox mã loại nhân viên:
                comboBox_maLoaiNV.Properties.Items.Add("QLK");
                comboBox_maLoaiNV.Properties.Items.Add("BH");
                comboBox_maLoaiNV.Properties.Items.Add("NH");

                //Khởi tạo item cho conboBox năm sinh:
                for(int i = 1900; i < 2017; i ++)
                {
                    comboBox_namSinh.Properties.Items.Add(i.ToString());
                }
                //Gán row đã chọn trong mảng []selectedRows vào dr:
                DataRow dr = UserControl_QLUser.Instance.gridView_DSNhanVien.GetDataRow(UserControl_QLUser.selectedRowsArray[0]);
                textEdit_maNV.Text = dr["Mã NV"].ToString();
                textEdit_hoTen.Text = dr["Họ Tên"].ToString();
                comboBox_namSinh.Text = dr["Năm Sinh"].ToString();
                if (dr["Giới Tính"].ToString() == "Nam")
                    radioBtn_Nam.Select();
                else
                    radioBtn_Nu.Select();

                textEdit_SDT.Text = dr["Số ĐT"].ToString();
                textEdit_email.Text = dr["Email"].ToString();
                comboBox_maLoaiNV.Text = dr["Mã Loại NV"].ToString();
                textEdit_username.Text = dr["Username"].ToString();
                textEdit_password.Text = dr["Password"].ToString();
                textEdit_confirmPassword.Text = dr["Password"].ToString();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_QLUser.Instance);
            UserControl_QLUser.Instance.BringToFront();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkUpdateInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                NhanVien tempNhanVien = new NhanVien(tempMaNV, tempHoTen, Convert.ToInt32(tempNamSinh), tempGioiTinh,
                                                    tempSDT, tempEmail, tempUsername, temPassword, tempMaLoaiNV);
                bool updated = false;
                updated = MainForm.objNVBus.updateNhanVien(tempNhanVien);
                if (updated)
                {
                    //XtraMessageBox.Show("Cập nhật thành công!");
                    UserControl_QLUser.Instance.loadDanhSachNV();
                    UserControl_QLUser.Instance.BringToFront();
                    UserControl_QLUser.Instance.label_notification.Text = "Cập nhật thành công!";
                }
                else
                    XtraMessageBox.Show("Cập nhật không thành công!");

            }
            else
            {

            }


        }
        private bool checkUpdateInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                tempMaNV = textEdit_maNV.Text;
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
                for(int i = 0; i < tempNamSinh.Length; i++)
                    if(!regexNamSinh.IsMatch(tempNamSinh[i].ToString()))
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
                if(isExist == false)
                    {
                        XtraMessageBox.Show("Mã loại NV không hợp lệ!");
                        return false;
                    }

                //KIỂM TRA USERNAME:
                tempUsername = textEdit_username.Text;
                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regexUsername = new Regex(@"^[a-zA-Z0-9]$");
                if(tempUsername.Length > 0) //Đã nhập username
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
                if(textEdit_password.Text != textEdit_confirmPassword.Text)
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
                    temPassword = textEdit_password.Text;

                // Get giới tính:
                tempGioiTinh = (radioBtn_Nam.Checked == true) ? true : false;

                return true;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi check thông tin: " + ex.Message);
                return false;
            }
        }
    }
}
