using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Localization;

namespace GUI
{
    public partial class UserControl_MainEmpty : UserControl
    {
        private static UserControl_MainEmpty _instance;
        public static UserControl_MainEmpty Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_MainEmpty();
                return _instance;
            }
        }
        public UserControl_MainEmpty()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();
        }
        public static KhachHangBUS khBUS = new KhachHangBUS();
        public static DataTable tableKhachHang = new DataTable();
        private void gridControl_DSKH_Load(object sender, EventArgs e)
        {
            loadDanhSachKH();
            
        } 
        public void loadDanhSachKH()
        {
        }
        
    }
}
