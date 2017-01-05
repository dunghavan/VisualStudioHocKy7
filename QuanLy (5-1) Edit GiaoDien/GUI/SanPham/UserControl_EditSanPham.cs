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
using DTO;

namespace GUI
{
    public partial class UserControl_EditSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserControl_EditSanPham _instance;
        public static UserControl_EditSanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_EditSanPham();
                return _instance;
            }
        }
        public UserControl_EditSanPham()
        {
            InitializeComponent();
        }

        //Tạo các biến lưu giá trị trên màn hình:
        string tempMaSP, tempTenSP, tempMaLoai, tempDonVi, tempDonGia, tempGhiChu;
        int tempSoLuong;
        bool tempIsActive = false;


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkUpdateInformation())
            {
                tempMaSP = textEdit_maSP.Text;
                tempTenSP = textEdit_tenSP.Text;
                tempDonVi = textEdit_donVi.Text;
                tempDonGia = textEdit_donGia.Text;
                tempGhiChu = textEdit_ghiChu.Text;
                tempMaLoai = textEdit_maLoaiSP.Text;
                tempSoLuong = Convert.ToInt32(textEdit_soLuong.Text);
                tempIsActive = (radio_kichHoat.Checked == true) ? true : false;

                //XtraMessageBox.Show("Các thông tin đã hợp lệ");
                DTO.SanPham tempSanPham = new DTO.SanPham(tempMaSP, tempTenSP, tempDonVi, Convert.ToInt32(tempDonGia), tempGhiChu, tempMaLoai,tempSoLuong, tempIsActive);
                bool updated = false;
                updated = UserControl_ListSanPham.objSPBus.updateSanPham(tempSanPham);
                if (updated)
                {
                    //XtraMessageBox.Show("Cập nhật thành công!");
                    UserControl_ListSanPham.Instance.loadDanhSachSP();
                    UserControl_ListSanPham.Instance.BringToFront();
                    UserControl_ListSanPham.Instance.label_notification.Text = "Cập nhật thành công!";
                    //Enable/disable các btn:
                    UserControl_ListButton_SanPham.Instance.btn_themMoi.Enabled = true;
                    UserControl_ListButton_SanPham.Instance.btn_Edit.Enabled = false;
                    UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = false;
                }
                else
                    XtraMessageBox.Show("Cập nhật không thành công !");
            }
            else
            {

            }
        }

        public void loadDataFromGridview()
        {
            try
            {
            
            
                //Gán row đã chọn trong mảng []selectedRows vào dr:
                DataRow dr = UserControl_ListSanPham.Instance.gridView_DSSanPham.GetDataRow(UserControl_ListSanPham.selectedRowsArray[0]);
                textEdit_maSP.Text = dr["Mã SP"].ToString();
                textEdit_tenSP.Text = dr["Tên SP"].ToString();
                textEdit_maLoaiSP.Text = dr["Mã Loại SP"].ToString();
                textEdit_donGia.Text = dr["Đơn Giá"].ToString();
                textEdit_donVi.Text = dr["Đơn Vị"].ToString();
                textEdit_ghiChu.Text = dr["Ghi Chú"].ToString();
                textEdit_soLuong.Text = dr["Số Lượng"].ToString();
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
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListSanPham.Instance);
            UserControl_ListSanPham.Instance.BringToFront();

            //Enable các btn:
            UserControl_ListButton_SanPham.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = true;
            UserControl_ListButton_SanPham.Instance.btn_themMoi.Enabled = true;
        }

        private bool checkUpdateInformation() //Kiểm tra các thông tin mới trên form:
        {
            try
            {
                tempMaSP = textEdit_maSP.Text;
                tempTenSP = textEdit_tenSP.Text;
                tempDonVi = textEdit_donVi.Text;
                tempDonGia = textEdit_donGia.Text;
                tempGhiChu = textEdit_ghiChu.Text;
                tempMaLoai = textEdit_maLoaiSP.Text;
                if(textEdit_soLuong.Text.Length == 0)
                {
                    XtraMessageBox.Show("Hãy nhập số lượng!");
                    return false;
                }
                tempSoLuong = Convert.ToInt32(textEdit_soLuong.Text);
                tempIsActive = (radio_kichHoat.Checked == true) ? true : false;

                //Tạo 1 regex chứa các ký tự cho phép:
                Regex regex = new Regex(@"^[a-zA-Z\sáàảãạăắằẳẵặâấầẩẫậúùủũụưứừửữựéèẻẽẹêếềểễệíìỉĩịýỳỷỹỵóòỏõọôốồổỗộơớờởỡợđĐ]$");
                Regex regexSoLuong = new Regex(@"^[+]?[0-9]*\.?[0-9]+$");
                //KIỂM TRA TÊN SẢN PHẨM:
                for (int i = 0; i < tempTenSP.Length; i++)
                {
                    if (!regex.IsMatch(tempTenSP[i].ToString()))
                    {
                        XtraMessageBox.Show("Tên sản phẩm không hợp lệ!");
                        return false;
                    }
                }

                //KIỂM TRA ĐƠN VỊ:
                for (int i = 0; i < tempDonVi.Length; i++)
                {
                    if (!regex.IsMatch(tempDonVi[i].ToString()))
                    {
                        XtraMessageBox.Show("Đơn vị không hợp lệ!");
                        return false;
                    }
                }
                //KIỂM TRA SỐ LƯỢNG:


                if (!regexSoLuong.IsMatch(textEdit_soLuong.Text))
                {
                    XtraMessageBox.Show("Số lượng sản phẩm không hợp lệ!");
                    return false;
                }


                //KIỂM TRA ĐƠN GIÁ:
                if (!regexSoLuong.IsMatch(textEdit_donGia.Text))
                {
                    XtraMessageBox.Show("Số lượng sản phẩm không hợp lệ!");
                    return false;
                }

                //KIỂM TRA MÃ LOẠI:
                for (int i = 0; i < tempMaLoai.Length; i++)
                {
                    if (!regex.IsMatch(tempMaLoai[i].ToString()))
                    {
                        XtraMessageBox.Show("Mã loại sản phẩm không hợp lệ!");
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
    }
}
