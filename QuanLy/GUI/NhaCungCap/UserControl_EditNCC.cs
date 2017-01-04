using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class UserControl_EditNCC : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserControl_EditNCC _instance;
        public static UserControl_EditNCC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditNCC();
                return _instance;
            }
        }
        public UserControl_EditNCC()
        {
            InitializeComponent();
        }
        //Tạo các biến lưu giá trị trên màn hình:
        string tempmaNCC, temptenNCC, tempdiaChi, tempsoDT, tempghiChu;
        bool tempIsActive = false;
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListNCC.Instance);
            UserControl_ListNCC.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = true;
            UserControl_ListButton_NCC.Instance.btn_themMoi.Enabled = true;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkAddNewInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                DTO.NhaCungCap tempNCC = new DTO.NhaCungCap(tempmaNCC, temptenNCC, tempdiaChi, tempsoDT, tempghiChu, tempIsActive);
                bool inserted = false;
                inserted = UserControl_ListNCC.objNCCBus.updateNhaCungCap(tempNCC);
                if (inserted)
                {
                    //Trở về màn hình List:
                    Form parentForm = this.FindForm();
                    UserControl_ListNCC.Instance.loadDanhSachNCC();
                    if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListNCC.Instance))
                        ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListNCC.Instance);
                    UserControl_ListNCC.Instance.BringToFront();

                    UserControl_ListNCC.Instance.label_notification.Text = "Sửa thành công!";

                    //Enable/disable các btn:
                    UserControl_ListButton_NCC.Instance.btn_themMoi.Enabled = true;
                    UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = false;
                    UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = false;
                }
                else
                    XtraMessageBox.Show("Sửa không thành công!");
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
                Regex regexTen = new Regex(@"^[a-zA-Z0-9\sáàảãạăắằẳẵặâấầẩẫậúùủũụưứừửữựéèẻẽẹêếềểễệíìỉĩịýỳỷỹỵóòỏõọôốồổỗộơớờởỡợđĐ]$");
                
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
        public void loadDataFromGridview()
        {
            try
            {


                //Gán row đã chọn trong mảng []selectedRows vào dr:
                DataRow dr = UserControl_ListNCC.Instance.gridView_DSNCC.GetDataRow(UserControl_ListNCC.selectedRowsArray[0]);
                textEdit_maNCC.Text = dr["Mã NCC"].ToString();
                textEdit_tenNCC.Text = dr["Tên NCC"].ToString();
                textEdit_diaChi.Text = dr["Địa Chỉ"].ToString();
                textEdit_soDT.Text = dr["Số Điện Thoại"].ToString();
                textEdit_ghiChu.Text = dr["Ghi Chú"].ToString();
                if (dr["Trạng Thái"].ToString() == "Đang kích hoạt")
                    radio_kichHoat.Select();
                else
                    radio_voHieuHoa.Select();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }


    }
}
