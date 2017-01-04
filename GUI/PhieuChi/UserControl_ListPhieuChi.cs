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
    public partial class UserControl_ListPhieuChi : UserControl
    {
        private static UserControl_ListPhieuChi _instance;
        public static UserControl_ListPhieuChi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListPhieuChi();
                return _instance;
            }
        }
        public UserControl_ListPhieuChi()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();

        }

        public static PhieuChiBUS objPhieuChiBUS = new PhieuChiBUS();
        public static DataTable tablePhieuChi = new DataTable();
        private void gridControl_DSPhieuChi_Load(object sender, EventArgs e)
        {
            loadDanhSachPhieuChi();
            label_notification.Text = null;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    string stringDateTime = comboBox_ngayLap.SelectedItem.ToString();
            //    _findMaPC = textEdit_findMaPhieuChi.Text;
            //    _findNgayLap = (stringDateTime == "--Tất cả--") ? "" : stringDateTime;

                
            //    DataTable searchResult = objPhieuChiBUS.searchPhieuChi(_findMaPC, _findNgayLap);
            //    int stt = 0;
            //    DataTable _tempTablePhieuChi = new DataTable();
            //    //Khai báo tên các cột:
            //    string[] columnName = { "STT", "Mã Phiếu Chi", "Ngày Lập", "Mã NV Lập", "Mã Nhà Cung Cấp", "Số Tiền Nợ", "Số Tiền Chi" };
            //    foreach (string s in columnName)
            //        _tempTablePhieuChi.Columns.Add(s); //Thêm các cột vào bảng tạm
            //    foreach (DataRow dr in searchResult.Rows)
            //    {
            //        //Gán bảng kết quả sang bảng tạm:
            //        _tempTablePhieuChi.Rows.Add(++stt,
            //                                dr["MaPC"],
            //                                Convert.ToDateTime(dr["NgayLap"]).ToString("yyyy-MM-dd"),
            //                                dr["MaNV"],
            //                                dr["MaNCC"],
            //                                dr["SoTienNo"].ToString(),
            //                                dr["SoTienChi"].ToString());
            //    }

            //    gridControl_DSPhieuChi.DataSource = _tempTablePhieuChi; //Đổ dữ liệu vào gridview
            //}
            //catch(Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi các dữ liệu tìm kiếm: \n" + ex.Message);
            //}

            //UserControl_ListButton_PhieuChi.Instance.btn_Edit.Enabled = false;
            //UserControl_ListButton_PhieuChi.Instance.btn_Xoa.Enabled = false;
        }

        public void loadDanhSachPhieuChi()
        {
            tablePhieuChi = objPhieuChiBUS.getAllPhieuChi();
            DataTable _tempTablePhieuChi = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Mã Phiếu Chi", "Ngày Lập", "Mã NV Lập", "Mã Nhà Cung Cấp", "Số Tiền Nợ", "Số Tiền Chi"};
            foreach (string s in columnName)
                _tempTablePhieuChi.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in tablePhieuChi.Rows)
            {
                //Gán bảng kết quả sang bảng tạm:
                _tempTablePhieuChi.Rows.Add(++stt,
                                        dr["MaPC"],
                                        Convert.ToDateTime(dr["NgayLap"]).ToString("yyyy-MM-dd"),
                                        dr["MaNV"],
                                        dr["MaNCC"],
                                        dr["SoTienNo"].ToString(),
                                        dr["SoTienChi"].ToString());
            }

            gridControl_DSPhieuChi.DataSource = _tempTablePhieuChi; //Đổ dữ liệu vào gridview
            UserControl_ListButton_PhieuChi.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_PhieuChi.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //textEdit_findMaPhieuChi.Text = null;
            //comboBox_ngayLap.SelectedItem = "--Tất cả--";
            //loadDanhSachPhieuChi();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if(!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditPhieuChi.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditPhieuChi.Instance);
            UserControl_EditPhieuChi.Instance.BringToFront();

            UserControl_EditPhieuChi.Instance.loadDataFromGridview();
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

        private void gridView_DSPhieuChi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            selectedRowsArray = gridView_DSPhieuChi.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            selectedRow = gridView_DSPhieuChi.GetDataRow(selectedRowsArray[0]);

            UserControl_ListButton_PhieuChi.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_PhieuChi.Instance.btn_Xoa.Enabled = true;
            label_notification.Text = null;
        }

    }
}
