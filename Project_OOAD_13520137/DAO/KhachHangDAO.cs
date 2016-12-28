using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class KhachHangDAO: DBConnection
    {
        public KhachHangDAO() : base() { }
        public DataTable GetDSKhachHang()
        {
            try
            {
                string store = "KHACHHANG_LAYDS";
                SqlCommand cmd = new SqlCommand(store, connect);
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
                return null;
            }
          
        }

        public DataTable GetThongTinKH(string _maKH)
        {
            try
            {
                string store = "KHACHHANG_LAYTHONGTIN";
                SqlCommand cmd = new SqlCommand(store, connect);
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
                return null;
            }
           
        }

        //public bool SuaKhachHang(string _maKH, string _hoTen, string _diaChi, string _soDT, string _ghiChu)
        //{
        //    OpenConnect();
        //    string store = "KHACHHANG_LAYTHONGTIN";
        //    sqlCommand = new SqlCommand(store, connect);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.Add(new SqlParameter("@MaKH", _maKH));
        //    sqlCommand.Parameters.Add(new SqlParameter("@HoTen",_hoTen));
        //    sqlCommand.Parameters.Add(new SqlParameter("@DiaChi",_diaChi));
        //    sqlCommand.Parameters.Add(new SqlParameter("@SoDT", _soDT));
        //    sqlCommand.Parameters.Add(new SqlParameter("@GhiChu", _ghiChu));
        //    if (sqlCommand.ExecuteNonQuery() >= 0)
        //    {
        //        CloseConnect();
        //        return true;
        //    }
        //    else
        //    {
        //        CloseConnect();
        //        return false;
        //    }
        //}


        public bool Insert_KhachHang(string _hoTen, string _diaChi, string _soDT, string _ghiChu)
        {
            try
            {
                string store = "KHACHHANG_INSERT";
                SqlCommand cmd = new SqlCommand(store, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_hoTen", SqlDbType.NChar, 50));
                cmd.Parameters.Add(new SqlParameter("_diaChi", SqlDbType.NVarChar, 50));
                cmd.Parameters.Add(new SqlParameter("_soDT", SqlDbType.NVarChar, 15));
                cmd.Parameters.Add(new SqlParameter("_ghiChu", SqlDbType.NVarChar, 100));

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
            
          
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }
        }

        public bool Update_KhachHang(string _maKH, string _hoTen, string _diaChi, string _soDT, string _ghiChu)
        {
            try
            {
                string store = "KHACHHANG_UPDATE";
                SqlCommand cmd = new SqlCommand(store, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maKH", SqlDbType.NChar, 50));
                cmd.Parameters.Add(new SqlParameter("_hoTen", SqlDbType.NChar, 50));
                cmd.Parameters.Add(new SqlParameter("_diaChi", SqlDbType.NVarChar, 50));
                cmd.Parameters.Add(new SqlParameter("_soDT", SqlDbType.NVarChar, 15));
                cmd.Parameters.Add(new SqlParameter("_ghiChu", SqlDbType.NVarChar, 100));

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }        }

        public bool Delete_KhachHang(string _maKH)
        {
            try
            {
                string store = "KHACHHANG_UPDATE";
                SqlCommand cmd = new SqlCommand(store, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maKH", SqlDbType.NChar, 50));

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }
        }

        public DataTable Search_KhachHang(string _maKH, string _hoTen, string _diaChi, string _soDT)
        {
            try
            {
                string store = "KHACHHANG_TIMKIEM2";
                SqlCommand cmd = new SqlCommand(store, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maKH", SqlDbType.NChar, 50));
                cmd.Parameters.Add(new SqlParameter("_hoTen", SqlDbType.NChar, 50));
                cmd.Parameters.Add(new SqlParameter("_diaChi", SqlDbType.NVarChar, 50));
                cmd.Parameters.Add(new SqlParameter("_soDT", SqlDbType.NVarChar, 15));
             

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
                return null;
            }
            
        }
        public DataTable Search_KhachHangTuKhoa(string _tuKhoa)
        {
            try
            {
                string store = "KHACHHANG_TIMKIEM";
                SqlCommand cmd = new SqlCommand(store, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_tuKhoa", SqlDbType.NChar, 50));
               
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
                return null;
            }
        }

        public DataTable Load_DSKhachHang()
        {
            try
            {
                string store = "KHACHHANG_LAYDS";
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
                return null;
            }
        }

        public static bool Update_KhachHang(string _maKH, string _hoTen, string _diaChi, string _soDT)
        {
            throw new NotImplementedException();
        }

        public SqlConnection connect { get; set; }
    }
    }

