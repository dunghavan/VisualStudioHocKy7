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


namespace GUI
{
    public partial class UserControl_EditKhachHang : UserControl
    {
        public UserControl_EditKhachHang()
        {
            InitializeComponent();
        }
        private static UserControl_EditKhachHang _instance;
        public static UserControl_EditKhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditKhachHang();
                return _instance;
            }
        }
        // mảng số nguyên chứa số thứ tự của các rows
        public int[] selectedRows = null;
        // tạo các biến lưu giá trị trên màn hình:
        string tempMaKH, tempHoTen, tempDiaChi, tempSDT, tempGhiChu;
        bool tempIsActive;

        public void loadDataFromGridView()
        {
            try
            { 
                // gán row đã chọn trong mảng []selectedRows vào dr
                DataRow dr = UserControl_QLKH.Instance.gridView_DSKhachHang.GetDataRow(UserControl_QLKH.selectedRowsArray[0]);
                textEdit_maKH.Text = dr["Mã KH"].ToString();
                textEdit_hoten.Text = dr["Họ Tên"].ToString();
                textEdit_diachi.Text = dr["Địa chỉ"].ToString();
                textEdit_sodt.Text = dr["Số điện thoại"].ToString();
                textEdit_ghichu.Text = dr["Ghi chú"].ToString();
                if (dr["Trạng Thái"].ToString() == "Đang kích hoạt")
                    radio_kichHoat.Select();
                else
                    radio_voHieuHoa.Select();

            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkUpdateInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");

                bool updated = false;
                updated = UserControl_QLKH.khBUS.Update_KhachHang(tempMaKH, tempHoTen, tempDiaChi, tempSDT, tempGhiChu, tempIsActive);
                if (updated)
                {
                    //XtraMessageBox.Show("Cập nhật thành công!");
                    UserControl_QLKH.Instance.loadDanhSachKH();
                    UserControl_QLKH.Instance.BringToFront();
                    UserControl_QLKH.Instance.label_notification.Text = "Cập nhật thành công!";
                    UserControl_ListButton_KH.Instance.btn_them.Enabled = true;
                    UserControl_ListButton_KH.Instance.btn_Sua.Enabled = false;
                    UserControl_ListButton_KH.Instance.btn_Xoa.Enabled = false;
                }
                else
                    XtraMessageBox.Show("Cập nhật không thành công!");

            }
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_QLKH.Instance);
            UserControl_QLKH.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_KH.Instance.btn_Sua.Enabled = true;
            UserControl_ListButton_KH.Instance.btn_Xoa.Enabled = true;
            UserControl_ListButton_KH.Instance.btn_them.Enabled = true;
        }

        private bool checkUpdateInformation()
        {
            try
            {
                // kiểm tra mã nhân viên
                tempMaKH = textEdit_maKH.Text;
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

                //get địa chỉ, Ghi chú:
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
