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
using BUS;

namespace Presentation_Tier
{
    public partial class UserControl_EditPhieuThu : UserControl
    {
        private static UserControl_EditPhieuThu _instance;
        public static UserControl_EditPhieuThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditPhieuThu();
                return _instance;
            }
        }
        //Tạo các biến lưu giá trị trên màn hình:
        string tempMaPT, tempNgayLap, tempMaNV, tempMaKH;
        int tempSoTienNo, tempSoTienThu;
        
        public UserControl_EditPhieuThu()
        {
            InitializeComponent();
            try
            {
                UserControl_AddPhieuThu.tableKhachHang = UserControl_AddPhieuThu.objKHBus.Load_DSKhachHang();
                //Khởi tạo item cho comboBox mã KH:
                foreach (DataRow dr in UserControl_AddPhieuThu.tableKhachHang.Rows)
                    if (!comboBox_makH.Properties.Items.Contains(dr["MaKH"].ToString()))
                        comboBox_makH.Properties.Items.Add(dr["MaKH"].ToString());
                //comboBox_makH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
            
        }

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
                XtraMessageBox.Show("Lỗi tính tổng tiền nợ: " + ex.Message);
            }

        }
        public void loadDataFromGridview()
        {
            try
            {
                DataRow dr = UserControl_ListPhieuThu.selectedRow;
                textEdit_maPhieuThu.Text = dr["Mã Phiếu Thu"].ToString();
                dateEdit_ngayLap.SelectedText = dr["Ngày Lập"].ToString();
                textEdit_maNV.Text = dr["Mã NV Lập"].ToString();
                comboBox_makH.Text = dr["Mã Khách Hàng"].ToString();
                textEdit_soTienNo.Text = dr["Số Tiền Nợ"].ToString();
                textEdit_soTienThu.Text = dr["Số Tiền Thu"].ToString();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void textEdit_soTienNo_EditValueChanged(object sender, EventArgs e)
        {
            tinhTongTienNo();
        }

        private void textEdit_soTienThu_EditValueChanged(object sender, EventArgs e)
        {
            tinhTongTienNo();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListPhieuThu.Instance);
            UserControl_ListPhieuThu.Instance.BringToFront();
            //Enable các btn:
            UserControl_ListButton_PhieuThu.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_PhieuThu.Instance.btn_Xoa.Enabled = true;
            UserControl_ListButton_PhieuThu.Instance.btn_themMoi.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkUpdateInformation())
            {
                try
                {
                    //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                    PhieuThu tempPhieuThu = new PhieuThu(tempMaPT, Convert.ToDateTime(tempNgayLap), tempMaNV, tempMaKH,
                                                        tempSoTienNo, tempSoTienThu);
                    bool updated = false;
                    updated = UserControl_ListPhieuThu.objPhieuThuBUS.updatePhieuThu(tempPhieuThu);
                    if (updated)
                    {
                        //Trở về màn hình List:
                        UserControl_ListPhieuThu.Instance.loadDanhSachPhieuThu();
                        UserControl_ListPhieuThu.Instance.BringToFront();
                        UserControl_ListPhieuThu.Instance.label_notification.Text = "Cập nhật thành công!";
                        //Enable/Disable các btn:
                        UserControl_ListButton_PhieuThu.Instance.btn_themMoi.Enabled = true;
                        UserControl_ListButton_PhieuThu.Instance.btn_Edit.Enabled = false;
                        UserControl_ListButton_PhieuThu.Instance.btn_Xoa.Enabled = false;
                    }
                    else
                        XtraMessageBox.Show("Cập nhật không thành công!");
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
        private bool checkUpdateInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                tempMaPT = textEdit_maPhieuThu.Text;
                //KIỂM TRA NGÀY LẬP:

                tempNgayLap = dateEdit_ngayLap.Text;
                //KIỂM TRA MÃ NV: (Mã NV không thể sửa)
                tempMaNV = textEdit_maNV.Text;

                //KIỂM TRA MÃ KH:
                tempMaKH = comboBox_makH.SelectedItem.ToString();
                if (tempMaKH.Length == 0)
                {
                    XtraMessageBox.Show("Hãy chọn mã Khách Hàng!");
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

                //KIỂM TRA SỐ TIỀN THU:
                Regex regexSoTienThu = new Regex(@"^[0-9]$");
                for (int i = 0; i < textEdit_soTienThu.Text.ToString().Length; i++)
                    if (!regexSoTienThu.IsMatch(textEdit_soTienThu.Text.ToString()[i].ToString()))
                    {
                        XtraMessageBox.Show("Số tiền thu không hợp lệ!");
                        return false;
                    }
                tempSoTienThu = Int32.Parse(textEdit_soTienThu.Text.ToString());

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
