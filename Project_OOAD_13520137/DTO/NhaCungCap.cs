using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        public String MaNCC { get; set; }
        public String TenNCC { get; set; }
        public String DiaChi { get; set; }
        public String SoDT { get; set; }
        public String GhiChu { get; set; }
        public NhaCungCap() { }
        public NhaCungCap(String _maNCC, String _tenNCC, String _diaChi, String _soDT, String _ghiChu)
        {
            MaNCC = _maNCC;
            TenNCC = _tenNCC;
            DiaChi = _diaChi;
            SoDT = _soDT;
            GhiChu = _ghiChu;
        }
    }
}
