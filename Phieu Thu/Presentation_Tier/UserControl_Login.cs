using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DevExpress.XtraEditors;

namespace Presentation_Tier
{
    public partial class UserControl_Login : UserControl
    {
        private static UserControl_Login _instance;
        public static UserControl_Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Login();
                return _instance;
            }
        }
        public UserControl_Login()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }


        private void btn_login_Click(object sender, EventArgs e)
        {

            Form parentForm = this.FindForm();
            string tempUsername = null;
            string tempPassword = null;
            string usernameLogin = null;
            bool checkLogin = false;
            try //check username và password:
            {
                foreach (DataRow dr in MainForm.tableNhanVien.Rows)
                {
                    tempUsername = dr["Username"].ToString().Trim();
                    tempPassword = dr["Password"].ToString().Trim();
                    if (String.Compare(textEdit_username.Text, tempUsername) == 0
                        && String.Compare(textEdit_password.Text, tempPassword) == 0)
                    {
                        checkLogin = true;
                        usernameLogin = dr["Username"].ToString().Trim();
                    }
                }

                if (checkLogin)
                {
                    if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_MainMenu.Instance))
                    {
                        ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_MainMenu.Instance);
                        UserControl_MainMenu.Instance.Dock = DockStyle.Fill;
                        UserControl_MainMenu.Instance.BringToFront();
                    }
                    else
                    {
                        UserControl_MainMenu.Instance.Dock = DockStyle.Fill;
                        UserControl_MainMenu.Instance.BringToFront();
                    }
                    ((MainForm)parentForm).hyperlink_dangXuat.Visible = true;
                    ((MainForm)parentForm).label_usernameLogin.Text = "Bạn đã đăng nhập với tài khoản: " + usernameLogin;

                }
                else
                    XtraMessageBox.Show("Sai Username hoặc password!");
                //MessageBox.Show(((MainForm)parentForm).Size.ToString());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi Login:" + ex.Message);
            }
        }
    }
}
