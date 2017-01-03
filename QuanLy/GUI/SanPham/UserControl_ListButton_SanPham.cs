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
    public partial class UserControl_ListButton_SanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserControl_ListButton_SanPham _instance;
        public static UserControl_ListButton_SanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_SanPham();
                return _instance;
            }
        }
        public UserControl_ListButton_SanPham()
        {
            InitializeComponent();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddSanPham.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddSanPham.Instance);
            UserControl_AddSanPham.Instance.BringToFront();

            //Reset các field:
            UserControl_AddSanPham.Instance.resetAllField();
            //Disable các btn:
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditSanPham.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditSanPham.Instance);
            UserControl_EditSanPham.Instance.BringToFront();

            UserControl_EditSanPham.Instance.loadDataFromGridview();

            //Disable các btn
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            string maSPDelete = null;
            bool deleted = false;
            try
            {
                maSPDelete = UserControl_ListSanPham.selectedRow["Mã SP"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn vô hiệu hóa sản phẩm?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = UserControl_ListSanPham.objSPBus.deleteSanPham(maSPDelete);
                    if (deleted)
                    {
                        UserControl_ListSanPham.Instance.loadDanhSachSP();
                        UserControl_ListSanPham.Instance.label_notification.Text = "Đã vô hiệu hóa sản phẩm!";
                    }
                    else
                        XtraMessageBox.Show("Vô hiệu hóa không thành công");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tại sự kiện button vô hiệu hóa: \n" + ex.Message);
            }
        }
    }
}
