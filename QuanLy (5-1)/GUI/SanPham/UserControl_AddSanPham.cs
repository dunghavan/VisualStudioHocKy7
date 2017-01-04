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
    public partial class UserControl_AddSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserControl_AddSanPham _instance;
        public static UserControl_AddSanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddSanPham();
                return _instance;
            }
        }
        public UserControl_AddSanPham()
        {
            InitializeComponent();
    
        }

        //Tạo các biến lưu giá trị trên màn hình:
        string tempMaSP, tempTenSP, tempMaLoai, tempDonVi, tempDonGia, tempGhiChu,tempSoLuong;
        
        bool tempIsActive = false;

        private void textEdit_confirmPassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_maLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEdit_username_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListSanPham.Instance);
            UserControl_ListSanPham.Instance.BringToFront();

            //Enable/disable các btn:
            UserControl_ListButton_SanPham.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_SanPham.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = false;
        }

        public void resetAllField()
        {
            textEdit_maSP.Text = null;
            textEdit_tenSP.Text = null;
            textEdit_donGia.Text = null;
            textEdit_ghiChu.Text = null;
            textEdit_maLoaiSP.Text = null;
            textEdit_donVi.Text = null;
            textEdit_soLuong.Text = null;
            radio_voHieuHoa.Select();

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            tempMaSP = textEdit_maSP.Text;
            tempTenSP = textEdit_tenSP.Text;
            tempDonGia = textEdit_donGia.Text;
            tempGhiChu = textEdit_ghiChu.Text;
            tempMaLoai = textEdit_maLoaiSP.Text;
            tempDonVi = textEdit_donVi.Text;
            tempSoLuong = textEdit_soLuong.Text;
            tempIsActive = (radio_kichHoat.Checked == true) ? true : false;
            if (checkAddNewInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                DTO.SanPham tempSanPham = new DTO.SanPham(tempMaSP, tempTenSP, tempDonVi, Convert.ToInt32(tempDonGia), tempGhiChu, tempMaLoai, Convert.ToInt32(tempSoLuong), tempIsActive);
                bool inserted = false;
                inserted = UserControl_ListSanPham.objSPBus.addSP(tempSanPham);
                if (inserted)
                {
                    //Trở về màn hình List:
                    Form parentForm = this.FindForm();
                    UserControl_ListSanPham.Instance.loadDanhSachSP();
                    if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListSanPham.Instance))
                        ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListSanPham.Instance);
                    UserControl_ListSanPham.Instance.BringToFront();

                    UserControl_ListSanPham.Instance.label_notification.Text = "Thêm thành công!";

                    //Enable/disable các btn:
                    UserControl_ListButton_SanPham.Instance.btn_themMoi.Enabled = true;
                    UserControl_ListButton_SanPham.Instance.btn_Edit.Enabled = false;
                    UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = false;
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
                tempMaSP = textEdit_maSP.Text;
                tempTenSP = textEdit_tenSP.Text;
                tempDonVi = textEdit_donVi.Text;
                tempDonGia = textEdit_donGia.Text;
                tempGhiChu = textEdit_ghiChu.Text;
                tempMaLoai = textEdit_maLoaiSP.Text;
                tempSoLuong = (textEdit_soLuong.Text);


                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regex = new Regex(@"^[a-zA-Z\sáàảãạăắằẳẵặâấầẩẫậúùủũụưứừửữựéèẻẽẹêếềểễệíìỉĩịýỳỷỹỵóòỏõọôốồổỗộơớờởỡợđĐ]$");
                Regex regexSoLuong = new Regex(@"^[+]?[0-9]*\.?[0-9]+$");
                //KIỂM TRA TÊN SẢN PHẨM:
                for (int i = 0; i < tempTenSP.Length; i++)
                {
                    if (!regex.IsMatch(tempTenSP[i].ToString()))
                    {
                        XtraMessageBox.Show("Tên sản phẩm không hợp lệ!");
                        return false;
                    }
                }

                //KIỂM TRA ĐƠN VỊ:
                for (int i = 0; i < tempDonVi.Length; i++)
                {
                    if (!regex.IsMatch(tempDonVi[i].ToString()))
                    {
                        XtraMessageBox.Show("Đơn vị không hợp lệ!");
                        return false;
                    }
                }

                //KIỂM TRA ĐƠN GIÁ:
                if (!regexSoLuong.IsMatch(textEdit_donGia.Text))
                {
                    XtraMessageBox.Show("Số lượng sản phẩm không hợp lệ!");
                    return false;
                }


                //KIỂM TRA MÃ LOẠI:
                for (int i = 0; i < tempMaLoai.Length; i++)
                {
                    if (!regex.IsMatch(tempMaLoai[i].ToString()))
                    {
                        XtraMessageBox.Show("Mã loại sản phẩm không hợp lệ!");
                        return false;
                    }
                }
                //KIỂM TRA SỐ LƯỢNG:
             
                
                    if (!regexSoLuong.IsMatch(textEdit_soLuong.Text))
                    {
                        XtraMessageBox.Show("Số lượng sản phẩm không hợp lệ!");
                        return false;
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

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void textEdit_password_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label_loaiNV_Click(object sender, EventArgs e)
        {

        }

        private void label_confirmPass_Click(object sender, EventArgs e)
        {

        }
    }
}
