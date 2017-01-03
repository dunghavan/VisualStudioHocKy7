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
using BUS;
using DTO;
using DevExpress.XtraGrid.Localization;

namespace GUI
{
    public partial class UserControl_ListNCC : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserControl_ListNCC _instance;
        public static UserControl_ListNCC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListNCC();
                return _instance;
            }
        }
        public UserControl_ListNCC()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();
        }
        //private string _findMaNCC, _findTenNCC;
        public static NhaCungCapBUS objNCCBus = new NhaCungCapBUS();
        public static DataTable tableNCC = new DataTable();

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _findMaNCC = textEdit_findmaNCC.Text;
            //    _findTenNCC = textEdit_findtenNCC.Text;
              

            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi các dữ liệu tìm kiếm: \n" + ex.Message);
            //}
            //DataTable searchResult = new DataTable();
            //searchResult = objNCCBus.searchNCC(_findMaNCC, _findTenNCC);
            //DataTable _tempTableNCC = new DataTable(); //Tạo bảng tạm
            //int stt = 0;
            ////Khai báo tên các cột:
            //string[] columnName = { "STT", "Mã NCC", "Tên NCC", "Địa Chỉ", "Số Điện Thoại","Ghi Chú", "Trạng Thái" };
            //foreach (string s in columnName)
            //    _tempTableNCC.Columns.Add(s); //Thêm các cột vào bảng tạm
            //foreach (DataRow dr in searchResult.Rows)
            //{
            //    //Gán bảng kết quả sang bảng tạm:
            //    _tempTableNCC.Rows.Add(++stt,
            //                            dr["MaNCC"],
            //                            dr["Ten"],
            //                            dr["DiaChi"],
            //                            dr["SoDT"],                                      
            //                            dr["GhiChu"],
            //                            dr["IsActive"]);
            //}

            //gridControl_DSNCC.DataSource = _tempTableNCC; //Đổ dữ liệu vào gridview
            //UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = false;
            //UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = false;
        }

        private void gridControl_DSNCC_Load(object sender, EventArgs e)
        {
            loadDanhSachNCC();
            //textEdit_findtenNCC.Focus();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //textEdit_findmaNCC.Text = null;
            //textEdit_findtenNCC.Text = null;
        
            //loadDanhSachNCC();
        }

        public void loadDanhSachNCC()
        {
            tableNCC = objNCCBus.getAllNhaCungCap();
            DataTable _tempTableNCC = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Mã NCC", "Tên NCC", "Địa Chỉ", "Số Điện Thoại", "Ghi Chú", "Trạng Thái" };
            foreach (string s in columnName)
                _tempTableNCC.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in tableNCC.Rows)
            {
                //Gán bảng kết quả sang bảng tạm:
                _tempTableNCC.Rows.Add(++stt,
                                        dr["MaNCC"],
                                        dr["Ten"],
                                        dr["DiaChi"],
                                        dr["SoDT"],                                      
                                        dr["GhiChu"],                                       
                                        dr["IsActive"].ToString() == "True" ? "Đang kích hoạt" : "Ngừng kích hoạt");
            }

            gridControl_DSNCC.DataSource = _tempTableNCC; //Đổ dữ liệu vào gridview
            UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = false;
        }
        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddNCC.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddNCC.Instance);
            UserControl_AddNCC.Instance.BringToFront();

            //((MainForm)parentForm).buttonPanel.

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maNCCDelete = null;
            bool deleted = false;
            try
            {
                DataRow dr = gridView_DSNCC.GetDataRow(selectedRowsArray[0]);
                maNCCDelete = dr["Mã NCC"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhà cung cấp?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = objNCCBus.deleteNhaCungCap(maNCCDelete);
                    if (deleted)
                    {
                        //XtraMessageBox.Show("Xóa thành công");
                        loadDanhSachNCC();
                        Form parentForm = this.FindForm();
                        UserControl_ListNCC.Instance.label_notification.Text = "Đã xóa nhà cug cấp!";
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tại sự kiện button Xóa: \n" + ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditNCC.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditNCC.Instance);
            UserControl_EditNCC.Instance.BringToFront();

            UserControl_EditNCC.Instance.loadDataFromGridview();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_MainMenu.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_MainMenu.Instance);
            UserControl_MainMenu.Instance.BringToFront();
        }
        public static int[] selectedRowsArray = null;
        public static DataRow selectedRow = null;
        private void gridView_DSNCC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            selectedRowsArray = gridView_DSNCC.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            selectedRow = gridView_DSNCC.GetDataRow(selectedRowsArray[0]);

            UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = true;
        }

    }
}
