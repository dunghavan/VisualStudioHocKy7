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
        public int GetChietKhau()
        {
            try
            {
                return objTS.GetChietKhau();
            }
            catch
            {

                return -1;
            }
        }

        public int TienNoToiDa()
        {
            try
            {
                return objTS.TienNoToiDa();
            }
            catch
            {

                return -1;
            }
        }

        public int GetSLTonToiThieu()
        {
            try
            {
                return objTS.GetSLTonToiThieu();
            }
            catch
            {

                return -1;
            }
        }
    }
}
