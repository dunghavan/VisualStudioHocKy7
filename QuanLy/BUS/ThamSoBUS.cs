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
    public class ThamSoBUS
    {
        ThamSoDAO objTS = new ThamSoDAO();
        public bool updateThamSo(ThamSo thamSo)
        {
            return objTS.updateThamSo(thamSo);
        }
        public DataTable getAllThamSo()
        {
            return objTS.getAllThamSo();
        }
    }
}
