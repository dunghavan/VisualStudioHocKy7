using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThu
    {
        public string maPhieuThu { get; set; }
        public DateTime ngayLap { get; set; }
        public string maNV { get; set; }
        public string maKH { get; set; }
        public int soTienNo { get; set; }
        public int soTienThu { get; set; }
        public PhieuThu() { }
        public PhieuThu(string _maPhieuThu, DateTime _ngayLap, string _maNV, string _maKH, int _soTienNo, int _soTienThu)
        {
            maPhieuThu = _maPhieuThu;
            ngayLap = _ngayLap;
            maNV = _maNV;
            maKH = _maKH;
            soTienNo = _soTienNo;
            soTienThu = _soTienThu;
        }
    }
}
