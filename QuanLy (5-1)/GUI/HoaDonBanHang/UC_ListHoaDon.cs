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
    public partial class UC_ListHoaDon : UserControl
    {
        public UC_ListHoaDon()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();
        }
        private static UC_ListHoaDon _instance;
        public static UC_ListHoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ListHoaDon();
                return _instance;
            }
        }
        public string maHD_edit;
        HoaDonBUS hdBUS = new HoaDonBUS();
        public void LoadData()
        {
            gridControl_HD.DataSource = hdBUS.Load_DSHoaDon();
        }

        private void gridControl_HD_Load(object sender, EventArgs e)
        {
            gridControl_HD.DataSource = hdBUS.Load_DSHoaDon();
            UC_ListButton_HD.Instance.btn_them.Enabled = true;
            UC_ListButton_HD.Instance.btn_Sua.Enabled = true;
            UC_ListButton_HD.Instance.btn_Xoa.Enabled = true;
        }

        private void gv_DSHD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_DSHD.GetDataRow(e.RowHandle);
            maHD_edit = row["MaHD"].ToString();
            UC_ListButton_HD.Instance.btn_them.Enabled = true;
            UC_ListButton_HD.Instance.btn_Sua.Enabled = false;
            UC_ListButton_HD.Instance.btn_Xoa.Enabled = false;
        }

       

    }


}
