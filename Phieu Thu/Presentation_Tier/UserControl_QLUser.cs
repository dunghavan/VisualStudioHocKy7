using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DevExpress.XtraEditors;

namespace Presentation_Tier
{
    public partial class UserControl_QLUser : UserControl
    {
        private static UserControl_QLUser _instance;
        public static UserControl_QLUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_QLUser();
                return _instance;
            }
        }
        public UserControl_QLUser()
        {
            InitializeComponent();

        }
        private string _findMaNV, _findHoTen, _findMaLoaiNV;
        int _findNamSinh;
        private void gridControl_DSNhanVien_Load(object sender, EventArgs e)
        {
            loadDanhSachNV();
            // Thêm các item cho combobox:
            for (int i = 1900; i < 2017; i++)
                comboBox_findNamSinh.Properties.Items.Add(i.ToString());
            comboBox_findNamSinh.Properties.Items.Add("--Tất cả--");
            comboBox_findNamSinh.SelectedItem = "--Tất cả--";

            comboBox_findMaLoaiNV.Properties.Items.Add("BH");
            comboBox_findMaLoaiNV.Properties.Items.Add("NH");
            comboBox_findMaLoaiNV.Properties.Items.Add("QLK");
            comboBox_findMaLoaiNV.Properties.Items.Add("--Tất cả--");
            comboBox_findMaLoaiNV.SelectedItem = "--Tất cả--";

            textEdit_findHoTen.Focus();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

            try
            {
                _findMaNV = textEdit_findMaNV.Text;
                _findHoTen = textEdit_findHoTen.Text;
                _findMaLoaiNV = (comboBox_findMaLoaiNV.Text == "--Tất cả--") ? null : comboBox_findMaLoaiNV.Text;
                _findNamSinh = (comboBox_findNamSinh.Text == "--Tất cả--") ? 0 : Convert.ToInt32(comboBox_findNamSinh.Text);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi các dữ liệu tìm kiếm: \n" + ex.Message);
            }
            DataTable searchResult = new DataTable();
            searchResult = MainForm.objNVBus.searchNhanVien(_findMaNV, _findHoTen, _findNamSinh, _findMaLoaiNV); ;
            DataTable _tempTableNV = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Mã NV", "Họ Tên", "Năm Sinh", "Giới Tính", "Số ĐT", "Email", "Mã Loại NV", "Username", "Password" };
            foreach (string s in columnName)
                _tempTableNV.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in searchResult.Rows)
            {
                //Gán bảng kết quả sang bảng tạm:
                _tempTableNV.Rows.Add(++stt,
                                        dr["MaNV"],
                                        dr["HoTen"],
                                        dr["NamSinh"],
                                        dr["GioiTinh"].ToString() == "True" ? "Nam" : "Nữ",
                                        dr["SoDT"],
                                        dr["Email"],
                                        dr["MaLoaiNV"],
                                        dr["Username"],
                                        dr["Password"]);
            }

            gridControl_DSNhanVien.DataSource = _tempTableNV; //Đổ dữ liệu vào gridview
            UserControl_ListButton.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton.Instance.btn_Xoa.Enabled = false;
        }

        public void loadDanhSachNV()
        {
            MainForm.loadTableNhanVien();
            DataTable _tempTableNV = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Mã NV", "Họ Tên", "Năm Sinh", "Giới Tính", "Số ĐT", "Email", "Mã Loại NV", "Username", "Password" };
            foreach (string s in columnName)
                _tempTableNV.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in MainForm.tableNhanVien.Rows)
            {
                //Gán bảng kết quả sang bảng tạm:
                _tempTableNV.Rows.Add(++stt,
                                        dr["MaNV"],
                                        dr["HoTen"],
                                        dr["NamSinh"],
                                        dr["GioiTinh"].ToString() == "True" ? "Nam" : "Nữ",
                                        dr["SoDT"],
                                        dr["Email"],
                                        dr["MaLoaiNV"],
                                        dr["Username"],
                                        dr["Password"]);
            }

            gridControl_DSNhanVien.DataSource = _tempTableNV; //Đổ dữ liệu vào gridview
            UserControl_ListButton.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            comboBox_findNamSinh.SelectedItem = "--Tất cả--";
            comboBox_findMaLoaiNV.SelectedItem = "--Tất cả--";
            textEdit_findMaNV.Text = null;
            textEdit_findHoTen.Text = null;
            loadDanhSachNV();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if(!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddUser.Instance);
            UserControl_AddUser.Instance.BringToFront();

            //((MainForm)parentForm).buttonPanel.

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maNVDelete = null;
            bool deleted = false;
            try
            {
                DataRow dr = gridView_DSNhanVien.GetDataRow(selectedRowsArray[0]);
                maNVDelete = dr["Mã NV"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên?", "Xác nhận!", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    deleted = MainForm.objNVBus.deleteNhanVien(maNVDelete);
                    if (deleted)
                    {
                        //XtraMessageBox.Show("Xóa thành công");
                        loadDanhSachNV();
                        Form parentForm = this.FindForm();
                        ((MainForm)parentForm).label_notification.Text = "Đã xóa nhân viên!";
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công");
                }
                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi tại sự kiện button Xóa: \n" + ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if(!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditUser.Instance);
            UserControl_EditUser.Instance.BringToFront();

            UserControl_EditUser.Instance.loadDataFromGridview();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_MainMenu.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_MainMenu.Instance);
            UserControl_MainMenu.Instance.BringToFront();
        }

        // Mảng số nguyên chứa số thứ tự của các rows đã được chọn:
        public static int[] selectedRowsArray = null;
        public static DataRow selectedRow = null;
        private void gridView_DSNhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            selectedRowsArray = gridView_DSNhanVien.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            selectedRow = gridView_DSNhanVien.GetDataRow(selectedRowsArray[0]);

            UserControl_ListButton.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton.Instance.btn_Xoa.Enabled = true;
        }
    }
}
