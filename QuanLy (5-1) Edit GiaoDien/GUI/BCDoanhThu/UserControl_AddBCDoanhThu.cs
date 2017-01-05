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
    public partial class UserControl_AddBCDoanhThu : UserControl
    {
        private static UserControl_AddBCDoanhThu _instance;
        public static UserControl_AddBCDoanhThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddBCDoanhThu();
                return _instance;
            }
        }
        public static SanPhamBUS objSPBus = new SanPhamBUS();
        public static DataTable tableSanPham = new DataTable();
        public UserControl_AddBCDoanhThu()
        {
            InitializeComponent();
            try
            {
                tableSanPham = objSPBus.getAllSanPham();
                //Khởi tạo item cho comboBox mã SP:
                foreach (DataRow dr in tableSanPham.Rows)
                    if (!comboBox_maSP.Properties.Items.Contains(dr["MaSP"].ToString()))
                        comboBox_maSP.Properties.Items.Add(dr["MaSP"].ToString());

                //
                dateEdit_ngayLap.Focus();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khởi tạo dữ liệu: " + ex.Message);
            }
        }
        
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCDoanhThu.Instance);
            UserControl_ListBCDoanhThu.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_BCDoanhThu.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_BCDoanhThu.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_BCDoanhThu.Instance.btn_Xoa.Enabled = false;
        }

        public void resetAllField()
        {
            dateEdit_ngayLap.Reset();
            comboBox_maSP.Text = null;
            textEdit_tongThu.Text = "0";
            textEdit_tongChi.Text = "0";
            textEdit_loiNhuan.Text = "0";
            textEdit_phatSinh.Text = "0";
            richTextBox_ghiChu.Text = null;

        }

        //Tạo các biến lưu giá trị trên màn hình:
        string tempNgayLap, tempMaSP, tempTongChi, tempPhatSinh, tempTongThu, tempLoiNhuan, tempGhiChu;

        string maSPSelected;
        DateTime ngayLapSelected;

        private void dateEdit_ngayLap_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textEdit_phatSinh_EditValueChanged(object sender, EventArgs e)
        {
            tinhLoiNhuan();
        }

        private void comboBox_maSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ngayLapSelected = Convert.ToDateTime(dateEdit_ngayLap.Text);
                maSPSelected = comboBox_maSP.Text;
                textEdit_phatSinh.Text = "0";
                tinhLoiNhuan();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi chọn mã SP: " + ex.Message);
            }
        }

        BCDoanhThuBUS objBCBUS = new BCDoanhThuBUS();
        private void tinhLoiNhuan()
        {
            try
            {
                //Tính SL nhập, xuất của tháng này:
                int tongChi = 0, tongThu = 0;
                tongChi = objBCBUS.getTongChi(maSPSelected, ngayLapSelected.Month, ngayLapSelected.Year);
                textEdit_tongChi.Text = tongChi.ToString();
                tongThu = objBCBUS.getTongThu(maSPSelected, ngayLapSelected.Month, ngayLapSelected.Year);
                textEdit_tongThu.Text = tongThu.ToString();

                //Tính SL tồn cuối tháng này:
                tempPhatSinh = textEdit_phatSinh.Text;
                if (textEdit_phatSinh.Text.Length == 0 || textEdit_phatSinh.Text == "-")
                    tempPhatSinh = "0";
                if (checkSLPhatSinh())
                {
                    textEdit_loiNhuan.Text = (tongThu - tongChi + Convert.ToInt32(tempPhatSinh)).ToString();
                }
                else
                {
                    //XtraMessageBox.Show("Không thể tính SL tồn cuối kỳ!");
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi tính lợi nhuận: " + ex.Message);
            }
            

        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkAddNewInformation())
                {
                    //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                    BCDoanhThu tempBaoCao = new BCDoanhThu(Convert.ToDateTime(tempNgayLap), tempMaSP, Convert.ToInt32(tempTongChi), Convert.ToInt32(tempPhatSinh), Convert.ToInt32(tempTongThu), Convert.ToInt32(tempLoiNhuan), tempGhiChu);
                    bool inserted = false;
                    inserted = UserControl_ListBCDoanhThu.objBCBus.addBaoCao(tempBaoCao);
                    if (inserted)
                    {

                        Form parentForm = this.FindForm();
                        UserControl_ListBCDoanhThu.Instance.loadDanhSachBaoCao();
                        if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListBCDoanhThu.Instance))
                            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCDoanhThu.Instance);
                        UserControl_ListBCDoanhThu.Instance.BringToFront();

                        UserControl_ListBCDoanhThu.Instance.label_notification.Text = "Thêm thành công!";

                        //Enable/Disable các btn:
                        UserControl_ListButton_BCDoanhThu.Instance.btn_themMoi.Enabled = true;
                        UserControl_ListButton_BCDoanhThu.Instance.btn_Edit.Enabled = false;
                        UserControl_ListButton_BCDoanhThu.Instance.btn_Xoa.Enabled = false;
                    }
                    else
                        XtraMessageBox.Show("Thêm không thành công!");
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi lưu báo cáo: " + ex.Message);
            }
        }

        private bool checkAddNewInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                //KIỂM TRA NGÀY LẬP VÀ MÃ SP:
                tempNgayLap = dateEdit_ngayLap.Text;
                tempMaSP = comboBox_maSP.Text;
                foreach(DataRow dr in UserControl_ListBCDoanhThu.tableBCDoanhThu.Rows)
                    if (Convert.ToDateTime(dr["NgayLap"].ToString()).Month == Convert.ToDateTime(tempNgayLap).Month
                        && Convert.ToDateTime(dr["NgayLap"].ToString()).Year == Convert.ToDateTime(tempNgayLap).Year
                       && dr["MaSP"].ToString() == tempMaSP)
                    {
                        XtraMessageBox.Show("Sản phẩm có mã " + tempMaSP + " đã được tạo báo cáo doanh thu!");
                        return false;
                    }

                if (comboBox_maSP.Text.Length == 0)
                {
                    XtraMessageBox.Show("Hãy chọn mã Sản Phẩm!");
                    return false;
                }
                tempMaSP = comboBox_maSP.Text;
                foreach(DataRow dr in UserControl_ListBCTonKho.tableBCTonKho.Rows)
                    if(Convert.ToDateTime(dr["NgayLap"].ToString()).Month == Convert.ToDateTime(tempNgayLap).Month
                        && Convert.ToDateTime(dr["NgayLap"].ToString()).Year == Convert.ToDateTime(tempNgayLap).Year
                       && dr["MaSP"].ToString() == tempMaSP)
                    {
                        XtraMessageBox.Show("Sản Phẩm có mã " + tempMaSP + " đã được tạo báo cáo tồn kho!");
                        return false;
                    }

                //TỔNG CHI:
                tempTongChi = textEdit_tongChi.Text;
                //TỔNG THU:
                tempTongThu = textEdit_tongThu.Text;

                //KIỂM TRA SL PHÁT SINH:
                tempPhatSinh = textEdit_phatSinh.Text;
                if (!checkSLPhatSinh())
                    return false;

                //LỢI NHUẬN:
                tempLoiNhuan= textEdit_loiNhuan.Text;

                //GHI CHÚ:
                tempGhiChu = richTextBox_ghiChu.Text;
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi check thông tin: " + ex.Message);
                return false;
            }
        }
        private bool checkSLPhatSinh()
        {
            int count = 0;
            string sub = "-";
            foreach (char c in tempPhatSinh)
                if (c.ToString() == sub)
                    count++;
            if(count > 1 || tempPhatSinh.Length == 0)
            {
                XtraMessageBox.Show("Chi phí phát sinh không hợp lệ!");
                return false;
            }
            else
            {
                Regex regexPhatSinh = new Regex(@"^[0-9-]*$");
                for (int i = 0; i < textEdit_phatSinh.Text.ToString().Length; i++)
                    if (!regexPhatSinh.IsMatch(tempPhatSinh[i].ToString()))
                    {
                        XtraMessageBox.Show("Chi phí phát sinh không hợp lệ!");
                        return false;
                    }
            }
            return true;
        }
    }
}
