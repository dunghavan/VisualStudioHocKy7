using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PhieuThuDTO
    {
        public string maPT { get; set; }
        public DateTime ngayLap { get; set; }
        public string maNV { get; set; }
        public double soTienNo { get; set; }
        public double soTienThu { get; set; }

        public PhieuThuDTO(string _maPT, DateTime _ngayLap, string _maNV, double _soTienNo, double _soTienThu)
        {
            maPT = _maPT;
            ngayLap = _ngayLap;
            maNV = _maNV;
            soTienNo = _soTienNo;
            soTienThu = _soTienThu;



        }
    }
}
