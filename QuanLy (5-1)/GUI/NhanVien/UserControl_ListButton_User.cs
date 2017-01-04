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
    public partial class UserControl_ListButton_User : UserControl
    {
        private static UserControl_ListButton_User _instance;
        public static UserControl_ListButton_User Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_User();
                return _instance;
            }   
        }
        public UserControl_ListButton_User()
        {
            InitializeComponent();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddUser.Instance);
            UserControl_AddUser.Instance.BringToFront();

            //Reset các field:
            UserControl_AddUser.Instance.resetAllField();
            //Disable các btn:
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditUser.Instance);
            UserControl_EditUser.Instance.BringToFront();

            UserControl_EditUser.Instance.loadDataFromGridview();

            //Disable các btn
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            UserControl_ListUser.Instance.label_notification.Text = null;
            string maNVDelete = null;
            bool deleted = false;
            try
            {
                maNVDelete = UserControl_ListUser.selectedRow["Mã NV"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = UserControl_ListUser.objNVBus.deleteNhanVien(maNVDelete);
                    if (deleted)
                    {
                        UserControl_ListUser.Instance.loadDanhSachNV();
                        UserControl_ListUser.Instance.label_notification.Text = "Đã xóa nhân viên!";
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
