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
    public class CT_DonDatHangDAO:DBConnection
    {
        public bool Update_CT_DonDatHang(string _maDDH, string _maSP, int _soLuong, double _thanhTien)
        {
            try
            {
                string store = "CT_DONDATHANG_UPDATE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.NVarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@soLuong", SqlDbType.Int, 10)).Value = _soLuong;
                cmd.Parameters.Add(new SqlParameter("@thanhTien", SqlDbType.Int, 100)).Value = _thanhTien;
                
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

        public bool Delete_CT_DonDatHang(string _maDDH, string _maSP)
        {
            try
            {
                string store = "CT_DONDATHANG_DELETE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
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
        public bool Delete_CT_DonDatHangTheoMaDDH(string _maDDH)
        {
            try
            {
                string store = "ct_dondathang_deletetheomaddh";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
               
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

        public bool Insert_CT_DonDatHang(string _maDDH, string _maSP, int _soLuong, int _thanhTien, string _ghiChu)
        {
            try
            {
                string store = "CT_DONDATHANG_INSERT";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
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
        public DataTable Search_CT_DonDatHang(string _maDDH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                string store = "CT_DONDATHANG_SEARCH";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maDDH", SqlDbType.NVarChar, 10));
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

        public DataTable Load_DSCT_DonDatHang()
        {
            try
            {
                string store = "CT_DONDATHANG_LAYDS";
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

        public DataTable Load_DSCT_theomaDDH(string _maDDH)
        {
            try
            {
                string store = "ct_dondathang_laydstheomaddh";
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
        public string KT_maSP(string _maDDH, string _maSP)
        {
            string kq;
            try
            {
                string store = "ct_dondathang_ktmasp";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.NVarChar, 10)).Value = _maSP;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kq = dr["MaSP"].ToString();

                }
                else
                {
                    kq = null;
                }
                //SqlParameter ktma = cmd.Parameters.Add("@maddh", SqlDbType.VarChar,10);
                //kq = ktma.Value.ToString();

                //conn.Close();
                conn.Close();

                return kq;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                kq = "không connect duoc";
                return kq;
            }
        }

    }
}
