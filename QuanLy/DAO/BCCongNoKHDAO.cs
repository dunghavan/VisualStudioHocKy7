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
    public class BCCongNoKHDAO : DBConnection
    {
        public BCCongNoKHDAO() : base() { }
        
        public bool addBaoCao(BCCongNoKH _baoCao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCCONGNOKH_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date)).Value = _baoCao.ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value= _baoCao.maKH;
                cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.VarChar, 10)).Value = _baoCao.maNV;
                cmd.Parameters.Add(new SqlParameter("@noKyDau", SqlDbType.Int)).Value = _baoCao.noKyDau;
                cmd.Parameters.Add(new SqlParameter("@phatSinh", SqlDbType.Int)).Value = _baoCao.phatSinh;
                cmd.Parameters.Add(new SqlParameter("@noKyCuoi", SqlDbType.Int)).Value = _baoCao.noKyCuoi;
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

        public bool deleteBaoCao(string _ngayLap, string _maKH)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCCONGNOKH_Del", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date)).Value = _ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value = _maKH;

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

        public bool updateBaoCao(BCCongNoKH _baoCao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BCCONGNOKH_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date)).Value = _baoCao.ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value = _baoCao.maKH;
                cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.VarChar, 10)).Value = _baoCao.maNV;
                cmd.Parameters.Add(new SqlParameter("@noKyDau", SqlDbType.Int)).Value = _baoCao.noKyDau;
                cmd.Parameters.Add(new SqlParameter("@phatSinh", SqlDbType.Int)).Value = _baoCao.phatSinh;
                cmd.Parameters.Add(new SqlParameter("@noKyCuoi", SqlDbType.Int)).Value = _baoCao.noKyCuoi;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 10)).Value = _baoCao.ghiChu;

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
                SqlCommand cmd = new SqlCommand("BCCONGNOKH_getAll", conn);
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

        public DataTable searchPhieuChi(string maPhieuChi, string ngayLap)
        {
            return null;
        }
        public int getNoKyCuoi(string maKH, int month, int year)
        {
            int _noKyDau = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("BCCONGNOKH_getNoKyCuoi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value = maKH;
                cmd.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)).Value = month;
                cmd.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)).Value = year;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                _noKyDau = (int)cmd.ExecuteScalar();
                conn.Close();
                return _noKyDau;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return _noKyDau;
            }
        }
    }
}
