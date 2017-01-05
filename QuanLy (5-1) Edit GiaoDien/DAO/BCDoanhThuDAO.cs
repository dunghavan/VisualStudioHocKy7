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
    public class BCDoanhThuDAO : DBConnection
    {
        public BCDoanhThuDAO() : base() { }
        public bool addBaoCao(BCDoanhThu _baoCao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCDOANHTHU_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date)).Value = _baoCao.ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _baoCao.maSP;
                cmd.Parameters.Add(new SqlParameter("@tongChi", SqlDbType.Int)).Value = _baoCao.tongChi;
                cmd.Parameters.Add(new SqlParameter("@phatSinh", SqlDbType.Int)).Value = _baoCao.phatSinh;
                cmd.Parameters.Add(new SqlParameter("@tongThu", SqlDbType.Int)).Value = _baoCao.tongThu;
                cmd.Parameters.Add(new SqlParameter("@loiNhuan", SqlDbType.Int)).Value = _baoCao.loiNhuan;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _baoCao.ghiChu;


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

        public bool deleteBaoCao(string _ngayLap, string _maSP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCDOANHTHU_Del", conn);
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

        public bool updateBaoCao(BCDoanhThu _baoCao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCDOANHTHU_Update2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date)).Value = _baoCao.ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _baoCao.maSP;
                cmd.Parameters.Add(new SqlParameter("@phatSinh", SqlDbType.Int)).Value = _baoCao.phatSinh;
                cmd.Parameters.Add(new SqlParameter("@loiNhuan", SqlDbType.Int)).Value = _baoCao.loiNhuan;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _baoCao.ghiChu;

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


        public DataTable getAllBaoCao()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCDOANHTHU_getAll", conn);
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
        public int getTongChi(string _maSP, int _month, int _year)
        {
            int tongChi = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("BCDOANHTHU_getTongChi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)).Value = _month;
                cmd.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)).Value = _year;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                tongChi = (int)cmd.ExecuteScalar();
                conn.Close();
                return tongChi;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return tongChi;
            }
        }
        public int getTongThu(string _maSP, int _month, int _year)
        {
            int tongThu = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("BCDOANHTHU_getTongThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)).Value = _month;
                cmd.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)).Value = _year;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                tongThu = (int)cmd.ExecuteScalar();
                conn.Close();
                return tongThu;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return tongThu;
            }
        }
        public DataTable getTongChi_TongThu(string _maSP, int _month, int _year)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCDOANHTHU_getTongChi_TongThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10)).Value = _maSP;
                cmd.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)).Value = _month;
                cmd.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)).Value = _year;

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
    }
}
