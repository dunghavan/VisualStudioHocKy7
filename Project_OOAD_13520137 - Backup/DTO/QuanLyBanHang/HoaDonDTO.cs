using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDonDTO
    {

        public string maHD { get; set; }
        public DateTime ngayLap { get; set; }
        public string maNV { get; set; }
        public string maKH { get; set; }
        public double tongTien { get; set; }
        public string ghiChu { get; set; }


        public HoaDonDTO(string _maHD, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            maHD = _maHD;
            ngayLap = _ngayLap;
            maNV = _maNV;
            maKH = _maKH;
            tongTien = _tongTien;
            ghiChu = _ghiChu;


        }
    }
}
