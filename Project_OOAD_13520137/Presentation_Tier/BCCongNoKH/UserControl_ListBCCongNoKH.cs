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

namespace Presentation_Tier
{
    public partial class UserControl_ListBCCongNoKH : UserControl
    {
        private static UserControl_ListBCCongNoKH _instance;
        public static UserControl_ListBCCongNoKH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListBCCongNoKH();
                return _instance;
            }
        }
        public UserControl_ListBCCongNoKH()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();

        }
        public static BCCongNoKHBUS objBCBus = new BCCongNoKHBUS();
        public static DataTable tableBCCongNoKH = new DataTable();
        private void gridControl_DSBCCongNoKH_Load(object sender, EventArgs e)
        {
            loadDanhSachBaoCao();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            
        }

        public void loadDanhSachBaoCao()
        {
            tableBCCongNoKH = objBCBus.getAllBaoCao();
            DataTable _tempTableBC = new DataTable(); //Tạo bảng tạm
            int stt = 0;
            //Khai báo tên các cột:
            string[] columnName = { "STT", "Ngày Lập", "Mã Khách Hàng", "Mã Nhân Viên", "Nợ Kỳ Đầu", "Phát Sinh", "Nợ Kỳ Cuối", "Ghi Chú" };
            foreach (string s in columnName)
                _tempTableBC.Columns.Add(s); //Thêm các cột vào bảng tạm
            foreach (DataRow dr in tableBCCongNoKH.Rows)
            {
                //Gán bảng kết quả sang bảng tạm:
                _tempTableBC.Rows.Add(++stt,
                                        Convert.ToDateTime(dr["NgayLap"]).ToString("yyyy-MM-dd"),
                                        dr["MaKH"],
                                        dr["MaNV"],
                                        dr["NoKyDau"].ToString(),
                                        dr["PhatSinh"].ToString(),
                                        dr["NoKyCuoi"].ToString(),
                                        dr["GhiChu"]);
            }

            gridControl_DSBCCongNoKH.DataSource = _tempTableBC; //Đổ dữ liệu vào gridview
            //UserControl_ListButton_BCCongNoKH.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_BCCongNoKH.Instance.btn_Xoa.Enabled = false;
            label_notification.Text = null;
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

        private void gridView_DSBCCongNoKH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            selectedRowsArray = gridView_DSBCCongNoKH.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            selectedRow = gridView_DSBCCongNoKH.GetDataRow(selectedRowsArray[0]);

            //UserControl_ListButton_BCCongNoKH.Instance.btn_Edit.Enabled = true;
            UserControl_ListButton_BCCongNoKH.Instance.btn_Xoa.Enabled = true;
            label_notification.Text = null;
        }
    }

}
