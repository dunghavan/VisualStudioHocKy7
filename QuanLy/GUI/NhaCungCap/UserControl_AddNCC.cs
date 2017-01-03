using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using DTO;

namespace GUI
{
    public partial class UserControl_AddNCC : DevExpress.XtraEditors.XtraUserControl
    {

        private static UserControl_AddNCC _instance;
        public static UserControl_AddNCC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddNCC();
                return _instance;
            }
        }
        public UserControl_AddNCC()
        {
            InitializeComponent();
        }
        //Tạo các biến lưu giá trị trên màn hình:
        string tempmaNCC, temptenNCC, tempdiaChi, tempsoDT,tempghiChu;


        bool tempIsActive = false;

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            btn_Luu_Click(sender, e);
        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListNCC.Instance);
            UserControl_ListNCC.Instance.BringToFront();

            //Enable/disable các btn:
            UserControl_ListButton_NCC.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListNCC.Instance);
            UserControl_ListNCC.Instance.BringToFront();

            //Enable/disable các btn:
            UserControl_ListButton_NCC.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = false;
        }
        public void resetAllField()
        {
            textEdit_maNCC.Text = null;
            textEdit_tenNCC.Text = null;
            textEdit_diaChi.Text = null;
            textEdit_ghiChu.Text = null;
            textEdit_soDT.Text = null;
            radio_voHieuHoa.Select();

        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {

            if (checkAddNewInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                DTO.NhaCungCap tempNCC = new DTO.NhaCungCap(tempmaNCC, temptenNCC, tempdiaChi, tempsoDT, tempghiChu, tempIsActive);
                bool inserted = false;
                inserted = UserControl_ListNCC.objNCCBus.addNCC(tempNCC);
                if (inserted)
                {
                    //Trở về màn hình List:
                    Form parentForm = this.FindForm();
                    UserControl_ListNCC.Instance.loadDanhSachNCC();
                    if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListNCC.Instance))
                        ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListNCC.Instance);
                    UserControl_ListNCC.Instance.BringToFront();

                    UserControl_ListNCC.Instance.label_notification.Text = "Thêm thành công!";

                    //Enable/disable các btn:
                    UserControl_ListButton_NCC.Instance.btn_themMoi.Enabled = true;
                    UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = false;
                    UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = false;
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
                tempmaNCC = textEdit_maNCC.Text;
                temptenNCC = textEdit_tenNCC.Text;
                tempdiaChi = textEdit_diaChi.Text;
                tempsoDT = textEdit_soDT.Text;
                tempghiChu = textEdit_ghiChu.Text;
           


                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regexTen = new Regex(@"^[a-zA-Z\sáàảãạăắằẳẵặâấầẩẫậúùủũụưứừửữựéèẻẽẹêếềểễệíìỉĩịýỳỷỹỵóòỏõọôốồổỗộơớờởỡợđĐ]$");

                //KIỂM TRA MÃ NHÀ CUNG CẤP:
                foreach (DataRow dr in UserControl_ListNCC.tableNCC.Rows)
                    if (tempmaNCC == dr["MaNCC"].ToString())
                    {
                        XtraMessageBox.Show("Mã nhà cung cấp đã tồn tại!");
                        return false;
                    }
                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regexmaNCC = new Regex(@"^[a-zA-Z0-9]$");
                if (tempmaNCC.Length == 0)
                {
                    XtraMessageBox.Show("Hãy nhập mã nhà cung cấp!");
                    return false;
                }
                for (int i = 0; i < tempmaNCC.Length; i++)
                {
                    if (tempmaNCC[i].ToString() == " ") //Kiểm tra khoảng trắng
                    {
                        XtraMessageBox.Show("Mã nhà cung cấp không được chứa ký tự space!");
                        return false;
                    }
                    if (!regexmaNCC.IsMatch(tempmaNCC[i].ToString())) //Kiểm tra không thuộc regex đã tạo
                    {
                        XtraMessageBox.Show("Mã nhà cung cấp không hợp lệ!");
                        return false;
                    }
                }

                //KIỂM TRA TÊN NHÀ CUNG CẤP:
                for (int i = 0; i < temptenNCC.Length; i++)
                {
                    if (!regexTen.IsMatch(temptenNCC[i].ToString()))
                    {
                        XtraMessageBox.Show("Tên nhà cung cấp không hợp lệ!");
                        return false;
                    }
                }

                //KIỂM TRA SDT:
                tempsoDT = textEdit_soDT.Text;
                Regex regexSDT = new Regex(@"^[0-9]$");
                for (int i = 0; i < tempsoDT.Length; i++)
                    if (!regexSDT.IsMatch(tempsoDT[i].ToString()))
                    {
                        XtraMessageBox.Show("Số điện thoại không hợp lệ!");
                        return false;
                    }
                if (tempsoDT.Length < 8 || tempsoDT.Length > 12)
                {
                    XtraMessageBox.Show("Số điện thoại phải từ 8 đến 12 số!");
                    return false;
                }

                //KIỂM TRA ĐỊA CHỈ:
                for (int i = 0; i < tempdiaChi.Length; i++)
                {
                    if (!regexTen.IsMatch(tempdiaChi[i].ToString()))
                    {
                        XtraMessageBox.Show("Địa chỉ nhà cung cấp không hợp lệ!");
                        return false;
                    }
                }

                
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
