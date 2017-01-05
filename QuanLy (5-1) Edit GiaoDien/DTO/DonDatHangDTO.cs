using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatHangDTO
    {
        public string maDDH { get; set; }
        public DateTime ngayLap { get; set; }
        public string maNV { get; set; }
        public string maKH { get; set; }
        public double tongTien { get; set; }
        public DateTime ngayGiao { get; set; }
        public string ghiChu { get; set; }

        public DonDatHangDTO() { }

        public DonDatHangDTO(string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, DateTime _ngayGiao, string _ghiChu)
        {
            maDDH = _maDDH;
            ngayLap = _ngayLap;
            maNV = _maNV;
            maKH = _maKH;
            tongTien = _tongTien;
            ngayGiao = _ngayGiao;
            ghiChu = _ghiChu;
        }
    }
}
