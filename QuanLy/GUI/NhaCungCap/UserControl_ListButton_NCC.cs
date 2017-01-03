using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class UserControl_ListButton_NCC : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserControl_ListButton_NCC _instance;
        public static UserControl_ListButton_NCC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_NCC();
                return _instance;
            }
        }
        public UserControl_ListButton_NCC()
        {
            InitializeComponent();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddNCC.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddNCC.Instance);
            UserControl_AddNCC.Instance.BringToFront();

            //Reset các field:
            UserControl_AddNCC.Instance.resetAllField();
            //Disable các btn:
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditNCC.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditNCC.Instance);
            UserControl_EditNCC.Instance.BringToFront();

            UserControl_EditNCC.Instance.loadDataFromGridview();

            //Disable các btn
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maNCCDelete = null;
            bool deleted = false;
            try
            {
                maNCCDelete = UserControl_ListNCC.selectedRow["Mã NCC"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn vô hiệu hóa nhà cung cấp?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = UserControl_ListNCC.objNCCBus.deleteNhaCungCap(maNCCDelete);
                    if (deleted)
                    {
                        UserControl_ListNCC.Instance.loadDanhSachNCC();
                        UserControl_ListNCC.Instance.label_notification.Text = "Đã vô hiệu hóa nhà cung cấp!";
                    }
                    else
                        XtraMessageBox.Show("Vô hiệu hóa không thành công");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tại sự kiện button Vô hiệu hóa: \n" + ex.Message);
            }
        }
    }
}
