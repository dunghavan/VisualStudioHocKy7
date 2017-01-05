using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BCTonKho
    {
        public DateTime ngayLap { get; set; }
        public string maSP { get; set; }
        public int slTonKyDau { get; set; }
        public int slNhap { get; set; }
        public int slXuat { get; set; }
        public int slPhatSinh { get; set; }
        public int slTonCuoiKy { get; set; }
        public string ghiChu { get; set; }
        public BCTonKho() { }
        public BCTonKho(DateTime _ngayLap, string _maSP, int _slTonKyDau, int _slNhap, int _slXuat, int _slPhatSinh, int _slTonCuoiKy, string _ghiChu)
        {
            ngayLap = _ngayLap;
            maSP = _maSP;
            slTonKyDau = _slTonKyDau;
            slNhap = _slNhap;
            slXuat = _slXuat;
            slPhatSinh = _slPhatSinh;
            slTonCuoiKy = _slTonCuoiKy;
            ghiChu = _ghiChu;
        }
    }
}
