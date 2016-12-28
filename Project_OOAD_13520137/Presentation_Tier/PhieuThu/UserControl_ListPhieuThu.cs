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

namespace Presentation_Tier
{
    public partial class UserControl_ListPhieuThu : UserControl
    {
        private static UserControl_ListPhieuThu _instance;
        public static UserControl_ListPhieuThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListPhieuThu();
                return _instance;
            }
        }
        public UserControl_ListPhieuThu()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();

        }

        public static PhieuThuBUS objPhieuThuBUS = new PhieuThuBUS();
        public static DataTable tablePhieuThu = new DataTable();
        private void gridControl_DSPhieuThu_Load(object sender, EventArgs e)
        {
            loadDanhSachPhieuThu();
            label_notification.Text = null;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    string stringDateTime = comboBox_ngayLap.SelectedItem.ToString();
            //    _findMaPT = textEdit_findMaPhieuThu.Text;
            //    _findNgayLap = (stringDateTime == "--Tất cả--") ? "" : stringDateTime;

                
            //    DataTable searchResult = objPhieuThuBUS.searchPhieuThu(_findMaPT, _findNgayLap);
            //    int stt = 0;
            //    DataTable _tempTablePhieuThu = new DataTable();
            //    //Khai báo tên các cột:
            //    string[] columnName = { "STT", "Mã Phiếu Thu", "Ngày Lập", "Mã NV Lập", "Mã Khách Hàng", "Số Tiền Nợ", "Số Tiền Thu" };
            //    foreach (string s in columnName)
            //        _tempTablePhieuThu.Columns.Add(s); //Thêm các cột vào bảng tạm
            //    foreach (DataRow dr in searchResult.Rows)
            //    {
            //        //Gán bảng kết quả sang bảng tạm:
            //        _tempTablePhieuThu.Rows.Add(++stt,
            //                                dr["MaPT"],
            //                                Convert.ToDateTime(dr["NgayLap"]).ToString("yyyy-MM-dd"),
            //                                dr["MaNV"],
            //                                dr["MaKH"],
            //                                dr["SoTienNo"].ToString(),
            //                                dr["SoTienThu"].ToString());
            //    }

            //    gridControl_DSPhieuThu.DataSource = _tempTablePhieuThu; //Đổ dữ liệu vào gridview
            //}
            //catch(Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi các dữ liệu tìm kiếm: \n" + ex.Message);
            //}

            //UserControl_ListButton_PhieuThu.Instance.btn_Edit.Enabled = false;
            //UserControl_ListButton_PhieuThu.Instance.btn_Xoa.Enabled = false;
        }

        public void loadDanhSachPhieuThu()
        {
            tablePhieuThu = objPhieuThuBUS.getAllPhieuThu();
            DataTable _tempTablePhieuThu = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Mã Phiếu Thu", "Ngày Lập", "Mã NV Lập", "Mã Khách Hàng", "Số Tiền Nợ", "Số Tiền Thu"};
            foreach (string s in columnName)
                _tempTablePhieuThu.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in tablePhieuThu.Rows)
            {
                //Gán bảng kết quả sang bảng tạm:
                _tempTablePhieuThu.Rows.Add(++stt,
                                        dr["MaPT"],
                                        Convert.ToDateTime(dr["NgayLap"]).ToString("yyyy-MM-dd"),
                                        dr["MaNV"],
                                        dr["MaKH"],
                                        dr["SoTienNo"].ToString(),
                                        dr["SoTienThu"].ToString());
            }

            gridControl_DSPhieuThu.DataSource = _tempTablePhieuThu; //Đổ dữ liệu vào gridview
            UserControl_ListButton_PhieuThu.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_PhieuThu.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //textEdit_findMaPhieuThu.Text = null;
            //comboBox_ngayLap.SelectedItem = "--Tất cả--";
            //loadDanhSachPhieuThu();
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

        private void gridView_DSPhieuThu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            selectedRowsArray = gridView_DSPhieuThu.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            selectedRow = gridView_DSPhieuThu.GetDataRow(selectedRowsArray[0]);

            UserControl_ListButton_PhieuThu.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_PhieuThu.Instance.btn_Xoa.Enabled = true;
            label_notification.Text = null;
        }

    }
}
