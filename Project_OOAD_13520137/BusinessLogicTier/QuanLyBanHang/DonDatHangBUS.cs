using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class DonDatHangBUS
    {
        private DonDatHangDAO ddhDAO;
        private CT_DonDatHangDAO ct_ddhDAO;

        public DonDatHangBUS()
        {
            ddhDAO = new DonDatHangDAO();
            ct_ddhDAO = new CT_DonDatHangDAO();
           
        }
        public DataTable Load_DSDonDatHang()
        {
            
                return ddhDAO.Load_DSDonDatHang();

            
      
        }

        public DataTable Load_DSCT_DonDatHang()
        {

            return ct_ddhDAO.Load_DSCT_DonDatHang();



        }

        public DataTable Load_DSDonDatHang_TheoMaDDH()
        {

            return ddhDAO.Load_DSDonDatHang_TheoMaDDH();



        }


        public DataTable Load_DSCT_TheoMaDDH(string _maDDH)
        {

            return ct_ddhDAO.Load_DSCT_theomaDDH(_maDDH);



        }

        public bool Update_DonDatHang(string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, DateTime _ngayGiao, string _ghiChu)
        {
            try
            {
                return ddhDAO.Update_DonDatHang(_maDDH, _ngayLap, _maNV, _maKH, _tongTien, _ngayGiao, _ghiChu);

            }
            catch
            {
                return false;
            }
        }
        public bool Update_TongTienDDH(string _maDDH,  int _tongTien)
        {
            try
            {
                return ddhDAO.Update_TongTienDDH(_maDDH, _tongTien);

            }
            catch
            {
                return false;
            }
        }

        public bool Update_CT_DonDatHang(string _maDDH, string _maSP, int _soLuong, double _thanhTien)
        {
            try
            {
                return ct_ddhDAO.Update_CT_DonDatHang(_maDDH,_maSP,_soLuong,_thanhTien);

            }
            catch
            {
                return false;
            }
        }
        
        public bool Insert_DonDatHang(string _maDDH,DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, DateTime _ngayGiao, string _ghiChu, int _no)
        {
            if (ddhDAO.KTCongNo(_maKH) <= _no)
            {
                try
                {
                    return ddhDAO.Insert_DonDatHang(_maDDH,_ngayLap, _maNV, _maKH, _tongTien, _ngayGiao, _ghiChu);

                }
                catch
                {
                    return false;
                }
            }
            else
                return false;
            
        }

        public bool Insert_CT_DonDatHang(string _maDDH, string _maSP, int _soLuong, int _thanhTien, string _ghiChu)
        {
            
                try
                {
                    return ct_ddhDAO.Insert_CT_DonDatHang(_maDDH,  _maSP, _soLuong,  _thanhTien,  _ghiChu);

                }
                catch
                {
                    return false;
                }
            
                

        }

        public bool Delete_DonDatHang(string _maDDH)
        {
            try
            {
                return ddhDAO.Delete_DonDatHang(_maDDH);

            }
            catch
            {
                return false;
            }
        }

        public bool Delete_CT_DonDatHang(string _maDDH, string _maSP)
        {
            try
            {
                return ct_ddhDAO.Delete_CT_DonDatHang(_maDDH,_maSP);

            }
            catch
            {
                return false;
            }
        }

        public bool Delete_CT_DonDatHangTheoMaDDH(string _maDDH)
        {
            try
            {
                return ct_ddhDAO.Delete_CT_DonDatHangTheoMaDDH(_maDDH);

            }
            catch
            {
                return false;
            }
        }
        public DataTable Search_DonDatHang(string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, DateTime _ngayGiao, double _tongTien)
        {
            try
            {
                return ddhDAO.Search_DonDatHang( _maDDH, _ngayLap, _maNV, _maKH, _ngayGiao,_tongTien);
            }
            catch
            {
                return null;
            }
        }

        public DataTable Search_CT_DonDatHang(string _maDDH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                return ct_ddhDAO.Search_CT_DonDatHang(_maDDH, _maSP, _soLuong, _thanhTien, _ghiChu);
            }
            catch
            {
                return null;
            }
        }

        public int KT_CongNo(string _maKH)
        {
            try
            {
                return ddhDAO.KTCongNo(_maKH);
            }
            catch
            {
                
                return -1;
            }
        }
        public string KT_maDDH(string _maDDH)
        {
            try
            {
                return ddhDAO.KT_maDDH(_maDDH);
            }
            catch
            {

                return "";
            }
        }

        public string KT_maSP(string _maDDH, string _maSP)
        {
            try
            {
                return ct_ddhDAO.KT_maSP(_maDDH,_maSP);
            }
            catch
            {

                return "";
            }
        }

       
        
    }
}
