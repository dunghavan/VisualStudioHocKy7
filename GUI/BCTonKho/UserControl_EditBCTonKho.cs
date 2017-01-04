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
    public partial class UserControl_EditBCTonKho : UserControl
    {
        private static UserControl_EditBCTonKho _instance;
        public static UserControl_EditBCTonKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditBCTonKho();
                return _instance;
            }
        }
        //Tạo các biến lưu giá trị trên màn hình:
        string tempNgayLap, tempMaSP, tempSLTonKyDau, tempSLNhap, tempSLXuat, tempSLTonCuoiKy, tempGhiChu;
        int slPhatSinh = 0;

        private void textEdit_slPhatSinh_EditValueChanged(object sender, EventArgs e)
        {
            tinhSLTonCuoiKy();
        }
        private void tinhSLTonCuoiKy()
        {
            try
            {
                if (checkUpdateInformation())
                {
                    int slTonCuoiKy = Convert.ToInt32(tempSLTonKyDau) + Convert.ToInt32(tempSLNhap) - Convert.ToInt32(tempSLXuat) + slPhatSinh;
                    tempSLTonCuoiKy = slTonCuoiKy.ToString();
                    textEdit_slTonCuoiKy.Text = slTonCuoiKy.ToString();
                }
                else
                    textEdit_slTonCuoiKy.Text = "0";
            }
            catch(Exception e)
            {
                XtraMessageBox.Show("Lỗi khi tính SL Tồn Cuối Kỳ!");
            }
        }

        public UserControl_EditBCTonKho()
        {
            InitializeComponent();
        }
        public void loadDataFromGridview()
        {
            try
            {
                //Gán row đã chọn trong mảng []selectedRows vào dr:
                DataRow dr = UserControl_ListBCTonKho.selectedRow;
                dateEdit_ngayLap.Text = dr["Ngày Lập"].ToString();
                comboBox_maSP.Text = dr["Mã Sản Phẩm"].ToString();
                textEdit_slTonKyDau.Text = dr["SL Tồn Kỳ Đầu"].ToString();
                textEdit_slNhap.Text = dr["Số Lượng Nhập"].ToString();
                textEdit_slXuat.Text = dr["Số Lượng Xuất"].ToString();
                textEdit_slPhatSinh.Text = dr["SL Phát Sinh"].ToString();
                textEdit_slTonCuoiKy.Text = dr["SL Tồn Cuối Kỳ"].ToString();
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
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCTonKho.Instance);
            UserControl_ListBCTonKho.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_BCTonKho.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_BCTonKho.Instance.btn_Xoa.Enabled = true;
            UserControl_ListButton_BCTonKho.Instance.btn_themMoi.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkUpdateInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                BCTonKho tempBaoCao = new BCTonKho(Convert.ToDateTime(tempNgayLap), tempMaSP, Convert.ToInt32(tempSLTonKyDau), Convert.ToInt32(tempSLNhap), Convert.ToInt32(tempSLXuat), slPhatSinh, Convert.ToInt32(tempSLTonCuoiKy), tempGhiChu);
                bool updated = false;
                updated = UserControl_ListBCTonKho.objBCBus.updateBaoCao(tempBaoCao);
                if (updated)
                {
                    //XtraMessageBox.Show("Cập nhật thành công!");
                    UserControl_ListBCTonKho.Instance.loadDanhSachBaoCao();
                    UserControl_ListBCTonKho.Instance.BringToFront();
                    UserControl_ListBCTonKho.Instance.label_notification.Text = "Cập nhật thành công!";

                    //Enable/Disable các btn:
                    UserControl_ListButton_BCTonKho.Instance.btn_themMoi.Enabled = true;
                    UserControl_ListButton_BCTonKho.Instance.btn_Edit.Enabled = false;
                    UserControl_ListButton_BCTonKho.Instance.btn_Xoa.Enabled = false;
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

                //KIỂM TRA MÃ SP: (disable)
                tempMaSP = comboBox_maSP.Text;

                //KIỂM TRA TIỀN NỢ KỲ ĐẦU: (auto)
                tempSLTonKyDau = textEdit_slTonKyDau.Text;

                //GÁN CÁC GIÁ TRỊ:
                tempSLNhap = textEdit_slNhap.Text;
                tempSLXuat = textEdit_slXuat.Text;

                //KIỂM TRA TIỀN PHÁT SINH:
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
            try
            {
                if (textEdit_slPhatSinh.Text.Length > 0)
                    slPhatSinh = Convert.ToInt32(textEdit_slPhatSinh.Text);
                else
                    slPhatSinh = 0;
            }
            catch(Exception e)
            {
                XtraMessageBox.Show("Số lượng phát sinh không hợp lệ!");
                return false;
            }
            return true;
        }
    }
}
