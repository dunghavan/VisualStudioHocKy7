using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;



namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAO hdDAO;
        private CT_HoaDonDAO ct_hdDAO;

      

        public DataTable Load_DSHoaDon()
        {

            return hdDAO.Load_DSHoaDon();



        }

       

        public DataTable Load_CTDS_HoaDon()
        {

            return ct_hdDAO.Load_DSCT_HoaDon();
        }

        public DataTable Load_CTHoaDonSi(string _maDDH)
        {
            try
            {
                return ct_hdDAO.Load_CTHoaDonSi(_maDDH);
            }
            catch (Exception e)
            {
                return null;
            }
            

        }

        public HoaDonBUS()
        {
            hdDAO = new HoaDonDAO();
            ct_hdDAO = new CT_HoaDonDAO();
        }

        public bool Update_HoaDon(string _maHD, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            try
            {
                return hdDAO.Update_HoaDon(_maHD, _ngayLap, _maNV, _maKH, _tongTien, _ghiChu);

            }
            catch
            {
                return false;
            }
        }

        public bool Update_CT_HoaDon(string _maHD, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                return ct_hdDAO.Update_CT_HoaDon(_maHD, _maSP, _soLuong, _thanhTien, "");

            }
            catch
            {
                return false;
            }
        }

        public bool Insert_HoaDon(string _maHD, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            try
            {
                return hdDAO.Insert_HoaDon(_maHD,_ngayLap, _maNV, _maKH, _tongTien, _ghiChu);

            }
            catch
            {
                return false;
            }
        }
        public bool Insert_CTHoaDon(string _maHD, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                return ct_hdDAO.Insert_CT_HoaDon(_maHD,_maSP,_soLuong,_thanhTien,_ghiChu);

            }
            catch
            {
                return false;
            }
        }
        public bool Delete_HoaDon(string _maHD)
        {
            try
            {
                return hdDAO.Delete_HoaDon(_maHD);

            }
            catch
            {
                return false;
            }
        }
        public bool Delete_CT_HoaDon(string _maHD, string _maSP)
        {
            try
            {
                return ct_hdDAO.Delete_CT_HoaDon(_maHD, _maSP);

            }
            catch
            {
                return false;
            }
        }

        public bool Delete_CT_HoaDonTheoMaHD(string _maHD)
        {
            try
            {
                return ct_hdDAO.Delete_CT_HoaDonTheoMaHD(_maHD);

            }
            catch
            {
                return false;
            }
        }
        public DataTable Search_HoaDon(string _maHD, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien)
        {
            try
            {
                return hdDAO.Search_HoaDon(_maHD, _ngayLap, _maNV, _maKH, _tongTien);
            }
            catch
            {
                return null;
            }
        }

        public string KT_maHD(string _maHD)
        {
            try
            {
                return hdDAO.KT_maHD(_maHD);
            }
            catch
            {

                return "";
            }
        }

       


        public bool Update_TongTienHD(string _maHD, int _tongTien)
        {
            try
            {
                return hdDAO.Update_TongTienHD(_maHD, _tongTien);

            }
            catch
            {
                return false;
            }
        }

        public DataTable Load_DSCT_TheoMaHD(string _maHD)
        {

            return ct_hdDAO.Load_DSCT_theomaHD(_maHD);



        }
    }
}
