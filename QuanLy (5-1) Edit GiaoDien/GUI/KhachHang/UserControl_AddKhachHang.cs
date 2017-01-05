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
using DAO;

namespace GUI
{
    public partial class UserControl_AddKhachHang : UserControl
    {
        private static UserControl_AddKhachHang _instance;
        public static UserControl_AddKhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddKhachHang();
                return _instance;
            }
        }
        public UserControl_AddKhachHang()
        {
            InitializeComponent();
            
        }
        // tạo các biến lưu giá trị trên màn hình
        string tempMaKH, tempHoTen, tempDiaChi, tempSDT, tempGhiChu;
        bool tempIsActive;
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_QLKH.Instance);
            UserControl_QLKH.Instance.BringToFront();

            //Enable/disable các btn:
            UserControl_ListButton_KH.Instance.btn_them.Enabled = true;
            UserControl_ListButton_KH.Instance.btn_Sua.Enabled = false;
            UserControl_ListButton_KH.Instance.btn_Xoa.Enabled = false;
        }

     
        public void resetAllField()
        {
            textEdit_maKH.Text = null;
            textEdit_hoten.Text = null;
            textEdit_diachi.Text = null;
            textEdit_sodt.Text = null;
            radio_voHieuHoa.Select();

        }
        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkAddNewInformation())
                {
                    KhachHangDTO tempKhachHang = new KhachHangDTO(tempMaKH, tempHoTen, tempDiaChi, tempSDT, tempGhiChu, tempIsActive);

                    bool inserted = false;
                    inserted = UserControl_QLKH.khBUS.Insert_KhachHang(tempMaKH, tempHoTen, tempDiaChi, tempSDT, tempGhiChu, tempIsActive);

                    if (inserted)
                    {
                        // trở về màn hình list
                        Form parentForm = this.FindForm();
                        UserControl_QLKH.Instance.loadDanhSachKH();
                        if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_QLKH.Instance))
                            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_QLKH.Instance);
                        UserControl_QLKH.Instance.BringToFront();

                        UserControl_QLKH.Instance.label_notification.Text = "Thêm thành công!";
                        //Enable/disable các btn:
                        UserControl_ListButton_KH.Instance.btn_them.Enabled = true;
                        UserControl_ListButton_KH.Instance.btn_Sua.Enabled = false;
                        UserControl_ListButton_KH.Instance.btn_Xoa.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Lưu không thành công!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private bool checkAddNewInformation()
        {
            try
            {

                // kiểm tra mã khách hàng
                tempMaKH = textEdit_maKH.Text;
                foreach (DataRow dr in UserControl_QLKH.tableKhachHang.Rows)
                    if (tempMaKH == dr["MaKH"].ToString())
                    {
                        XtraMessageBox.Show("Mã khách hàng đã tồn tại!");
                        return false;
                    }
                // tạo 1 regex chứa các ký tự cho phép
                Regex regexMaKH = new Regex(@"^[a-zA-Z0-9]$");
                if (tempMaKH.Length == 0)
                {
                    XtraMessageBox.Show("Hãy nhập mã khách hàng!");
                    return false;
                }
                for (int i = 0; i < tempMaKH.Length; i++)
                {
                    if (tempMaKH[i].ToString() == " ") //Kiểm tra khoảng trắng
                    {
                        XtraMessageBox.Show("Mã khách hàng không được chứa ký tự space!");
                        return false;
                    }
                    if (!regexMaKH.IsMatch(tempMaKH[i].ToString())) //Kiểm tra không thuộc regex đã tạo
                    {
                        XtraMessageBox.Show("Mã khách hàng không hợp lệ!");
                        return false;
                    }
                }

                // kiểm tra họ tên
                tempHoTen = textEdit_hoten.Text;

                //tạo 1 regex chứa các ký tự cho phép:
                Regex regexHoTen = new Regex(@"^[a-zA-Z\sáàảãạăắằẳẵặâấầẩẫậúùủũụưứừửữựéèẻẽẹêếềểễệíìỉĩịýỳỷỹỵóòỏõọôốồổỗộơớờởỡợđĐ]$");
                for (int i = 0; i < tempHoTen.Length; i++)
                {
                    if (!regexHoTen.IsMatch(tempHoTen[i].ToString()))
                    {
                        XtraMessageBox.Show("Họ tên khách hàng không hợp lệ! ");
                        return false;
                    }
                }

                // kiểm tra sdt
                tempSDT = textEdit_sodt.Text;
                Regex regexSDT = new Regex(@"^[0-9]$");
                for (int i = 0; i < tempSDT.Length; i++)
                    if (!regexSDT.IsMatch(tempSDT[i].ToString()))
                    {
                        XtraMessageBox.Show("Số điện thoại không hợp lệ !");
                        return false;
                    }
                if (tempSDT.Length < 8 || tempSDT.Length > 12)
                {
                    XtraMessageBox.Show("Số điện thoại phải 8 đến 12 số");
                    return false;

                }

                //get isActive
                tempIsActive = (radio_kichHoat.Checked == true) ? true : false;
                // 
                tempDiaChi = textEdit_diachi.Text;
                tempGhiChu = textEdit_ghichu.Text;
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
