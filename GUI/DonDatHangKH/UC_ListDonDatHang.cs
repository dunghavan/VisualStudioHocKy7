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
using DevExpress.XtraGrid.Localization;

namespace GUI
{
    public partial class UC_ListDonDatHang : UserControl
    {
        public UC_ListDonDatHang()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();
            
        }
        private static UC_ListDonDatHang _instance;
        public static UC_ListDonDatHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ListDonDatHang ();
                return _instance;
            }
        }
        public static DonDatHangBUS ddhBUS = new DonDatHangBUS();
       
        public string maDDH_edit;
        public string TenNV_edit;
        public void LoadDonDatHang()
        {
           
            gridControl_DDH.DataSource = ddhBUS.Load_DSDonDatHang();
            UC_ListButton_DDH.Instance.btn_them.Enabled = true;
            UC_ListButton_DDH.Instance.btn_Sua.Enabled = true;
            UC_ListButton_DDH.Instance.btn_Xoa.Enabled = true;
        }

        // Mảng số nguyên chứa số thứ tự của các rows đã được chọn:
       


       
        private void gridControl_DDH_Load(object sender, EventArgs e)
        {
            LoadDonDatHang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_AddDDH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_AddDDH.Instance);
            UC_AddDDH.Instance.BringToFront();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_EditDDH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_EditDDH.Instance);
            UC_EditDDH.Instance.BringToFront();

            //UC_EditDDH.Instance.loadDataFromGridView();
        }
        public static int[] selectedRowsArray = null;

        public static DataRow selectedRow = null;
        private void gv_DSDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //var row = gv_CTDDH.GetDataRow(e.RowHandle);
            //txt_maSP.Text = row["MaSP"].ToString();
            //txt_TenSP.Text = row["TenSP"].ToString();
            //txt_DonGia.Text = row["DonGia"].ToString();
            //txt_SL.Value = int.Parse(row["SoLuong"].ToString());
            //txt_ThanhTien.Text = row["ThanhTien"].ToString();

            var row = gv_DSDDH.GetDataRow(e.RowHandle);
            maDDH_edit = row["MaDDH"].ToString();
            TenNV_edit = row["TenNV"].ToString();
            //Lấy chỉ số của các row đã chọn gán vào mảng []selectedRows:
            //selectedRowsArray = gv_DSDDH.GetSelectedRows();
            //gán row đã chọn vào selectedRow:
            //selectedRow = gv_DSDDH.GetDataRow(selectedRowsArray[0]);
            UC_ListButton_DDH.Instance.btn_them.Enabled = false;
            UC_ListButton_DDH.Instance.btn_Sua.Enabled = true;
            UC_ListButton_DDH.Instance.btn_Xoa.Enabled = true;

        }

        private void UC_ListDonDatHang_Load(object sender, EventArgs e)
        {
            UC_ListButton_DDH.Instance.btn_them.Enabled = true;
            UC_ListButton_DDH.Instance.btn_Sua.Enabled = true;
            UC_ListButton_DDH.Instance.btn_Xoa.Enabled = true;
        }
    }
}
