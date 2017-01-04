using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_PhieuGiaoHangDTO
    {
        public string maPGH { get; set; }
        public string maSP { get; set; }
        public int soLuong { get; set; }
        public double thanhTien { get; set; }
        public string ghiChu { get; set; }
        public int slDaGiao { get; set; }

        public CT_PhieuGiaoHangDTO() { slDaGiao = 0; }
        

        public CT_PhieuGiaoHangDTO (string _maPGH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            maPGH=_maPGH;
            maSP=_maSP;
            soLuong = _soLuong;
            thanhTien = _thanhTien;
            ghiChu = _ghiChu;
            
        }
    }
}
