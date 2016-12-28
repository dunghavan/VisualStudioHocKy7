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
    public partial class UserControl_ListButton_BCTonKho : UserControl
    {
        private static UserControl_ListButton_BCTonKho _instance;
        public static UserControl_ListButton_BCTonKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_BCTonKho();
                return _instance;
            }   
        }
        public UserControl_ListButton_BCTonKho()
        {
            InitializeComponent();
        }

        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddBCTonKho.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddBCTonKho.Instance);
            UserControl_AddBCTonKho.Instance.BringToFront();

            //Reset các field:
            UserControl_AddBCTonKho.Instance.resetAllField();
            //Disable các btn:
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditBCTonKho.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditBCTonKho.Instance);
            UserControl_EditBCTonKho.Instance.BringToFront();

            UserControl_EditBCTonKho.Instance.loadDataFromGridview();

            //Disable các btn
            btn_Edit.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_themMoi.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            UserControl_ListBCTonKho.Instance.label_notification.Text = null;
            string ngayLapDelete = null;
            string maSPDelete = null;
            bool deleted = false;
            try
            {
                DataRow dr = UserControl_ListBCTonKho.selectedRow;
                ngayLapDelete = dr["Ngày Lập"].ToString();
                maSPDelete = dr["Mã Sản Phẩm"].ToString();
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa báo cáo tồn kho?", "Xác nhận!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleted = UserControl_ListBCTonKho.objBCBus.deleteBaoCao(ngayLapDelete, maSPDelete);
                    if (deleted)
                    {
                        //XtraMessageBox.Show("Xóa thành công");
                        UserControl_ListBCTonKho.Instance.loadDanhSachBaoCao();
                        Form parentForm = this.FindForm();
                        UserControl_ListBCTonKho.Instance.label_notification.Text = "Đã xóa báo cáo công nợ!";
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
