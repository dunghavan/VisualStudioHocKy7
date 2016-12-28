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
    public partial class UserControl_ListButton_BCCongNoKH : UserControl
    {
        private static UserControl_ListButton_BCCongNoKH _instance;
        public static UserControl_ListButton_BCCongNoKH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_BCCongNoKH();
                return _instance;
            }   
        }
        public UserControl_ListButton_BCCongNoKH()
        {
            InitializeComponent();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddBCCongNoKH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddBCCongNoKH.Instance);
            UserControl_AddBCCongNoKH.Instance.BringToFront();

            //Reset các field:
            UserControl_AddBCCongNoKH.Instance.resetAllField();
            //Disable các btn:
            //btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditBCCongNoKH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditBCCongNoKH.Instance);
            UserControl_EditBCCongNoKH.Instance.BringToFront();

            UserControl_EditBCCongNoKH.Instance.loadDataFromGridview();

            //Disable các btn
            //btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            UserControl_ListBCCongNoKH.Instance.label_notification.Text = null;

            string ngayLapDelete = null;
            string maKHDelete = null;
            bool deleted = false;
            try
            {
                DataRow dr = UserControl_ListBCCongNoKH.selectedRow;
                ngayLapDelete = dr["Ngày Lập"].ToString();
                maKHDelete = dr["Mã Khách Hàng"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa báo cáo công nợ?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = UserControl_ListBCCongNoKH.objBCBus.deleteBaoCao(ngayLapDelete, maKHDelete);
                    if (deleted)
                    {
                        //XtraMessageBox.Show("Xóa thành công");
                        UserControl_ListBCCongNoKH.Instance.loadDanhSachBaoCao();
                        Form parentForm = this.FindForm();
                        UserControl_ListBCCongNoKH.Instance.label_notification.Text = "Đã xóa báo cáo công nợ!";
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
