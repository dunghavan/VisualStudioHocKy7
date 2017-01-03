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
    public class BCTonKhoBUS
    {
        BCTonKhoDAO objBCTK = new BCTonKhoDAO();
        public bool addBaoCao(BCTonKho baoCao)
        {
            return objBCTK.addBaoCao(baoCao);
        }
        public bool deleteBaoCao(string ngayLap, string maSP)
        {
            return objBCTK.deleteBaoCao(ngayLap, maSP);
        }
        public bool updateBaoCao(BCTonKho baoCao)
        {
            return objBCTK.updateBaoCao(baoCao);
        }
        public DataTable getAllBaoCao()
        {
            return objBCTK.getAllBaoCao();
        }
        public int getSLNhap(string _maSP, int _month, int _year)
        {
            return objBCTK.getSLNhap(_maSP, _month, _year);
        }
        public int getSLXuat(string _maSP, int _month, int _year)
        {
            return objBCTK.getSLXuat(_maSP, _month, _year);
        }
        public int getSLTonKyCuoi(string _maSP, int _month, int _year)
        {
            return objBCTK.getSLTonKyCuoi(_maSP, _month, _year);
        }
        
    }
}
