using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Localization;

namespace GUI
{
    public class MyGridLocalizer: GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            switch (id)
            {
                case GridStringId.FindControlFindButton:
                    return "Tìm Kiếm";
                case GridStringId.FindControlClearButton:
                    return "Xóa trắng";
                case GridStringId.FilterPanelCustomizeButton:
                    return "My Edit Filter";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
