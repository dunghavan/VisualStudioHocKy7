using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BCDoanhThu
    {
        public DateTime ngayLap { get; set; }
        public string maSP { get; set; }
        public int tongChi { get; set; }
        public int phatSinh { get; set; }
        public int tongThu { get; set; }
        public int loiNhuan { get; set; }
        public string ghiChu { get; set; }
        public BCDoanhThu() { }
        public BCDoanhThu(DateTime _ngayLap, string _maSP, int _tongChi, int _phatSinh, int _tongThu, int _loiNhuan, string _ghiChu)
        {
            ngayLap = _ngayLap;
            maSP = _maSP;
            tongChi = _tongChi;
            phatSinh = _phatSinh;
            tongThu = _tongThu;
            loiNhuan = _loiNhuan;
            ghiChu = _ghiChu;
        }
        public BCDoanhThu(DateTime _ngayLap, string _maSP, int _phatSinh, int _loiNhuan, string _ghiChu)
        {
            ngayLap = _ngayLap;
            maSP = _maSP;
            phatSinh = _phatSinh;
            loiNhuan = _loiNhuan;
            ghiChu = _ghiChu;
        }
    }
}
