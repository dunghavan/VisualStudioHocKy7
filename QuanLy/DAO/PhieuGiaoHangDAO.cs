using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class PhieuGiaoHangDAO : DBConnection
    {
        public bool Update_PhieuGiaoHang(string _maPGH, string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            try
            {
                string store = "PHIEUGIAOHANG_UPDATE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.DateTime, 10)).Value = _ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NVarChar, 10)).Value = _maNV;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.NVarChar, 100)).Value = _maKH;
                cmd.Parameters.Add(new SqlParameter("@tongTien", SqlDbType.Int, 100)).Value = _tongTien;

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

        public bool Delete_PhieuGiaoHang(string _maPGH)
        {
            try
            {
                string store = "PHIEUGIAOHANG_DELETE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maPGH", SqlDbType.NVarChar, 10));

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

        public bool Insert_PhieuGiaoHang(string _maPGH, string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            try
            {
                string store = "PHIEUGIAOHANG_INSERT";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.DateTime, 10)).Value = _ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NVarChar, 10)).Value = _maNV;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.NVarChar, 100)).Value = _maKH;
                cmd.Parameters.Add(new SqlParameter("@tongTien", SqlDbType.Int, 100)).Value = _tongTien;

                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _ghiChu;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 100)).Value = _maDDH;



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

        public DataTable Search_PhieuGiaoHang(string _maPGH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien)
        {
            try
            {
                string store = "PHIEUGIAOHANG_SEARCH";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maPGH", SqlDbType.NVarChar, 10));
                cmd.Parameters.Add(new SqlParameter("_maDDH", SqlDbType.NVarChar, 10));
                cmd.Parameters.Add(new SqlParameter("_ngayLap", SqlDbType.NChar, 50));
                cmd.Parameters.Add(new SqlParameter("_maNV", SqlDbType.NVarChar, 50));
                cmd.Parameters.Add(new SqlParameter("_maKH", SqlDbType.NVarChar, 15));
                cmd.Parameters.Add(new SqlParameter("_tongTien", SqlDbType.NVarChar, 100));
                cmd.Parameters.Add(new SqlParameter("_ngayGiao", SqlDbType.NVarChar, 100));
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

        public DataTable Load_DSPhieuGiaoHang()
        {
            try
            {
                string store = "PHIEUGIAOHANG_LAYDS";
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

        
        public bool Insert_PhieuGiaoHang(DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            throw new NotImplementedException();
        }

        public string KT_maPGH(string _maPGH)
        {
            string kq;
            try
            {
                string store = "phieugiaohang_ktmaPGH";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kq = dr["MaPGH"].ToString();

                }
                else
                {
                    kq = null;
                }
                //SqlParameter ktma = cmd.Parameters.Add("@maddh", SqlDbType.VarChar,10);
                //kq = ktma.Value.ToString();

                conn.Close();

                return kq;
            }
            catch (Exception e)
            {
                conn.Close();
                kq = "không connect duoc";
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return kq;
            }
        }
        public bool Update_TongTienPGH(string _maPGH, int _tongTien)
        {
            try
            {
                string store = "phieugiaohang_updatetongtien";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;

                cmd.Parameters.Add(new SqlParameter("@tongTien", SqlDbType.Int, 100)).Value = _tongTien;




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
    }
}
