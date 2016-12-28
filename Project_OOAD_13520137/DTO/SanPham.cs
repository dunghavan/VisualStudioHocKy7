using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public String MaSP { get; set; }
        public String TenSP { get; set; }
        public String DonVi { get; set; }
        public int DonGia { get; set; }
        public String GhiChu { get; set; }
        public String MaLoaiSP { get; set; }
        public SanPham() { }
        public SanPham (String _maSp, String _tenSp, String _donVi, int _donGia, String _ghiChu, String _maLoaiSP)
        {
            MaSP = _maSp;
            TenSP = _tenSp;
            DonVi = _donVi;
            DonGia = _donGia;
            GhiChu = _ghiChu;
            MaLoaiSP = _maLoaiSP; 
        }
    }
}
