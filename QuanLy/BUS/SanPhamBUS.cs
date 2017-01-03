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
        public DataTable getAllNhaCungCap()
        {
            return objSP.getAllSanPham();
        }
        public DataTable getAllSanPham()
        {
            return objSP.getAllSanPham();
        }

        public DataTable getAllSanPham_TheoMaDDH(string _maDDH)
        {
            return objSP.getAllSanPham_TheoMaDDH( _maDDH);
        }
        public bool updateSLSanPham(string maSP, int soluong)
        {
            return objSP.Update_SL(maSP, soluong);
        }
        public int kiemtraSLSanPham(string _maSP)
        {
            return objSP.KT_SoLuong(_maSP);
        }
        public DataTable searchSanPham(string maSanPham, string tenSanPham, string maLoaiSP)
        {
            return objSP.searchSanPham(maSanPham, tenSanPham, maLoaiSP);
        }
    }
}
