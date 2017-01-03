using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string maKH { get; set; }
        public string hoTen { get; set; }
        public string diaChi { get; set; }
        public string soDT { get; set; }
        public string ghiChu { get; set; }

        public KhachHangDTO(string _maKH, string _hoTen, string _diaChi, string _soDT, string _ghiChu)
        {
            maKH = _maKH;
            hoTen = _hoTen;
            diaChi = _diaChi;
            soDT = _soDT;
            ghiChu = _ghiChu;
        }
    }
}
