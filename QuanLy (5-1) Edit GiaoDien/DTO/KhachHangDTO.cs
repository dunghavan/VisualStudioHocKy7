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
        public bool isActive { get; set; }
        public KhachHangDTO() { }

        public KhachHangDTO(string _maKH, string _hoTen, string _diaChi, string _soDT, string _ghiChu, bool _isAtive)
        {
            maKH = _maKH;
            hoTen = _hoTen;
            diaChi = _diaChi;
            soDT = _soDT;
            ghiChu = _ghiChu;
            isActive = _isAtive;
        }
    }
}
