using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BCCongNoKH
    {
        public DateTime ngayLap { get; set; }
        public string maKH { get; set; }
        public string maNV { get; set; }
        public int noKyDau { get; set; }
        public int phatSinh { get; set; }
        public int noKyCuoi { get; set; }
        public string ghiChu { get; set; }
        public BCCongNoKH() { }
        public BCCongNoKH(DateTime _ngayLap, string _maKH, string _maNV, int _noKyDau, int _phatSinh, int _noKyCuoi, string _ghiChu)
        {
            ngayLap = _ngayLap;
            maKH = _maKH;
            maNV = _maNV;
            noKyDau = _noKyDau;
            phatSinh = _phatSinh;
            noKyCuoi = _noKyCuoi;
            ghiChu = _ghiChu;
        }
    }
}
