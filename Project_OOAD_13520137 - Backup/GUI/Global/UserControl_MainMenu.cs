using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;


namespace GUI
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

        private void btn_QLKH_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_QLKH.Instance))
            {
                ((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_QLKH.Instance);
            }
            UserControl_QLKH.Instance.BringToFront();

        }


    }
}
