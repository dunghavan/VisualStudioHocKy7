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
using DevExpress.XtraGrid.Localization;

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
            GridLocalizer.Active = new MyGridLocalizer();
        }
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
            string[] columnName = { "STT", "Mã KH", "Họ Tên", "Địa Chỉ", "Số Điện thoại", "Ghi chú", "Trạng thái" };
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
