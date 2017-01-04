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

namespace GUI
{
    public partial class UserControl_ListButton_PhieuThu : UserControl
    {
        private static UserControl_ListButton_PhieuThu _instance;
        public static UserControl_ListButton_PhieuThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_PhieuThu();
                return _instance;
            }   
        }
        public UserControl_ListButton_PhieuThu()
        {
            InitializeComponent();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddPhieuThu.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddPhieuThu.Instance);
            UserControl_AddPhieuThu.Instance.BringToFront();
            //Reset all field:
            UserControl_AddPhieuThu.Instance.resetAllField();

            //Disable các btn:
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditPhieuThu.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditPhieuThu.Instance);
            UserControl_EditPhieuThu.Instance.BringToFront();

            UserControl_EditPhieuThu.Instance.loadDataFromGridview();
            //Disable các btn:
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            UserControl_ListPhieuThu.Instance.label_notification.Text = null;
            string maPTDelete = null;
            bool deleted = false;
            try
            {
                maPTDelete = UserControl_ListPhieuThu.selectedRow["Mã Phiếu Thu"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa phiếu thu?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = UserControl_ListPhieuThu.objPhieuThuBUS.deletePhieuThu(maPTDelete);
                    if (deleted)
                    {
                        UserControl_ListPhieuThu.Instance.loadDanhSachPhieuThu();
                        UserControl_ListPhieuThu.Instance.label_notification.Text = "Đã xóa phiếu thu!";
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
