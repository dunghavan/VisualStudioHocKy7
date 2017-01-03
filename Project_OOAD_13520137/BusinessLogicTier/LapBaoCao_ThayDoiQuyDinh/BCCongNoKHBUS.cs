using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BCCongNoKHBUS
    {
        BCCongNoKHDAO objBCCN = new BCCongNoKHDAO();
        public bool addBaoCao(BCCongNoKH baoCao)
        {
            return objBCCN.addBaoCao(baoCao);
        }
        public bool deleteBaoCao(string ngayLap, string maKH)
        {
            return objBCCN.deleteBaoCao(ngayLap, maKH);
        }
        public bool updateBaoCao(BCCongNoKH baoCao)
        {
            return objBCCN.updateBaoCao(baoCao);
        }
        public DataTable getAllBaoCao()
        {
            return objBCCN.getAllBaoCao();
        }
        public int getNoKyCuoi(string maKH, int month, int year)
        {
            return objBCCN.getNoKyCuoi(maKH, month, year);
        }
    }
}
