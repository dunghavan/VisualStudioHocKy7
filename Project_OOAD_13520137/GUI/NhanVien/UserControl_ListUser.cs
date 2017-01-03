using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;
using DTO;
using DevExpress.XtraGrid.Localization;

namespace GUI
{
    public partial class UserControl_ListUser : UserControl
    {
        private static UserControl_ListUser _instance;
        public static UserControl_ListUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListUser();
                return _instance;
            }
        }
        public UserControl_ListUser()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();

        }

        public static NhanVienBUS objNVBus = new NhanVienBUS();
        public static DataTable tableNhanVien = new DataTable();
        private void gridControl_DSNhanVien_Load(object sender, EventArgs e)
        {
            loadDanhSachNV();
        }

        public void loadDanhSachNV()
        {
            tableNhanVien = objNVBus.getAllNhanVien();
            DataTable _tempTableNV = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Mã NV", "Họ Tên", "Năm Sinh", "Giới Tính", "Số ĐT", "Email", "Mã Loại NV", "Username", "Password", "Trạng Thái" };
            foreach (string s in columnName)
                _tempTableNV.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in tableNhanVien.Rows)
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
                                        dr["Password"],
                                        dr["IsActive"].ToString() == "True" ? "Đang kích hoạt" : "Ngừng kích hoạt");
            }

            gridControl_DSNhanVien.DataSource = _tempTableNV; //Đổ dữ liệu vào gridview
            UserControl_ListButton_User.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_User.Instance.btn_Xoa.Enabled = false;
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
            label_notification.Text = null;
            string maNVDelete = null;
            bool deleted = false;
            try
            {
                DataRow dr = gridView_DSNhanVien.GetDataRow(selectedRowsArray[0]);
                maNVDelete = dr["Mã NV"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên?", "Xác nhận!", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    deleted = objNVBus.deleteNhanVien(maNVDelete);
                    if (deleted)
                    {
                        //XtraMessageBox.Show("Xóa thành công");
                        loadDanhSachNV();
                        Form parentForm = this.FindForm();
                        UserControl_ListUser.Instance.label_notification.Text = "Đã xóa nhân viên!";
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

            UserControl_ListButton_User.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_User.Instance.btn_Xoa.Enabled = true;
            label_notification.Text = null;
        }
    }
}
