using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuChi
    {
        public string maPhieuChi { get; set; }
        public DateTime ngayLap { get; set; }
        public string maNV { get; set; }
        public string maNCC { get; set; }
        public int soTienNo { get; set; }
        public int soTienChi { get; set; }
        public PhieuChi() { }
        public PhieuChi(string _maPhieuChi, DateTime _ngayLap, string _maNV, string _maNCC, int _soTienNo, int _soTienChi)
        {
            maPhieuChi = _maPhieuChi;
            ngayLap = _ngayLap;
            maNV = _maNV;
            maNCC = _maNCC;
            soTienNo = _soTienNo;
            soTienChi = _soTienChi;
        }
    }
}
