using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CT_HoaDonDTO
    {
        
    
        protected string maHD { get; set; }
        protected string maSP { get; set; }
        protected int soLuong { get; set; }
        protected double thanhTien { get; set; }
        protected string ghiChu { get; set; }

        

        public CT_HoaDonDTO (string _maHD, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            maHD=_maHD;
            maSP=_maSP;
            soLuong = _soLuong;
            thanhTien = _thanhTien;
            ghiChu = _ghiChu;
        }
    }
}
