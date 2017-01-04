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
    public partial class UserControl_EditBCDoanhThu : UserControl
    {
        private static UserControl_EditBCDoanhThu _instance;
        public static UserControl_EditBCDoanhThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditBCDoanhThu();
                return _instance;
            }
        }
        //Tạo các biến lưu giá trị trên màn hình:
        string tempNgayLap, tempMaSP, tempTongChi, tempPhatSinh, tempTongThu, tempLoiNhuan, tempGhiChu;
        int loiNhuan = 0;

        private void textEdit_slPhatSinh_EditValueChanged(object sender, EventArgs e)
        {
            tinhLoiNhuan();
        }
        private void tinhLoiNhuan()
        {
            try
            {
                if (checkUpdateInformation())
                {
                    loiNhuan = Convert.ToInt32(tempTongThu) - Convert.ToInt32(tempTongChi) + Convert.ToInt32(tempPhatSinh);
                    tempLoiNhuan = loiNhuan.ToString();
                    textEdit_loiNhuan.Text = loiNhuan.ToString();
                }
                else
                    textEdit_loiNhuan.Text = "0";
            }
            catch(Exception e)
            {
                XtraMessageBox.Show("Lỗi khi tính lợi nhuận: " + e.Message);
            }
        }

        public UserControl_EditBCDoanhThu()
        {
            InitializeComponent();
        }

        private void textEdit_phatSinh_EditValueChanged(object sender, EventArgs e)
        {

        }

        public void loadDataFromGridview()
        {
            try
            {
                //Gán row đã chọn trong mảng []selectedRows vào dr:
                DataRow dr = UserControl_ListBCDoanhThu.selectedRow;
                dateEdit_ngayLap.Text = dr["Ngày Lập"].ToString();
                comboBox_maSP.Text = dr["Mã Sản Phẩm"].ToString();
                textEdit_tongChi.Text = dr["Tổng Chi"].ToString();
                textEdit_phatSinh.Text = dr["Chi Phí Phát Sinh"].ToString();
                textEdit_tongThu.Text = dr["Tổng Thu"].ToString();
                textEdit_loiNhuan.Text = dr["Lợi Nhuận"].ToString();
                richTextBox_ghiChu.Text = dr["Ghi Chú"].ToString();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCDoanhThu.Instance);
            UserControl_ListBCDoanhThu.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_BCDoanhThu.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_BCDoanhThu.Instance.btn_Xoa.Enabled = true;
            UserControl_ListButton_BCDoanhThu.Instance.btn_themMoi.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkUpdateInformation())
                {
                    //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                    BCDoanhThu tempBaoCao = new BCDoanhThu(Convert.ToDateTime(tempNgayLap), tempMaSP, Convert.ToInt32(tempTongChi), Convert.ToInt32(tempPhatSinh), Convert.ToInt32(tempTongThu), Convert.ToInt32(tempLoiNhuan), tempGhiChu);
                    bool updated = false;
                    updated = UserControl_ListBCDoanhThu.objBCBus.updateBaoCao(tempBaoCao);
                    if (updated)
                    {
                        //XtraMessageBox.Show("Cập nhật thành công!");
                        UserControl_ListBCDoanhThu.Instance.loadDanhSachBaoCao();
                        UserControl_ListBCDoanhThu.Instance.BringToFront();
                        UserControl_ListBCDoanhThu.Instance.label_notification.Text = "Cập nhật thành công!";

                        //Enable/Disable các btn:
                        UserControl_ListButton_BCDoanhThu.Instance.btn_themMoi.Enabled = true;
                        UserControl_ListButton_BCDoanhThu.Instance.btn_Edit.Enabled = false;
                        UserControl_ListButton_BCDoanhThu.Instance.btn_Xoa.Enabled = false;
                    }
                    else
                        XtraMessageBox.Show("Cập nhật không thành công!");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi lưu báo cáo: " + ex.Message);
            }
        }
        private bool checkUpdateInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                //KIỂM TRA NGÀY LẬP: (disable)
                tempNgayLap = dateEdit_ngayLap.Text;

                //KIỂM TRA MÃ SP: (disable)
                tempMaSP = comboBox_maSP.Text;
                
                //GÁN CÁC GIÁ TRỊ:
                tempTongChi = textEdit_tongChi.Text;
                tempTongThu = textEdit_tongThu.Text;

                //KIỂM TRA TIỀN PHÁT SINH:
                tempPhatSinh = textEdit_phatSinh.Text;
                checkSLPhatSinh();

                //GHI CHÚ:
                tempGhiChu = richTextBox_ghiChu.Text;
                return true;
            }
            catch(Exception ex)
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
            if (count > 1)
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
