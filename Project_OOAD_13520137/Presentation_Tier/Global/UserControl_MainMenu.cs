using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Tier
{
    public partial class UserControl_MainMenu : UserControl
    {
        private static UserControl_MainMenu _instance;
        public static UserControl_MainMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_MainMenu();
                return _instance;
            }
        }
        public UserControl_MainMenu()
        {
            InitializeComponent();
        }

        private void btn_QLUser_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListUser.Instance);
            UserControl_ListUser.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_User.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_User.Instance);
            UserControl_ListButton_User.Instance.BringToFront();
        }

        private void btn_PhieuThu_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListPhieuThu.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListPhieuThu.Instance);
            UserControl_ListPhieuThu.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_PhieuThu.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_PhieuThu.Instance);
            UserControl_ListButton_PhieuThu.Instance.BringToFront();
        }
    }
}
