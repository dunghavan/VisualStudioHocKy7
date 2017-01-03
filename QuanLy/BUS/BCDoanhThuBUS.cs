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
    public class BCDoanhThuBUS
    {
        BCDoanhThuDAO objBCDT = new BCDoanhThuDAO();
        public bool addBaoCao(BCDoanhThu baoCao)
        {
            return objBCDT.addBaoCao(baoCao);
        }
        public bool deleteBaoCao(string ngayLap, string maSP)
        {
            return objBCDT.deleteBaoCao(ngayLap, maSP);
        }
        public bool updateBaoCao(BCDoanhThu baoCao)
        {
            return objBCDT.updateBaoCao(baoCao);
        }
        public DataTable getAllBaoCao()
        {
            return objBCDT.getAllBaoCao();
        }
        public int getTongChi(string _maSP, int _month, int _year)
        {
            return objBCDT.getTongChi( _maSP, _month, _year);
        }
        public int getTongThu(string _maSP, int _month, int _year)
        {
            return objBCDT.getTongThu(_maSP, _month, _year);
        }
        public DataTable getTongChi_TongThu(string _maSP, int _month, int _year)
        {
            return objBCDT.getTongChi_TongThu(_maSP, _month, _year);
        }
        
    }
}
