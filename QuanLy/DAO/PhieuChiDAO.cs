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
    public class PhieuChiDAO : DBConnection
    {
        public PhieuChiDAO(): base(){ }
        
        public bool addPhieuChi(PhieuChi _phieuChi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUCHI_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPC", SqlDbType.VarChar, 10)).Value = _phieuChi.maPhieuChi;
                cmd.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.Date)).Value = _phieuChi.ngayLap;
                cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.VarChar, 10)).Value = _phieuChi.maNV;
                cmd.Parameters.Add(new SqlParameter("@MaNCC", SqlDbType.VarChar, 10)).Value = _phieuChi.maNCC;
                cmd.Parameters.Add(new SqlParameter("@SoTienNo", SqlDbType.Int)).Value = _phieuChi.soTienNo;
                cmd.Parameters.Add(new SqlParameter("@SoTienChi", SqlDbType.Int)).Value = _phieuChi.soTienChi;

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

        public bool deletePhieuChi(string _maPhieuChi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUCHI_Del", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPC", SqlDbType.VarChar, 10)).Value = _maPhieuChi;

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

        public bool updatePhieuChi(PhieuChi _phieuChi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUCHI_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPC", SqlDbType.VarChar, 10)).Value = _phieuChi.maPhieuChi;
                cmd.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.Date)).Value = _phieuChi.ngayLap;
                cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.VarChar, 10)).Value = _phieuChi.maNV;
                cmd.Parameters.Add(new SqlParameter("@MaNCC", SqlDbType.VarChar, 10)).Value = _phieuChi.maNCC;
                cmd.Parameters.Add(new SqlParameter("@SoTienNo", SqlDbType.Int)).Value = _phieuChi.soTienNo;
                cmd.Parameters.Add(new SqlParameter("@SoTienChi", SqlDbType.Int)).Value = _phieuChi.soTienChi;

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

        public PhieuChi getPhieuChi(string _maPhieuChi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUCHI_getPhieuChi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuChi", SqlDbType.VarChar, 10)).Value = _maPhieuChi;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PhieuChi phieuChi = null;
                if (dr.Read())
                {
                    phieuChi = new PhieuChi();
                    phieuChi.maPhieuChi = dr["MaPC"].ToString();
                    phieuChi.ngayLap = (DateTime)dr["NgayLap"];
                    phieuChi.maNV = dr["MaNV"].ToString();
                    phieuChi.maNCC = dr["MaNCC"].ToString();
                    phieuChi.soTienNo = (int)dr["SoTienNo"];
                    phieuChi.soTienChi = (int)dr["SoTienChi"];
                }
                conn.Close();
                return phieuChi;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return null;
            }
        }

        public DataTable getAllPhieuChi()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUCHI_getAll", conn);
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
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUCHI_Search", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPC", SqlDbType.VarChar, 10)).Value = maPhieuChi;
                cmd.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.VarChar, 10)).Value = ngayLap;

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
