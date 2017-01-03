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
    public partial class UC_ListHoaDon : UserControl
    {
        public UC_ListHoaDon()
        {
            InitializeComponent();
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
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_AddHoaDonLe.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_AddHoaDonLe.Instance);
            UC_AddHoaDonLe.Instance.BringToFront();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_SuaHoaDonLe.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_SuaHoaDonLe.Instance);
            UC_SuaHoaDonLe.Instance.BringToFront();
        }

    }


}
