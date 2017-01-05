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

namespace GUI
{
    public partial class UserControl_AddPhieuThu : UserControl
    {
        private static UserControl_AddPhieuThu _instance;
        public static UserControl_AddPhieuThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddPhieuThu();
                return _instance;
            }
        }
        public static KhachHangBUS objKHBus = new KhachHangBUS();
        public static DataTable tableKhachHang = new DataTable();

        public UserControl_AddPhieuThu()
        {
            InitializeComponent();
            try
            {
                //Khởi tạo item cho comboBox mã KH:
                tableKhachHang = objKHBus.Load_DSKhachHang();
                foreach (DataRow dr in tableKhachHang.Rows)
                    if (!comboBox_makH.Properties.Items.Contains(dr["MaKH"].ToString()))
                        comboBox_makH.Properties.Items.Add(dr["MaKH"].ToString());

                //Khởi tạo gán giá trị cho mã NV:
                textEdit_maNV.Text = UserControl_Login.login_User.maNhanVien;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
            //
            textEdit_maPhieuThu.Focus();
        }

        //Tạo các biến lưu giá trị trên màn hình:
        string tempMaPT, tempNgayLap, tempMaNV, tempMaKH;
        int tempSoTienNo, tempSoTienThu;
        string _maKHSelected;

        private void comboBox_makH_SelectedValueChanged(object sender, EventArgs e)
        {
            _maKHSelected = comboBox_makH.Text;
            tinhTongTienNo();
        }
        public PhieuThuBUS objPTBUS = new PhieuThuBUS();
        private void tinhTongTienNo()
        {
            try
            {
            //Khởi tạo giá trị tổng tiền nợ từ trước dựa vào mã KH:
            if ((textEdit_soTienNo.Text.Length > 0) && (textEdit_soTienThu.Text.Length > 0))
                if (checkTienNo_TienThu())
                {
                    int tienNoTuTruoc = objPTBUS.getTongTienNo(_maKHSelected);
                    int tienNoMoi = Convert.ToInt32(textEdit_soTienNo.Text) - Convert.ToInt32(textEdit_soTienThu.Text);
                    textEdit_TongTienNo.Text = (tienNoTuTruoc + tienNoMoi).ToString();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tính tổng tiền nợ: " + ex.Message);
            }
            
        }

        private void textEdit_soTienThu_EditValueChanged(object sender, EventArgs e)
        {
            tinhTongTienNo();
        }
        private void textEdit_soTienNo_EditValueChanged(object sender, EventArgs e)
        {
            tinhTongTienNo();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListPhieuThu.Instance);
            UserControl_ListPhieuThu.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_PhieuThu.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_PhieuThu.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_PhieuThu.Instance.btn_Xoa.Enabled = false;
        }
        
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(checkAddNewInformation())
            {
                try
                {
                    //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                    PhieuThu tempPhieuThu = new PhieuThu(tempMaPT, Convert.ToDateTime(tempNgayLap), tempMaNV, tempMaKH,
                                                        tempSoTienNo, tempSoTienThu);
                    bool inserted = false;
                    inserted = UserControl_ListPhieuThu.objPhieuThuBUS.addPhieuThu(tempPhieuThu);
                    if (inserted)
                    {
                        //XtraMessageBox.Show("Cập nhật thành công!");
                        UserControl_ListPhieuThu.Instance.loadDanhSachPhieuThu();
                        UserControl_ListPhieuThu.Instance.BringToFront();

                        UserControl_ListPhieuThu.Instance.label_notification.Text = "Thêm thành công!";

                        //Enable các btn:
                        UserControl_ListButton_PhieuThu.Instance.btn_themMoi.Enabled = true;
                        UserControl_ListButton_PhieuThu.Instance.btn_Edit.Enabled = false;
                        UserControl_ListButton_PhieuThu.Instance.btn_Xoa.Enabled = false;
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
            textEdit_maPhieuThu.Text = null;
            comboBox_makH.Text = null;
            textEdit_soTienNo.Text = "0";
            textEdit_soTienThu.Text = "0";
        }
        private bool checkAddNewInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                //KIỂM TRA MÃ PHIẾU THU:
                tempMaPT = textEdit_maPhieuThu.Text;
                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regexMaNPT = new Regex(@"^[a-zA-Z0-9]$");
                if (tempMaPT.Length == 0)
                {
                    XtraMessageBox.Show("Hãy nhập mã phiếu thu!");
                    return false;
                }
                for (int i = 0; i < tempMaPT.Length; i++)
                {
                    if (tempMaPT[i].ToString() == " ") //Kiểm tra khoảng trắng
                    {
                        XtraMessageBox.Show("Mã phiếu thu không được chứa ký tự space!");
                        return false;
                    }
                    if (!regexMaNPT.IsMatch(tempMaPT[i].ToString())) //Kiểm tra không thuộc regex đã tạo
                    {
                        XtraMessageBox.Show("Mã phiếu thu không hợp lệ!");
                        return false;
                    }
                }
                foreach (DataRow dr in UserControl_ListPhieuThu.tablePhieuThu.Rows)
                {
                    if(tempMaPT == dr["MaPT"].ToString())
                    {
                        XtraMessageBox.Show("Mã phiếu thu đã tồn tại!");
                        return false;
                    }
                }

                //KIỂM TRA NGÀY LẬP:
                //DateTime dateTime = Convert.ToDateTime(dateEdit_ngayLap.SelectedText);

                tempNgayLap = dateEdit_ngayLap.Text;
                //GET MÃ NV:
                tempMaNV = textEdit_maNV.Text;
                //KIỂM TRA MÃ KH:
                tempMaKH = comboBox_makH.Text;
                if(tempMaKH.Length == 0)
                    {
                        XtraMessageBox.Show("Hãy chọn mã Khách Hàng!");
                        return false;
                    }
                //KIỂM TRA SỐ TIỀN NỢ LẦN NÀY:
                Regex regexSoTienNo = new Regex(@"^[0-9]$");
                for (int i = 0; i < textEdit_soTienNo.Text.ToString().Length; i++)
                    if (!regexSoTienNo.IsMatch(textEdit_soTienNo.Text.ToString()[i].ToString()))
                    {
                        XtraMessageBox.Show("Số tiền nợ không hợp lệ!");
                        return false;
                    }
                tempSoTienNo = Int32.Parse(textEdit_soTienNo.Text.ToString());
                

                //KIỂM TRA SỐ TIỀN THU:
                Regex regexSoTienThu = new Regex(@"^[0-9]$");
                for (int i = 0; i < textEdit_soTienThu.Text.ToString().Length; i++)
                    if (!regexSoTienThu.IsMatch(textEdit_soTienThu.Text.ToString()[i].ToString()))
                    {
                        XtraMessageBox.Show("Số tiền thu không hợp lệ!");
                        return false;
                    }
                tempSoTienThu = Int32.Parse(textEdit_soTienThu.Text.ToString());

                //KIỂM TRA TỔNG TIỀN NỢ:
                ThamSoBUS objTSBUS = new ThamSoBUS();
                int soTienNoToiDa = objTSBUS.TienNoToiDa();

                int tempTongTienNo = Convert.ToInt32(textEdit_TongTienNo.Text);
                if (tempTongTienNo < 0 || tempTongTienNo > soTienNoToiDa)
                {
                    XtraMessageBox.Show("Số tiền nợ không vượt quá " + soTienNoToiDa + "đ!");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi check thông tin: " + ex.Message);
                return false;
            }
        }
        private bool checkTienNo_TienThu()
        {
            //KIỂM TRA SỐ TIỀN NỢ LẦN NÀY:
            Regex regexSoTienNo = new Regex(@"^[0-9]$");
            for (int i = 0; i < textEdit_soTienNo.Text.ToString().Length; i++)
                if (!regexSoTienNo.IsMatch(textEdit_soTienNo.Text.ToString()[i].ToString()))
                {
                    XtraMessageBox.Show("Số tiền nợ không hợp lệ!");
                    return false;
                }


            //KIỂM TRA SỐ TIỀN THU:
            Regex regexSoTienThu = new Regex(@"^[0-9]$");
            for (int i = 0; i < textEdit_soTienThu.Text.ToString().Length; i++)
                if (!regexSoTienThu.IsMatch(textEdit_soTienThu.Text.ToString()[i].ToString()))
                {
                    XtraMessageBox.Show("Số tiền thu không hợp lệ!");
                    return false;
                }
            return true;
        }

    }
}
