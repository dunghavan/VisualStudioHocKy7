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

namespace Presentation_Tier
{
    public partial class UserControl_ListButton_PhieuChi : UserControl
    {
        private static UserControl_ListButton_PhieuChi _instance;
        public static UserControl_ListButton_PhieuChi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_PhieuChi();
                return _instance;
            }   
        }
        public UserControl_ListButton_PhieuChi()
        {
            InitializeComponent();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddPhieuChi.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddPhieuChi.Instance);
            UserControl_AddPhieuChi.Instance.BringToFront();
            //Reset all field:
            UserControl_AddPhieuChi.Instance.resetAllField();

            //Disable các btn:
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditPhieuChi.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditPhieuChi.Instance);
            UserControl_EditPhieuChi.Instance.BringToFront();

            UserControl_EditPhieuChi.Instance.loadDataFromGridview();
            //Disable các btn:
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            UserControl_ListPhieuChi.Instance.label_notification.Text = null;
            string maPCDelete = null;
            bool deleted = false;
            try
            {
                maPCDelete = UserControl_ListPhieuChi.selectedRow["Mã Phiếu Chi"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa phiếu chi?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = UserControl_ListPhieuChi.objPhieuChiBUS.deletePhieuChi(maPCDelete);
                    if (deleted)
                    {
                        UserControl_ListPhieuChi.Instance.loadDanhSachPhieuChi();
                        UserControl_ListPhieuChi.Instance.label_notification.Text = "Đã xóa phiếu chi!";
                    }
                    else
                        XtraMessageBox.Show("Xóa không thành công");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tại sự kiện button Xóa: \n" + ex.Message);
            }
        }
    }
}
