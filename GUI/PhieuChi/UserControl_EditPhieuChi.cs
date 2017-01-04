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
    public partial class UserControl_EditPhieuChi : UserControl
    {
        private static UserControl_EditPhieuChi _instance;
        public static UserControl_EditPhieuChi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditPhieuChi();
                return _instance;
            }
        }
        //Tạo các biến lưu giá trị trên màn hình:
        string tempMaPC, tempNgayLap, tempMaNV, tempMaNCC;
        int tempSoTienNo, tempSoTienChi;
        
        public UserControl_EditPhieuChi()
        {
            InitializeComponent();
            try
            {
                UserControl_AddPhieuChi.tableNhaCungCap = UserControl_AddPhieuChi.objNCCBus.getAllNhaCungCap();
                //Khởi tạo item cho comboBox mã KH:
                foreach (DataRow dr in UserControl_AddPhieuChi.tableNhaCungCap.Rows)
                    if (!comboBox_maNCC.Properties.Items.Contains(dr["MaNCC"].ToString()))
                        comboBox_maNCC.Properties.Items.Add(dr["MaNCC"].ToString());
                //comboBox_makH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
            
        }
        public void loadDataFromGridview()
        {
            try
            {
                DataRow dr = UserControl_ListPhieuChi.selectedRow;
                textEdit_maPhieuChi.Text = dr["Mã Phiếu Chi"].ToString();
                dateEdit_ngayLap.SelectedText = dr["Ngày Lập"].ToString();
                textEdit_maNV.Text = dr["Mã NV Lập"].ToString();
                comboBox_maNCC.Text = dr["Mã Nhà Cung Cấp"].ToString();
                textEdit_soTienNo.Text = dr["Số Tiền Nợ"].ToString();
                textEdit_soTienChi.Text = dr["Số Tiền Chi"].ToString();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListPhieuChi.Instance);
            UserControl_ListPhieuChi.Instance.BringToFront();
            //Enable các btn:
            UserControl_ListButton_PhieuChi.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_PhieuChi.Instance.btn_Xoa.Enabled = true;
            UserControl_ListButton_PhieuChi.Instance.btn_themMoi.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkUpdateInformation())
            {
                try
                {
                    //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                    PhieuChi tempPhieuChi = new PhieuChi(tempMaPC, Convert.ToDateTime(tempNgayLap), tempMaNV, tempMaNCC,
                                                        tempSoTienNo, tempSoTienChi);
                    bool updated = false;
                    updated = UserControl_ListPhieuChi.objPhieuChiBUS.updatePhieuChi(tempPhieuChi);
                    if (updated)
                    {
                        //XtraMessageBox.Show("Cập nhật thành công!");
                        UserControl_ListPhieuChi.Instance.loadDanhSachPhieuChi();
                        UserControl_ListPhieuChi.Instance.BringToFront();
                        UserControl_ListPhieuChi.Instance.label_notification.Text = "Cập nhật thành công!";
                    }
                    else
                        XtraMessageBox.Show("Cập nhật không thành công!");
                    //Enable các btn:
                    UserControl_ListButton_PhieuChi.Instance.btn_Edit.Enabled = true;
                    UserControl_ListButton_PhieuChi.Instance.btn_Xoa.Enabled = true;
                    UserControl_ListButton_PhieuChi.Instance.btn_themMoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi lưu thông tin: " + ex.Message);
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
                tempMaPC = textEdit_maPhieuChi.Text;
                //KIỂM TRA NGÀY LẬP:

                tempNgayLap = dateEdit_ngayLap.Text;
                //KIỂM TRA MÃ NV: (Mã NV không thể sửa)
                tempMaNV = textEdit_maNV.Text;

                //KIỂM TRA MÃ NCC:
                tempMaNCC = comboBox_maNCC.SelectedItem.ToString();
                if (tempMaNCC.Length == 0)
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
                //if (tempSoTienChi < 0 || tempSoTienChi > 20000000)
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
