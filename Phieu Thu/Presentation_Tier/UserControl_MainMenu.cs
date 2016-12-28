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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if(!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_QLUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_QLUser.Instance);
            UserControl_QLUser.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton.Instance);
            UserControl_ListButton.Instance.BringToFront();

        }
    }
}
