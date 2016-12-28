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

namespace Presentation_Tier
{
    public partial class UserControl_EditBCCongNoKH : UserControl
    {
        private static UserControl_EditBCCongNoKH _instance;
        public static UserControl_EditBCCongNoKH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditBCCongNoKH();
                return _instance;
            }
        }
        //Tạo các biến lưu giá trị trên màn hình:
        string tempNgayLap, tempMaKH, tempMaNV, tempNoKyDau, tempPhatSinh, tempNoKyCuoi, tempGhiChu;

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        public UserControl_EditBCCongNoKH()
        {
            InitializeComponent();
        }
        public void loadDataFromGridview()
        {
            try
            {
                //Gán row đã chọn trong mảng []selectedRows vào dr:
                DataRow dr = UserControl_ListBCCongNoKH.selectedRow;
                dateEdit_ngayLap.Text = dr["Ngày Lập"].ToString();
                comboBox_maKH.Text = dr["Mã Khách Hàng"].ToString();
                textEdit_maNV.Text = dr["Mã Nhân Viên"].ToString();
                textEdit_noKyDau.Text = dr["Nợ Kỳ Đầu"].ToString();
                textEdit_phatSinh.Text = dr["Phát Sinh"].ToString();
                textEdit_noKyCuoi.Text = dr["Nợ Kỳ Cuối"].ToString();
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
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCCongNoKH.Instance);
            UserControl_ListBCCongNoKH.Instance.BringToFront();

            //Enable các btn:
            //UserControl_ListButton_BCCongNoKH.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_BCCongNoKH.Instance.btn_Xoa.Enabled = true;
            UserControl_ListButton_BCCongNoKH.Instance.btn_themMoi.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkUpdateInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                BCCongNoKH tempBaoCao = new BCCongNoKH(Convert.ToDateTime(tempNgayLap), tempMaKH, tempMaNV
                                                       , Convert.ToInt32(tempNoKyDau), Convert.ToInt32(tempPhatSinh), Convert.ToInt32(tempNoKyCuoi), tempGhiChu);
                bool updated = false;
                updated = UserControl_ListBCCongNoKH.objBCBus.updateBaoCao(tempBaoCao);
                if (updated)
                {
                    //XtraMessageBox.Show("Cập nhật thành công!");
                    UserControl_ListBCCongNoKH.Instance.loadDanhSachBaoCao();
                    UserControl_ListBCCongNoKH.Instance.BringToFront();
                    UserControl_ListBCCongNoKH.Instance.label_notification.Text = "Cập nhật thành công!";

                    //Enable/Disable các btn:
                    UserControl_ListButton_BCCongNoKH.Instance.btn_themMoi.Enabled = true;
                    //UserControl_ListButton_BCCongNoKH.Instance.btn_Edit.Enabled = false;
                    UserControl_ListButton_BCCongNoKH.Instance.btn_Xoa.Enabled = false;
                }
                else
                    XtraMessageBox.Show("Cập nhật không thành công!");
            }
            else
            {

            }


        }
        private bool checkUpdateInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                //KIỂM TRA NGÀY LẬP: (disable)
                tempNgayLap = dateEdit_ngayLap.Text;

                //KIỂM TRA MÃ KHÁCH HÀNG: (disable)
                tempMaKH = comboBox_maKH.Text;

                //KIỂM TRA MÃ NHÂN VIÊN: (disable)
                tempMaNV = textEdit_maNV.Text;

                //KIỂM TRA TIỀN NỢ KỲ ĐẦU: (auto)
                tempNoKyDau = textEdit_noKyDau.Text;

                //KIỂM TRA TIỀN PHÁT SINH: (tự tính bằng tổng tiền trong các phiếu thu)
                tempPhatSinh = textEdit_phatSinh.Text;

                //KIỂM TRA TIỀN NỢ KỲ CUỐI: (auto)
                tempNoKyCuoi = textEdit_noKyCuoi.Text;

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
    }
}
