using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presentation_Tier;
using DevExpress.XtraEditors;
using BusinessLogicTier;

namespace Presentation_Tier
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        //private static MainForm _mainForm;
        //public static MainForm Instance
        //{
        //    get
        //    {
        //        if (_mainForm == null)
        //            _mainForm = new MainForm();
        //        return _mainForm;
        //    }
        //}

        public MainForm()
        {
            InitializeComponent();
            loadTableNhanVien();
            mainPanel.Controls.Add(UserControl_Login.Instance);

            label_size.Text = "Kích thước size: " + this.Size;
        }

        public static NhanVienBUS objNVBus = new NhanVienBUS();
        public static DataTable tableNhanVien = new DataTable();
        public static void loadTableNhanVien()
        {
            try
            {
                tableNhanVien = objNVBus.getAllNhanVien();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi load DS nhân viên: " + ex.Message);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            if (!mainPanel.Controls.Contains(UserControl_Login.Instance))
            {
                mainPanel.Controls.Add(UserControl_Login.Instance);
                UserControl_Login.Instance.Dock = DockStyle.Fill;
                UserControl_Login.Instance.BringToFront();
            }
            else
            {
                UserControl_Login.Instance.Dock = DockStyle.Fill;
                UserControl_Login.Instance.BringToFront();
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UserControl_Login.Instance))
            {
                mainPanel.Controls.Add(UserControl_Login.Instance);
                UserControl_Login.Instance.Dock = DockStyle.Fill;
                UserControl_Login.Instance.BringToFront();
            }
            //mainPanel.Controls.Contains.
            else
            {
                UserControl_Login.Instance.Dock = DockStyle.Fill;
                UserControl_Login.Instance.BringToFront();
            }
            hyperlink_dangXuat.Visible = false;
            label_usernameLogin.Text = null;
        }
    }
}
