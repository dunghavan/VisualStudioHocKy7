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
    public partial class UserControl_ListButton_Empty : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserControl_ListButton_Empty _instance;
        public static UserControl_ListButton_Empty Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ListButton_Empty();
                return _instance;
            }
        }
        public UserControl_ListButton_Empty()
        {
            InitializeComponent();
        }
    }
}
