using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class BCTonKhoDAO: DBConnection
    {
        public BCTonKhoDAO() : base() { }
        public bool addBaoCao(BCTonKho _baoCao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCTONKHO_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date)).Value = _baoCao.ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _baoCao.maSP;
                cmd.Parameters.Add(new SqlParameter("@slTonKyDau", SqlDbType.Int)).Value = _baoCao.slTonKyDau;
                cmd.Parameters.Add(new SqlParameter("@slNhap", SqlDbType.Int)).Value = _baoCao.slNhap;
                cmd.Parameters.Add(new SqlParameter("@slXuat", SqlDbType.Int)).Value = _baoCao.slXuat;
                cmd.Parameters.Add(new SqlParameter("@slPhatSinh", SqlDbType.Int)).Value = _baoCao.slPhatSinh;
                cmd.Parameters.Add(new SqlParameter("@slTonCuoiKy", SqlDbType.Int)).Value = _baoCao.slTonCuoiKy;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _baoCao.ghiChu;


                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    _logger.Info("Open connection!");
                }
                    
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                _logger.Info("Lỗi: " + e.Message);
                return false;
            }
        }

        public bool deleteBaoCao(string _ngayLap, string _maSP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCTONKHO_Del", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date)).Value = _ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _maSP;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return false;
            }
        }

        public bool updateBaoCao(BCTonKho _baoCao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCTONKHO_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date)).Value = _baoCao.ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _baoCao.maSP;
                cmd.Parameters.Add(new SqlParameter("@slTonKyDau", SqlDbType.Int)).Value = _baoCao.slTonKyDau;
                cmd.Parameters.Add(new SqlParameter("@slNhap", SqlDbType.Int)).Value = _baoCao.slNhap;
                cmd.Parameters.Add(new SqlParameter("@slXuat", SqlDbType.Int)).Value = _baoCao.slXuat;
                cmd.Parameters.Add(new SqlParameter("@slPhatSinh", SqlDbType.Int)).Value = _baoCao.slPhatSinh;
                cmd.Parameters.Add(new SqlParameter("@slTonCuoiKy", SqlDbType.Int)).Value = _baoCao.slTonCuoiKy;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _baoCao.ghiChu;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    _logger.Info("Open connection!");
                }
                cmd.ExecuteNonQuery();
                _logger.Info("Update BC Ton Kho!");

                conn.Close();
                _logger.Info("Close connection!");
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                _logger.Info("Lỗi :" + e.Message + "and close connection!");
                return false;
            }
        }


        public DataTable getAllBaoCao()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCTONKHO_getAll", conn);
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
                Console.WriteLine("Lỗi: " + e.Message);
                return null;
            }
        }
        public int getSLNhap(string _maSP, int _month, int _year)
        {
            int slNhap = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("BCTONKHO_getSLNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)).Value = _month;
                cmd.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)).Value = _year;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                slNhap = (int)cmd.ExecuteScalar();
                conn.Close();
                return slNhap;
            }
            catch(Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return slNhap;
            }
        }

        public int getSLTonKyCuoi(string _maSP, int _month, int _year)
        {
            int slTonKyCuoi = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("BCTONKHO_getSLTonKyCuoi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)).Value = _month;
                cmd.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)).Value = _year;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                slTonKyCuoi = (int)cmd.ExecuteScalar();
                conn.Close();
                return slTonKyCuoi;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return slTonKyCuoi;
            }
        }

        public int getSLXuat(string _maSP, int _month, int _year)
        {
            int slXuat = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("BCTONKHO_getSLXuat", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)).Value = _month;
                cmd.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)).Value = _year;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                slXuat = (int)cmd.ExecuteScalar();
                conn.Close();
                return slXuat;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return slXuat;
            }
        }
    }
}
