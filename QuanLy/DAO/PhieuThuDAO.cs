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
    public class PhieuThuDAO : DBConnection
    {
        public PhieuThuDAO(): base(){ }

        private SqlParameter _maPT, _ngayLap, _maNV, _maKH, _soTienNo, _soTienThu;

        public bool addPhieuThu(PhieuThu _phieuThu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUTHU_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maPT = cmd.Parameters.Add(new SqlParameter("@MaPT", SqlDbType.VarChar, 10));
                _ngayLap = cmd.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.Date));
                _maNV = cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.VarChar, 10));
                _maKH = cmd.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.VarChar, 10));
                _soTienNo = cmd.Parameters.Add(new SqlParameter("@SoTienNo", SqlDbType.Int));
                _soTienThu = cmd.Parameters.Add(new SqlParameter("@SoTienThu", SqlDbType.Int));

                //Get value to parameters:
                _maPT.Value = _phieuThu.maPhieuThu;
                _ngayLap.Value = _phieuThu.ngayLap;
                _maNV.Value = _phieuThu.maNV;
                _maKH.Value = _phieuThu.maKH;
                _soTienNo.Value = _phieuThu.soTienNo;
                _soTienThu.Value = _phieuThu.soTienThu;

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

        public bool deletePhieuThu(string _maPhieuThu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUTHU_Del", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPT", SqlDbType.VarChar, 10)).Value = _maPhieuThu;
                //_maPT.Value = _maPhieuThu;

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

        public bool updatePhieuThu(PhieuThu _phieuThu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUTHU_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maPT = cmd.Parameters.Add(new SqlParameter("@MaPT", SqlDbType.VarChar, 10));
                _ngayLap = cmd.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.Date));
                _maNV = cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.VarChar, 10));
                _maKH = cmd.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.VarChar, 10));
                _soTienNo = cmd.Parameters.Add(new SqlParameter("@SoTienNo", SqlDbType.Int));
                _soTienThu = cmd.Parameters.Add(new SqlParameter("@SoTienThu", SqlDbType.Int));

                //Get value to parameters:
                _maPT.Value = _phieuThu.maPhieuThu;
                _ngayLap.Value = _phieuThu.ngayLap;
                _maNV.Value = _phieuThu.maNV;
                _maKH.Value = _phieuThu.maKH;
                _soTienNo.Value = _phieuThu.soTienNo;
                _soTienThu.Value = _phieuThu.soTienThu;

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

        public PhieuThu getPhieuThu(string _maPhieuThu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUTHU_getPhieuThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maPT = cmd.Parameters.Add(new SqlParameter("@MaPhieuThu", SqlDbType.VarChar, 10));
                _maPT.Value = _maPhieuThu;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PhieuThu phieuThu = null;
                if (dr.Read())
                {
                    phieuThu = new PhieuThu();
                    phieuThu.maPhieuThu = dr["MaPT"].ToString();
                    phieuThu.ngayLap = (DateTime)dr["NgayLap"];
                    phieuThu.maNV = dr["MaNV"].ToString();
                    phieuThu.maKH = dr["MaKH"].ToString();
                    phieuThu.soTienNo = (int)dr["SoTienNo"];
                    phieuThu.soTienThu = (int)dr["SoTienThu"];
                }
                conn.Close();
                return phieuThu;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return null;
            }
        }

        public DataTable getAllPhieuThu()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUTHU_getAll", conn);
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

        public DataTable searchPhieuThu(string maPhieuThu, string ngayLap)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUTHU_Search", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maPT = cmd.Parameters.Add(new SqlParameter("@MaPT", SqlDbType.VarChar, 10));
                _ngayLap = cmd.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.VarChar, 10));

                //
                _maPT.Value = maPhieuThu;
                _ngayLap.Value = ngayLap.ToString();

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

        public int getTongTienNo(string _maKH)
        {
            int _tongTienNo = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUTHU_TongTienNo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value = _maKH;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                _tongTienNo = (int)cmd.ExecuteScalar();
                conn.Close();
                return _tongTienNo;
            }
            catch(Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return _tongTienNo;
            }
        }
        public int getTongTienNoTrongThang(string _maKH, int _month, int _year)
        {
            int _tongTienNoTrongThang = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("PHIEUTHU_TongTienNoTrongThang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.VarChar, 10)).Value = _maKH;
                cmd.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)).Value = _month;
                cmd.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)).Value = _year;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                _tongTienNoTrongThang = (int)cmd.ExecuteScalar();
                conn.Close();
                return _tongTienNoTrongThang;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return _tongTienNoTrongThang;
            }
        }
    }
}
