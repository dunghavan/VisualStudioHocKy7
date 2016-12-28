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
    public partial class UserControl_AddBCTonKho : UserControl
    {
        private static UserControl_AddBCTonKho _instance;
        public static UserControl_AddBCTonKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddBCTonKho();
                return _instance;
            }
        }
        public static SanPhamBUS objSPBus = new SanPhamBUS();
        public static DataTable tableSanPham = new DataTable();
        public UserControl_AddBCTonKho()
        {
            InitializeComponent();

            tableSanPham = objSPBus.getAllSanPham();
            //Khởi tạo item cho comboBox mã SP:
            foreach (DataRow dr in tableSanPham.Rows)
                if (!comboBox_maSP.Properties.Items.Contains(dr["MaSP"].ToString()))
                    comboBox_maSP.Properties.Items.Add(dr["MaSP"].ToString());

            //
            dateEdit_ngayLap.Focus();
        }
        
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCTonKho.Instance);
            UserControl_ListBCTonKho.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_BCTonKho.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_BCTonKho.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_BCTonKho.Instance.btn_Xoa.Enabled = false;
        }

        public void resetAllField()
        {
            dateEdit_ngayLap.Reset();
            comboBox_maSP.Text = null;
            textEdit_slTonKyDau.Text = "0";
            textEdit_slNhap.Text = "0";
            textEdit_slXuat.Text = "0";
            textEdit_slPhatSinh.Text = "0";
            textEdit_slTonCuoiKy.Text = "0";
            richTextBox_ghiChu.Text = null;

        }

        //Tạo các biến lưu giá trị trên màn hình:
        string tempNgayLap, tempMaSP, tempSLTonKyDau, tempSLNhap, tempSLXuat, tempSLPhatSinh, tempSLTonCuoiKy, tempGhiChu;

        string maSPSelected;
        DateTime ngayLapSelected;

        private void textEdit_slPhatSinh_EditValueChanged(object sender, EventArgs e)
        {
            tinhSLNhapXuat_TonCuoiKy();
        }
        private void dateEdit_ngayLap_EditValueChanged(object sender, EventArgs e)
        {
            tinhSLNhapXuat_TonCuoiKy();
            textEdit_slPhatSinh.Text = "0";
        }
        
        private void comboBox_maSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            maSPSelected = comboBox_maSP.Text;
            textEdit_slPhatSinh.Text = "0";
            tinhSLNhapXuat_TonCuoiKy();
        }

        BCTonKhoBUS objBCBUS = new BCTonKhoBUS();
        private void tinhSLNhapXuat_TonCuoiKy()
        {
            int slTonKyDau = 0;
            //Tính tồn của tháng trước:
            ngayLapSelected = Convert.ToDateTime(dateEdit_ngayLap.Text);
            if (ngayLapSelected.Month == 1)
            {
                slTonKyDau = objBCBUS.getSLTonKyCuoi(maSPSelected, 12, ngayLapSelected.Year - 1);
            }
            else
            {
                slTonKyDau = objBCBUS.getSLTonKyCuoi(maSPSelected, ngayLapSelected.Month - 1, ngayLapSelected.Year);
            }
            textEdit_slTonKyDau.Text = slTonKyDau.ToString();
            //Tính SL nhập, xuất của tháng này:
            int slNhap = 0, slXuat = 0;
            slNhap = objBCBUS.getSLNhap(maSPSelected, ngayLapSelected.Month, ngayLapSelected.Year);
            textEdit_slNhap.Text = slNhap.ToString();
            slXuat = objBCBUS.getSLXuat(maSPSelected, ngayLapSelected.Month, ngayLapSelected.Year);
            textEdit_slXuat.Text = slXuat.ToString();

            //Tính SL tồn cuối tháng này:
            tempSLPhatSinh = textEdit_slPhatSinh.Text;
            if (textEdit_slPhatSinh.Text.Length == 0)
                tempSLPhatSinh = "0";
            if (checkSLPhatSinh())
            {
                textEdit_slTonCuoiKy.Text = (slTonKyDau + slNhap - slXuat + Convert.ToInt32(tempSLPhatSinh)).ToString();
            }
            else
            {
                //XtraMessageBox.Show("Không thể tính SL tồn cuối kỳ!");
            }

        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(checkAddNewInformation())
            {
                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                BCTonKho tempBaoCao = new BCTonKho(Convert.ToDateTime(tempNgayLap), tempMaSP, Convert.ToInt32(tempSLTonKyDau), Convert.ToInt32(tempSLNhap), Convert.ToInt32(tempSLXuat), Convert.ToInt32(tempSLPhatSinh), Convert.ToInt32(tempSLTonCuoiKy), tempGhiChu);
                bool inserted = false;
                inserted = UserControl_ListBCTonKho.objBCBus.addBaoCao(tempBaoCao);
                if (inserted)
                {

                    Form parentForm = this.FindForm();
                    UserControl_ListBCTonKho.Instance.loadDanhSachBaoCao();
                    if(!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListBCTonKho.Instance))
                        ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCTonKho.Instance);
                    UserControl_ListBCTonKho.Instance.BringToFront();

                    UserControl_ListBCTonKho.Instance.label_notification.Text = "Thêm thành công!";

                    //Enable/Disable các btn:
                    UserControl_ListButton_BCTonKho.Instance.btn_themMoi.Enabled = true;
                    UserControl_ListButton_BCTonKho.Instance.btn_Edit.Enabled = false;
                    UserControl_ListButton_BCTonKho.Instance.btn_Xoa.Enabled = false;
                }
                else
                    XtraMessageBox.Show("Thêm không thành công!");
            }
            else
            {
                
            }
        }

        private bool checkAddNewInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                //KIỂM TRA NGÀY LẬP VÀ MÃ SP:
                tempNgayLap = dateEdit_ngayLap.Text;

                if(comboBox_maSP.Text.Length == 0)
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

                //KIỂM TRA SL TỒN KỲ ĐẦU:
                tempSLTonKyDau = textEdit_slTonKyDau.Text;
                //KIỂM TRA SL NHẬP, XUẤT: (tự tính dựa trên DS phiếu thu, chi)
                tempSLNhap = textEdit_slNhap.Text;
                tempSLXuat = textEdit_slXuat.Text;

                //KIỂM TRA SL PHÁT SINH:
                tempSLPhatSinh = textEdit_slPhatSinh.Text;
                if (!checkSLPhatSinh())
                    return false;

                //KIỂM TRA TIỀN NỢ KỲ CUỐI:
                tempSLTonCuoiKy= textEdit_slTonCuoiKy.Text;

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
            Regex regexSLPhatSinh = new Regex(@"^[0-9]$");
            for (int i = 0; i < textEdit_slPhatSinh.Text.ToString().Length; i++)
                if (!regexSLPhatSinh.IsMatch(tempSLPhatSinh[i].ToString()))
                {
                    XtraMessageBox.Show("Số lượng phát sinh không hợp lệ!");
                    return false;
                }
            return true;
        }
    }
}
