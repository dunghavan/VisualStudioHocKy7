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
    public partial class UserControl_ListButton_KH : UserControl
    {
        public UserControl_ListButton_KH()
        {
            InitializeComponent();
        }
        private static UserControl_ListButton_KH _instance;
        public static UserControl_ListButton_KH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_KH();
                return _instance;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddKhachHang.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddKhachHang.Instance);
            UserControl_AddKhachHang.Instance.BringToFront();

            //Reset các field:
            UserControl_AddKhachHang.Instance.resetAllField();
            //Disable các btn:
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_them.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditKhachHang.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditKhachHang.Instance);
            UserControl_EditKhachHang.Instance.BringToFront();

            UserControl_EditKhachHang.Instance.loadDataFromGridView();

            //Disable các btn
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_them.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            UserControl_QLKH.Instance.label_notification.Text = null;
            string maKHDelete = null;
            bool deleted = false;
            try
            {
                maKHDelete = UserControl_QLKH.selectedRow["Mã KH"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa khách hàng?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = UserControl_QLKH.khBUS.DeleteKhachHang(maKHDelete);
                    if (deleted)
                    {
                        UserControl_QLKH.Instance.loadDanhSachKH();
                        UserControl_QLKH.Instance.label_notification.Text = "Đã xóa khách hàng!";
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
