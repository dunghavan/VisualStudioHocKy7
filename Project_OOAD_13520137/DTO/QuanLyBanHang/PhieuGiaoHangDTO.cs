using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuGiaoHangDTO
    {

        public string maPGH { get; set; }
        public DateTime ngayLap { get; set; }
        public string maNV { get; set; }
        public string maKH { get; set; }
        public double tongTien { get; set; }
        public string ghiChu { get; set; }
        public PhieuGiaoHangDTO() { }
        public PhieuGiaoHangDTO(string _maPGH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            maPGH = _maPGH;
            ngayLap = _ngayLap;
            maNV = _maNV;
            maKH = _maKH;
            tongTien = _tongTien;
            ghiChu = _ghiChu;


        }
    }
}
