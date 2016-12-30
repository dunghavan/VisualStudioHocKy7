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
    public partial class ThayDoiQuyDinh_ListButton : UserControl
    {
        private static ThayDoiQuyDinh_ListButton _instance;
        public static ThayDoiQuyDinh_ListButton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ThayDoiQuyDinh_ListButton();
                return _instance;
            }
        }
        public ThayDoiQuyDinh_ListButton()
        {
            InitializeComponent();
        }
    }
}
