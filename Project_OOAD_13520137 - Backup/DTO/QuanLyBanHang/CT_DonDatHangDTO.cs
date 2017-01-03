using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_DonDatHangDTO
    {
        public string maDDH { get; set; }
        public string maSP { get; set; }
        public  int soLuong { get; set; }
        public double thanhTien { get; set; }
        public string ghiChu { get; set; }

        public CT_DonDatHangDTO() { }
        public CT_DonDatHangDTO (string _maDDH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            maDDH=_maDDH;
            maSP=_maSP;
            soLuong = _soLuong;
            thanhTien = _thanhTien;
            ghiChu = _ghiChu;
        }
    }
}
