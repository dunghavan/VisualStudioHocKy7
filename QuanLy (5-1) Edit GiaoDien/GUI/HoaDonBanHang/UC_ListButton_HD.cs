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

namespace GUI
{
    public partial class UC_ListButton_HD : UserControl
    {
        public UC_ListButton_HD()
        {
            InitializeComponent();
        }
        private static UC_ListButton_HD _instance;
        public static UC_ListButton_HD Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ListButton_HD();
                return _instance;
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_AddHoaDonLe.Instance))
            {
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_AddHoaDonLe.Instance);
            }
            UC_AddHoaDonLe.Instance.BringToFront();
            //btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_SuaHoaDonLe.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_SuaHoaDonLe.Instance);
            UC_SuaHoaDonLe.Instance.BringToFront();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DonDatHangBUS ddhBUS = new DonDatHangBUS();
            HoaDonBUS hdBUS = new HoaDonBUS();
            hdBUS.Delete_CT_HoaDonTheoMaHD(UC_ListHoaDon.Instance.maHD_edit);
            hdBUS.Delete_HoaDon(UC_ListHoaDon.Instance.maHD_edit);
            XtraMessageBox.Show("Đã xóa đơn đặt hàng thành công!");
        }
    }
}
