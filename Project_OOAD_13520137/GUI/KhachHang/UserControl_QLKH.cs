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

namespace GUI
{
    public partial class UserControl_QLKH : UserControl
    {
        private static UserControl_QLKH _instance;
        public static UserControl_QLKH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_QLKH();
                return _instance;
            }
        }
        public UserControl_QLKH()
        {
            InitializeComponent();
        }
        private string _findMaKH, _findHoTen, _findDiaChi, _findSDT;
        public static KhachHangBUS khBUS = new KhachHangBUS();
        public static DataTable tableKhachHang = new DataTable();
        private void gridControl_DSKH_Load(object sender, EventArgs e)
        {
            loadDanhSachKH();
            
        } 

        public void loadDanhSachKH()
        {
            tableKhachHang = khBUS.Load_DSKhachHang();
            DataTable _tempTableKH = new DataTable(); // tạo bảng tạm
            int stt = 0;
            // khai báo tên các cột:
            string[] columnName = { "STT", "Mã KH", "Họ Tên", "Địa Chỉ", "Số Điện thoại", "Ghi chú" };
            foreach (string s in columnName)
                _tempTableKH.Columns.Add(s);// thêm các cột vào bảng tạm
            foreach (DataRow dr in tableKhachHang.Rows)
            {
                _tempTableKH.Rows.Add(++stt,
                                        dr["MaKH"],
                                        dr["HoTen"],
                                        dr["DiaChi"],
                                        dr["SoDT"],
                                        dr["GhiChu"],
                                        dr["IsActive"].ToString() == "True" ? "Đang kích hoạt" : "Ngừng kích hoạt");
            }

            gridControl_DSKH.DataSource = _tempTableKH;// đổ dữ liệu vào gridview
            UserControl_ListButton_KH.Instance.btn_Sua.Enabled = false;
            UserControl_ListButton_KH.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textEdit_findMaKH.Text = null;
            textEdit_findHoTen.Text = null;
            textEdit_DiaChi.Text = null;
            textEdit_SDT.Text = null;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                _findMaKH = textEdit_findMaKH.Text;
                _findHoTen = textEdit_findHoTen.Text;
                _findDiaChi = textEdit_DiaChi.Text;
                _findSDT = textEdit_SDT.Text;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi các dữ liệu tìm kiếm: \n" + ex.Message);
            }
            DataTable searchResult = new DataTable();
            searchResult = khBUS.Search_KhachHang(_findMaKH, _findHoTen, _findDiaChi, _findSDT);
            DataTable _tempTableKH = new DataTable(); // tạo bảng tạm
            int stt = 0;
            // khai báo các tên cột
            string[] columnName = { "STT", "Mã KH", "Họ Tên", "Địa Chỉ", "Số Điện thoại", "Ghi chú" };
            foreach (string s in columnName)
                _tempTableKH.Columns.Add(s);// thêm các cột vào bảng tạm
            foreach (DataRow dr in tableKhachHang.Rows)
            {
                _tempTableKH.Rows.Add(++stt,
                                        dr["MaKH"],
                                        dr["HoTen"],
                                        dr["DiaChi"],
                                        dr["SoDT"],
                                         dr["GhiChu"],
                                        dr["IsActive"].ToString() == "True" ? "Đang kích hoạt" : "Ngừng kích hoạt");
            }
                 gridControl_DSKH.DataSource = _tempTableKH;// đổ dữ liệu vào gridview
            UserControl_ListButton_KH.Instance.btn_Sua.Enabled = false;
            UserControl_ListButton_KH.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddKhachHang.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddKhachHang.Instance);
            UserControl_AddKhachHang.Instance.BringToFront();

            //((MainForm)parentForm).buttonPanel.

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditKhachHang.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditKhachHang.Instance);
            UserControl_EditKhachHang.Instance.BringToFront();

            UserControl_EditKhachHang.Instance.loadDataFromGridView();
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


        private void gridView_DSKhachHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            selectedRowsArray = gridView_DSKhachHang.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            selectedRow = gridView_DSKhachHang.GetDataRow(selectedRowsArray[0]);

            UserControl_ListButton_KH.Instance.btn_Sua.Enabled = true;
            UserControl_ListButton_KH.Instance.btn_Xoa.Enabled = true;
        }

        

        
    }
}
