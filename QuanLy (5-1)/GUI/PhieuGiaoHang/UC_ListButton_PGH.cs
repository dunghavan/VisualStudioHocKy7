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
    public partial class UC_ListButton_PGH : UserControl
    {
        public UC_ListButton_PGH()
        {
            InitializeComponent();
        }
        private static UC_ListButton_PGH _instance;
        public static UC_ListButton_PGH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ListButton_PGH();
                return _instance;
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_AddPGH2.Instance))
            {
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_AddPGH2.Instance);
            }
            UC_AddPGH2.Instance.BringToFront();
            
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_EditPGH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_EditPGH.Instance);
            UC_EditPGH.Instance.BringToFront();
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            PhieuGiaoHangBUS pghBUS = new PhieuGiaoHangBUS();

            try
            {

                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa phiếu giao hàng?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //pghBUS.Delete_CT_PhieuGiaoHang;
                    pghBUS.Delete_CT_PhieuGiaoHangTheoMaPGH(UC_ListPGH.Instance.maPGH_edit);
                    pghBUS.Delete_PhieuGiaoHang(UC_ListPGH.Instance.maPGH_edit);
                    
                    //XtraMessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    XtraMessageBox.Show("Xóa không thành công");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tại sự kiện button Xóa: \n" + ex.Message);
            }
            UC_ListDonDatHang.Instance.BringToFront();
            UC_ListDonDatHang.Instance.LoadDonDatHang();
        }

    }
}
