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

namespace GUI
{
    public partial class UC_ListPGH : UserControl
    {
        public UC_ListPGH()
        {
            InitializeComponent();
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
        private void loadDSPhieuGiaoHang()
        {
            gc_PGH.DataSource = pghBUS.Load_DSPhieuGiaoHang();
            UC_ListButton_PGH.Instance.btn_Sua.Enabled = false;
            UC_ListButton_PGH.Instance.btn_Xoa.Enabled = false;
        }
        private void gc_PGH_Load(object sender, EventArgs e)
        {
            loadDSPhieuGiaoHang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_AddPGH2.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_AddPGH2.Instance);
            UC_AddPGH2.Instance.BringToFront();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_EditPGH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_EditPGH.Instance);
            UC_EditPGH.Instance.BringToFront();
        }

        private void gv_DSPGH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_DSPGH.GetDataRow(e.RowHandle);
            maPGH_edit = row["MaPGH"].ToString();
            maDDH_edit = row["MaDDH"].ToString();
        }
    }
    
}
