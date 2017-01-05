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
      
        public DataTable GetThongTinKH(string _maKH)
        {
            try
            {
                string store = "KHACHHANG_LAYTHONGTIN";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.NChar, 50)).Value = _maKH;

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

      

        public bool Insert_KhachHang(string _maKH, string _hoTen, string _diaChi, string _soDT, string _ghiChu, bool _isActive)
        {
            try
            {
                string store = "KHACHHANG_INSERT";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value = _maKH;
                cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.NVarChar, 10)).Value = _hoTen;
                cmd.Parameters.Add(new SqlParameter("@diaChi", SqlDbType.NVarChar, 50)).Value = _diaChi;
                cmd.Parameters.Add(new SqlParameter("@soDT", SqlDbType.VarChar, 15)).Value = _soDT;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _ghiChu;
                cmd.Parameters.Add(new SqlParameter("@isActive", SqlDbType.Bit)).Value = _isActive;


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

        public bool Update_KhachHang(string _maKH, string _hoTen, string _diaChi, string _soDT, string _ghiChu, bool _isActive)
        {
            try
            {
                string store = "KHACHHANG_UPDATE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value = _maKH;
                cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.NVarChar, 50)).Value = _hoTen;
                cmd.Parameters.Add(new SqlParameter("@diaChi", SqlDbType.NVarChar, 50)).Value = _diaChi;
                cmd.Parameters.Add(new SqlParameter("@soDT", SqlDbType.VarChar, 15)).Value = _soDT;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _ghiChu;
                cmd.Parameters.Add(new SqlParameter("@isActive", SqlDbType.Bit)).Value = _isActive;


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

        public bool Delete_KhachHang(string _maKH)
        {
            try
            {
                string store = "KHACHHANG_DELETE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value = _maKH;

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
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return null;
            }
        }

        public static bool Update_KhachHang(string _maKH, string _hoTen, string _diaChi, string _soDT)
        {
            throw new NotImplementedException();
        }

    }
    }

