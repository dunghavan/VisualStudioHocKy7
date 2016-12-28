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
    public class PhieuChiBUS
    {
        PhieuChiDAO objPC = new PhieuChiDAO();
        public bool addPhieuChi(PhieuChi phieuChi)
        {
            return objPC.addPhieuChi(phieuChi);
        }
        public bool deletePhieuChi(string maPC)
        {
            return objPC.deletePhieuChi(maPC);
        }
        public bool updatePhieuChi(PhieuChi phieuChi)
        {
            return objPC.updatePhieuChi(phieuChi);
        }
        public PhieuChi getPhieuChi(string maPC)
        {
            return objPC.getPhieuChi(maPC);
        }
        public DataTable getAllPhieuChi()
        {
            return objPC.getAllPhieuChi();
        }
        public DataTable searchPhieuChi(string maPC, string ngayLap)
        {
            return objPC.searchPhieuChi(maPC, ngayLap);
        }
    }
}
