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
    public partial class UC_ListPGH : UserControl
    {
        public UC_ListPGH()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();
        }
        private static UC_ListPGH _instance;
        public static UC_ListPGH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ListPGH();
                return _instance;
            }
        }
        public static PhieuGiaoHangBUS pghBUS = new PhieuGiaoHangBUS();
        
        public string maPGH_edit;
        public string maDDH_edit;
        public void loadDSPhieuGiaoHang()
        {
            gc_PGH.DataSource = pghBUS.Load_DSPhieuGiaoHang();
            UC_ListButton_PGH.Instance.btn_Sua.Enabled = false;
            UC_ListButton_PGH.Instance.btn_Xoa.Enabled = false;
        }
        private void gc_PGH_Load(object sender, EventArgs e)
        {
            loadDSPhieuGiaoHang();
        }

        

        private void gv_DSPGH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_DSPGH.GetDataRow(e.RowHandle);
            maPGH_edit = row["MaPGH"].ToString();
            maDDH_edit = row["MaDDH"].ToString();
            UC_ListButton_PGH.Instance.btn_Sua.Enabled = true;
            UC_ListButton_PGH.Instance.btn_Xoa.Enabled = true;
            UC_ListButton_PGH.Instance.btn_them.Enabled = false;

        }

       
    }
    
}
