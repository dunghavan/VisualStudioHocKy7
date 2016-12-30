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
using BUS;

namespace Presentation_Tier
{
    public partial class UserControl_AddPhieuChi : UserControl
    {
        private static UserControl_AddPhieuChi _instance;
        public static UserControl_AddPhieuChi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddPhieuChi();
                return _instance;
            }
        }
        public static NhaCungCapBUS objNCCBus = new NhaCungCapBUS();
        public static DataTable tableNhaCungCap = new DataTable();
        public UserControl_AddPhieuChi()
        {
            InitializeComponent();
            try
            {
                //Khởi tạo item cho comboBox mã NCC:
                tableNhaCungCap = objNCCBus.getAllNhaCungCap();
                foreach (DataRow dr in tableNhaCungCap.Rows)
                    if (!comboBox_maNCC.Properties.Items.Contains(dr["MaNCC"].ToString()))
                        comboBox_maNCC.Properties.Items.Add(dr["MaNCC"].ToString());

                //Khởi tạo gán giá trị cho mã NV:
                textEdit_maNV.Text = UserControl_Login.login_User.maNhanVien;
                //Khởi tạo mã NCC:

                //
                textEdit_maPhieuChi.Focus();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi load dữ liệu:" + ex.Message);
            }
            
        }

        //Tạo các biến lưu giá trị trên màn hình:
        string tempMaPC, tempNgayLap, tempMaNV, tempMaNCC;
        int tempSoTienNo, tempSoTienChi;

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListPhieuChi.Instance);
            UserControl_ListPhieuChi.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_PhieuChi.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_PhieuChi.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_PhieuChi.Instance.btn_Xoa.Enabled = false;
        }
        
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(checkAddNewInformation())
            {
                try
                {
                    //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                    PhieuChi tempPhieuChi = new PhieuChi(tempMaPC, Convert.ToDateTime(tempNgayLap), tempMaNV, tempMaNCC,
                                                        tempSoTienNo, tempSoTienChi);
                    bool inserted = false;
                    inserted = UserControl_ListPhieuChi.objPhieuChiBUS.addPhieuChi(tempPhieuChi);
                    if (inserted)
                    {
                        //XtraMessageBox.Show("Cập nhật thành công!");
                        UserControl_ListPhieuChi.Instance.loadDanhSachPhieuChi();
                        UserControl_ListPhieuChi.Instance.BringToFront();

                        UserControl_ListPhieuChi.Instance.label_notification.Text = "Thêm thành công!";

                        //Enable các btn:
                        UserControl_ListButton_PhieuChi.Instance.btn_themMoi.Enabled = true;
                        UserControl_ListButton_PhieuChi.Instance.btn_Edit.Enabled = false;
                        UserControl_ListButton_PhieuChi.Instance.btn_Xoa.Enabled = false;
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công!");
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Lỗi lưu thông tin: " + ex.Message);
                }
            }
            else
            {
                
            }
        }

        public void resetAllField()
        {
            textEdit_maPhieuChi.Text = null;
            comboBox_maNCC.Text = null;
            textEdit_soTienNo.Text = "0";
            textEdit_soTienChi.Text = "0";
        }
        private bool checkAddNewInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                //KIỂM TRA MÃ PHIẾU THU:
                tempMaPC = textEdit_maPhieuChi.Text;
                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regexMaPC = new Regex(@"^[a-zA-Z0-9]$");
                if (tempMaPC.Length == 0)
                {
                    XtraMessageBox.Show("Hãy nhập mã phiếu chi!");
                    return false;
                }
                for (int i = 0; i < tempMaPC.Length; i++)
                {
                    if (tempMaPC[i].ToString() == " ") //Kiểm tra khoảng trắng
                    {
                        XtraMessageBox.Show("Mã phiếu chi không được chứa ký tự space!");
                        return false;
                    }
                    if (!regexMaPC.IsMatch(tempMaPC[i].ToString())) //Kiểm tra không thuộc regex đã tạo
                    {
                        XtraMessageBox.Show("Mã phiếu chi không hợp lệ!");
                        return false;
                    }
                }
                foreach (DataRow dr in UserControl_ListPhieuChi.tablePhieuChi.Rows)
                {
                    if(tempMaPC == dr["MaPC"].ToString())
                    {
                        XtraMessageBox.Show("Mã phiếu chi đã tồn tại!");
                        return false;
                    }
                }

                //KIỂM TRA NGÀY LẬP:
                //DateTime dateTime = Convert.ToDateTime(dateEdit_ngayLap.SelectedText);

                tempNgayLap = dateEdit_ngayLap.Text;
                //GET MÃ NV:
                tempMaNV = textEdit_maNV.Text;
                //KIỂM TRA MÃ NCC:
                tempMaNCC = comboBox_maNCC.Text;
                if(tempMaNCC.Length == 0)
                    {
                        XtraMessageBox.Show("Hãy chọn mã Nhà Cung Cấp!");
                        return false;
                    }
                //KIỂM TRA SỐ TIỀN NỢ:
                Regex regexSoTienNo = new Regex(@"^[0-9]$");
                for (int i = 0; i < textEdit_soTienNo.Text.ToString().Length; i++)
                    if (!regexSoTienNo.IsMatch(textEdit_soTienNo.Text.ToString()[i].ToString()))
                    {
                        XtraMessageBox.Show("Số tiền nợ không hợp lệ!");
                        return false;
                    }
                tempSoTienNo = Int32.Parse(textEdit_soTienNo.Text.ToString());
                if (tempSoTienNo < 0 || tempSoTienNo > 20000000)
                {
                    XtraMessageBox.Show("Số tiền nợ không vượt quá 20.000.000đ!");
                    return false;
                }

                //KIỂM TRA SỐ TIỀN CHI:
                Regex regexSoTienChi = new Regex(@"^[0-9]$");
                for (int i = 0; i < textEdit_soTienChi.Text.ToString().Length; i++)
                    if (!regexSoTienChi.IsMatch(textEdit_soTienChi.Text.ToString()[i].ToString()))
                    {
                        XtraMessageBox.Show("Số tiền chi không hợp lệ!");
                        return false;
                    }
                tempSoTienChi = Int32.Parse(textEdit_soTienChi.Text.ToString());
                //if (tempSoTienThu < 0 || tempSoTienThu > 20000000)
                //{
                //    XtraMessageBox.Show("Số tiền nợ không vượt quá 20.000.000đ!");
                //    return false;
                //}

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
