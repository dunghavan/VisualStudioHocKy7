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
            if(!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_AddKhachHang.Instance))
            {
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_AddKhachHang.Instance);
            }
            UserControl_AddKhachHang.Instance.BringToFront();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_EditKhachHang.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_EditKhachHang.Instance);
            UserControl_EditKhachHang.Instance.BringToFront();

            UserControl_EditKhachHang.Instance.loadDataFromGridView();
        }

        
       
    }
}
