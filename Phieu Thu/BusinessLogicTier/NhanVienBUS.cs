using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BusinessLogicTier
{
    public class NhanVienBUS
    {
        NhanVienDAO objNV = new NhanVienDAO();
        public bool addNhanVien(NhanVien nhanVien)
        {
            return objNV.addNhanVien(nhanVien);
        }
        public bool deleteNhanVien(string maNV)
        {
            return objNV.deleteNhanVien(maNV);
        }
        public bool updateNhanVien(NhanVien nhanVien)
        {
            return objNV.updateNhanVien(nhanVien);
        }
        public NhanVien getNhanVien(string maNV)
        {
            return objNV.getNhanVien(maNV);
        }
        public DataTable getAllNhanVien()
        {
            return objNV.getAllNhanVien();
        }
        public DataTable searchNhanVien(string maNV, string hoTen, int namSinh, string maLoaiNV)
        {
            return objNV.searchNhanVien(maNV, hoTen, namSinh, maLoaiNV);
        }
    }
}
