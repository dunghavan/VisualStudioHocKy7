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
    public partial class UserControl_ListSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserControl_ListSanPham _instance;
        public static UserControl_ListSanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListSanPham();
                return _instance;
            }
        }
        public UserControl_ListSanPham()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();
        }

        //private string _findMaSP, _findTenSP, _findMaLoaiSP;
        public static SanPhamBUS objSPBus = new SanPhamBUS();
        public static DataTable tableSanPham = new DataTable();

        private void gridControl_DSSanPham_Load(object sender, EventArgs e)
        {
            loadDanhSachSP();
            //textEdit_findtenSP.Focus();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _findMaSP = textEdit_findmaSP.Text;
            //    _findTenSP = textEdit_findtenSP.Text;
            //    _findMaLoaiSP = textEdit_findmaLoaiSP.Text;
               
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi các dữ liệu tìm kiếm: \n" + ex.Message);
            //}
            //DataTable searchResult = new DataTable();
            //searchResult = objSPBus.searchSanPham(_findMaSP, _findTenSP, _findMaLoaiSP);
            //DataTable _tempTableSP = new DataTable(); //Tạo bảng tạm
            //int stt = 0;
            ////Khai báo tên các cột:
            //string[] columnName = { "STT", "Mã SP", "Tên SP", "Đơn Vị", "Đơn Giá", "Ghi Chú", "Mã Loại SP","Số Lượng", "Trạng Thái" };
            //foreach (string s in columnName)
            //    _tempTableSP.Columns.Add(s); //Thêm các cột vào bảng tạm
            //foreach (DataRow dr in searchResult.Rows)
            //{
            //    //Gán bảng kết quả sang bảng tạm:
            //    _tempTableSP.Rows.Add(++stt,
            //                            dr["MaSP"],
            //                            dr["TenSP"],
            //                            dr["DonVi"],
            //                            dr["DonGia"],
            //                            dr["GhiChu"],
            //                            dr["MaLoaiSP"],
            //                            dr["SoLuong"],
            //                            dr["isActive"]);
            //}

            //gridControl_DSSanPham.DataSource = _tempTableSP; //Đổ dữ liệu vào gridview
            //UserControl_ListButton_SanPham.Instance.btn_Edit.Enabled = false;
            //UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = false;
        }


        public void loadDanhSachSP()
        {
            tableSanPham = objSPBus.getAllSanPham();
            DataTable _tempTableSP = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Mã SP", "Tên SP", "Đơn Vị", "Đơn Giá", "Ghi Chú", "Mã Loại SP","Số Lượng", "Trạng Thái" };
            foreach (string s in columnName)
                _tempTableSP.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in tableSanPham.Rows)
            {
                //Gán bảng kết quả sang bảng tạm:
                _tempTableSP.Rows.Add(++stt,
                                         dr["MaSP"],
                                        dr["TenSP"],
                                        dr["DonVi"],
                                        dr["DonGia"],
                                        dr["GhiChu"],
                                        dr["MaLoaiSP"],
                                        dr["SoLuong"],
                                        dr["isActive"].ToString() == "True" ? "Đang kích hoạt" : "Ngừng kích hoạt");
            }

            gridControl_DSSanPham.DataSource = _tempTableSP; //Đổ dữ liệu vào gridview
            UserControl_ListButton_SanPham.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = false;
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
           
            //textEdit_findmaSP.Text = null;
            //textEdit_findtenSP.Text = null;
            //textEdit_findmaLoaiSP.Text = null;
            //loadDanhSachSP();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddSanPham.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddSanPham.Instance);
            UserControl_AddSanPham.Instance.BringToFront();

            //((MainForm)parentForm).buttonPanel.

        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maSPDelete = null;
            bool deleted = false;
            try
            {
                DataRow dr = gridView_DSSanPham.GetDataRow(selectedRowsArray[0]);
                maSPDelete = dr["Mã SP"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa sản phẩm?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = objSPBus.deleteSanPham(maSPDelete);
                    if (deleted)
                    {
                        //XtraMessageBox.Show("Xóa thành công");
                        loadDanhSachSP();
                        Form parentForm = this.FindForm();
                        UserControl_ListSanPham.Instance.label_notification.Text = "Đã xóa sản phẩm!";
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
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditSanPham.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditSanPham.Instance);
            UserControl_EditSanPham.Instance.BringToFront();

            UserControl_EditSanPham.Instance.loadDataFromGridview();
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

        private void gridView_DSSanPham_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            selectedRowsArray = gridView_DSSanPham.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            selectedRow = gridView_DSSanPham.GetDataRow(selectedRowsArray[0]);
            if(selectedRow["Trạng Thái"].ToString() == "Đang kích hoạt")
                UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = true;
            else
                UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = false;
            UserControl_ListButton_SanPham.Instance.btn_Edit.Enabled = true;
        }
    }
}
