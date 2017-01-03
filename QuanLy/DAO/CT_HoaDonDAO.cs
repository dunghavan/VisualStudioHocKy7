using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CT_HoaDonDAO: DBConnection
    {
        public bool Update_CT_HoaDon(string _maHD, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                string store = "CT_HOADON_UPDATE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NVarChar, 10)).Value = _maHD;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.NVarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@soLuong", SqlDbType.Int, 10)).Value = _soLuong;
                cmd.Parameters.Add(new SqlParameter("@thanhTien", SqlDbType.Int, 100)).Value = _thanhTien;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _ghiChu;
                

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return false;
            }
        }

        public bool Delete_CT_HoaDon(string _maHD, string _maSP)
        {
            try
            {
                string store = "CT_HOADON_DELETE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NVarChar, 10)).Value = _maHD;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.NVarChar, 10)).Value = _maSP;



                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return false;
            }
        }

        public bool Delete_CT_HoaDonTheoMaHD(string _maHD)
        {
            try
            {
                string store = "ct_hoadon_deletetheomahd";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NVarChar, 10)).Value = _maHD;
               


                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return false;
            }
        }



        public bool Insert_CT_HoaDon(string _maHD, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                string store = "CT_HOADON_INSERT";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NVarChar, 10)).Value = _maHD;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.NVarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@soLuong", SqlDbType.Int, 10)).Value = _soLuong;
                cmd.Parameters.Add(new SqlParameter("@thanhTien", SqlDbType.Int, 100)).Value = _thanhTien;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _ghiChu;




                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return false;
            }
        }

        public DataTable Search_CT_HoaDon(string _maHD, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                string store = "CT_HOADON_SEARCH";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maHD", SqlDbType.NVarChar, 10));
                cmd.Parameters.Add(new SqlParameter("_maSP", SqlDbType.NVarChar, 10));
                cmd.Parameters.Add(new SqlParameter("_soLuong", SqlDbType.Int, 10));
                cmd.Parameters.Add(new SqlParameter("_thanhTien", SqlDbType.Int, 100));
                cmd.Parameters.Add(new SqlParameter("_ghiChu", SqlDbType.NVarChar, 100));


                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return null;
            }
        }

        public DataTable Load_DSCT_HoaDon()
        {
            try
            {
                string store = "CT_HOADON_LAYDS";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return null;
            }
        }


        public DataTable Load_CTHoaDonSi(string _maDDH)
        {
            try
            {
                string store = "ct_hoadonsi_layds";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return null;
            }
        }

        public DataTable Load_DSCT_theomaHD(string _maHD)
        {
            try
            {
                string store = "ct_hoadon_laydstheohd";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NVarChar, 10)).Value = _maHD;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return null;
            }
        }

       
        
    }
}
