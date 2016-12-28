using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO objSP = new SanPhamDAO();
        public bool addSP(SanPham sanpham)
        {
            return objSP.addSanPham(sanpham);
        }
        public bool deleteSanPham(string maSP)
        {
            return objSP.deleteSanPham(maSP);
        }
        public bool updateSanPham(SanPham sanpham)
        {
            return objSP.updateSanPham(sanpham);
        }
        public SanPham getSanPham(string maSP)
        {
            return objSP.getSanPham(maSP);
        }
        public DataTable getAllSanPham()
        {
            return objSP.getAllSanPham();
        }
    }
}
