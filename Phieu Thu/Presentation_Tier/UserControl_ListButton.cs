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
    public partial class UserControl_ListButton : UserControl
    {
        private static UserControl_ListButton _instance;
        public static UserControl_ListButton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton();
                return _instance;
            }   
        }
        public UserControl_ListButton()
        {
            InitializeComponent();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddUser.Instance);
            UserControl_AddUser.Instance.BringToFront();

            //((MainForm)parentForm).buttonPanel.
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditUser.Instance);
            UserControl_EditUser.Instance.BringToFront();

            UserControl_EditUser.Instance.loadDataFromGridview();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maNVDelete = null;
            bool deleted = false;
            try
            {
                maNVDelete = UserControl_QLUser.selectedRow["Mã NV"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = MainForm.objNVBus.deleteNhanVien(maNVDelete);
                    if (deleted)
                    {
                        UserControl_QLUser.Instance.loadDanhSachNV();
                        UserControl_QLUser.Instance.label_notification.Text = "Đã xóa nhân viên!";
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
