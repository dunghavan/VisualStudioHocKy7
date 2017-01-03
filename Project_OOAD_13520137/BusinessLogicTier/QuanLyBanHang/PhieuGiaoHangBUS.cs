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
    public class PhieuGiaoHangBUS
    {
        private PhieuGiaoHangDAO pghDAO;
        private CT_PhieuGiaoHangDAO ct_pghDAO;


        public DataTable Load_DSPhieuGiaoHang()
        {

            return pghDAO.Load_DSPhieuGiaoHang();

        }

        public DataTable Load_CTDS_PhieuGiaoHang()
        {

            return ct_pghDAO.Load_DSCT_PhieuGiaoHang();

        }
        public PhieuGiaoHangBUS()
        {
            pghDAO = new PhieuGiaoHangDAO();
            ct_pghDAO = new CT_PhieuGiaoHangDAO();
        }

        public bool Update_PhieuGiaoHang(string _maPGH, string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            try
            {
                return pghDAO.Update_PhieuGiaoHang(_maPGH, _maDDH, _ngayLap, _maNV, _maKH, _tongTien, _ghiChu);

            }
            catch
            {
                return false;
            }
        }
        public bool Update_CT_PhieuGiaoHang(string _maPGH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                return ct_pghDAO.Update_CT_PhieuGiaoHang(_maPGH, _maSP, _soLuong, _thanhTien, _ghiChu);

            }
            catch
            {
                return false;
            }
        }

        public bool Insert_PhieuGiaoHang(string _maPGH, string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            try
            {
                return pghDAO.Insert_PhieuGiaoHang(_maPGH, _maDDH, _ngayLap, _maNV, _maKH, _tongTien, _ghiChu);

            }
            catch
            {
                return false;
            }
        }
        public bool Insert_CT_PhieuGiaoHang(string _maPGH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                return ct_pghDAO.Insert_CT_PhieuGiaoHang(_maPGH, _maSP, _soLuong, _thanhTien, _ghiChu);

            }
            catch
            {
                return false;
            }
        }
        public bool Delete_PhieuGiaoHang(string _maPGH)
        {
            try
            {
                return pghDAO.Delete_PhieuGiaoHang(_maPGH);

            }
            catch
            {
                return false;
            }
        }

        public bool Delete_CT_PhieuGiaoHang(string _maPGH, string _maSP)
        {
            try
            {
                return ct_pghDAO.Delete_CT_PhieuGiaoHang(_maPGH, _maSP);

            }
            catch
            {
                return false;
            }
        }

        public bool Delete_CT_PhieuGiaoHangTheoMaPGH(string _maPGH)
        {
            try
            {
                return ct_pghDAO.Delete_CT_PhieuGiaoHangThepMaPGH(_maPGH);

            }
            catch
            {
                return false;
            }
        }



        public DataTable Search_PhieuGiaoHang(string _maPGH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien)
        {
            try
            {
                return pghDAO.Search_PhieuGiaoHang(_maPGH, _ngayLap, _maNV, _maKH, _tongTien);
            }
            catch
            {
                return null;
            }
        }

        public DataTable Search_CT_PhieuGiaoHang(string _maPGH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                return ct_pghDAO.Search_CT_PhieuGiaoHang(_maPGH, _maSP, _soLuong, _thanhTien, _ghiChu);
            }
            catch
            {
                return null;
            }
        }

        public int KTSoLuongTheoMaSP(string _maDDH, string _maSP)
        {
            return ct_pghDAO.KTSoLuongTheoMaSP(_maDDH, _maSP);
            
        }

        public int KTSoLuongDaGiao(string _maDDH, string _maSP)
        {
            return ct_pghDAO.KT_SoLuong_DaGiao(_maDDH, _maSP);

        }

        public DataTable Load_DSCT_TheoMaPGH(string _maPGH)
        {

            return ct_pghDAO.Load_DSCT_theomaPGH(_maPGH);



        }

        public string KT_maPGH(string _maPGH)
        {
            try
            {
                return pghDAO.KT_maPGH(_maPGH);
            }
            catch
            {

                return "";
            }
        }

        public bool Update_TongTienPGH(string _maPGH, int _tongTien)
        {
            try
            {
                return pghDAO.Update_TongTienPGH(_maPGH, _tongTien);

            }
            catch
            {
                return false;
            }
        }
         public int KT_SoLuong_TheoMaDDH(string _maDDH, string _maSP)
        {
            try
            {
                return ct_pghDAO.KT_SoLuong_TheoDDH(_maDDH, _maSP);
            }
            catch
            {

                return -1;
            }
        }
         public int KT_SoLuong_CTPGH_TheoMaSP(string _maPGH, string _maSP)
         {
             try
             {
                 return ct_pghDAO.KT_SoLuong_TheoMaSP_CTPGH(_maPGH, _maSP);
             }
             catch
             {

                 return -1;
             }
         }

    }
}
        
            
        
        