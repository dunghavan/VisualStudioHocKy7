using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace GUI
{
    public partial class UC_ListButton_DDH : UserControl
    {
        public UC_ListButton_DDH()
        {
            InitializeComponent();
        }

        private static UC_ListButton_DDH _instance;
        public static UC_ListButton_DDH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ListButton_DDH();
                return _instance;
            }
        }

        

        

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_AddDDH.Instance))
            {
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_AddDDH.Instance);
            }
            UC_AddDDH.Instance.BringToFront();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_EditDDH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_EditDDH.Instance);
            UC_EditDDH.Instance.BringToFront();
            btn_Xoa.Enabled = false;
            btn_them.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DonDatHangBUS ddhBUS = new DonDatHangBUS();
            ddhBUS.Delete_CT_DonDatHangTheoMaDDH(UC_ListDonDatHang.Instance.maDDH_edit);

            ddhBUS.Delete_DonDatHang(UC_ListDonDatHang.Instance.maDDH_edit);
            
            XtraMessageBox.Show("Đã xóa đơn đặt hàng thành công!");

        }
    }
}
