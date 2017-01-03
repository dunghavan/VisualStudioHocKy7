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
    public partial class UserControl_ListBCDoanhThu : UserControl
    {
        private static UserControl_ListBCDoanhThu _instance;
        public static UserControl_ListBCDoanhThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListBCDoanhThu();
                return _instance;
            }
        }
        public UserControl_ListBCDoanhThu()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();
        }
        public static BCDoanhThuBUS objBCBus = new BCDoanhThuBUS();
        public static DataTable tableBCDoanhThu = new DataTable();
        private void gridControl_DSBCDoanhThu_Load(object sender, EventArgs e)
        {
            loadDanhSachBaoCao();
            label_notification.Text = null;
        }


        public void loadDanhSachBaoCao()
        {
            tableBCDoanhThu = objBCBus.getAllBaoCao();
            DataTable _tempTableBC = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Ngày Lập", "Mã Sản Phẩm", "Tổng Chi", "Chi Phí Phát Sinh", "Tổng Thu", "Lợi Nhuận", "Ghi Chú" };
            foreach (string s in columnName)
                _tempTableBC.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in tableBCDoanhThu.Rows)
            {
                //Gán bảng kết quả sang bảng tạm:
                _tempTableBC.Rows.Add(++stt,
                                        Convert.ToDateTime(dr["NgayLap"]).ToString("yyyy-MM-dd"),
                                        dr["MaSP"],
                                        dr["TongChi"].ToString(),
                                        dr["PhatSinh"].ToString(),
                                        dr["TongThu"].ToString(),
                                        dr["LoiNhuan"].ToString(),
                                        dr["GhiChu"]);
            }

            gridControl_DSBCDoanhThu.DataSource = _tempTableBC; //Đổ dữ liệu vào gridview
            UserControl_ListButton_BCDoanhThu.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_BCDoanhThu.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
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

        private void gridView_DSBCTonKho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            selectedRowsArray = gridView_DSBCDoanhThu.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            selectedRow = gridView_DSBCDoanhThu.GetDataRow(selectedRowsArray[0]);

            UserControl_ListButton_BCDoanhThu.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_BCDoanhThu.Instance.btn_Xoa.Enabled = true;
            label_notification.Text = null;
        }
    }
}
