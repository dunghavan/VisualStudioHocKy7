using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;


namespace DAO
{
    public class HoaDonDAO:DBConnection
    {
        public bool Update_HoaDon(string _maHD, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            try
            {
                string store = "HOADON_UPDATE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NChar, 10)).Value = _maHD;
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
                return false;
            }
        }

        public bool Delete_HoaDon(string _maHD)
        {
            try
            {
                string store = "HOADON_DELETE";
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
                return false;
            }
        }
        public bool Insert_HoaDon(string _maHD, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, string _ghiChu)
        {
            conn.Close();
            try
            {
                string store = "HOADON_INSERT";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NVarChar, 10)).Value = _maHD;
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
                return false;
            }
        }

        public DataTable Search_HoaDon(string _maHD, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien)
        {
            try
            {
                string store = "HOADON_SEARCH";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maHD", SqlDbType.NVarChar, 10));
                
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
                return null;
            }
        }

        public DataTable Load_DSHoaDon()
        {
            try
            {
                string store = "HOADON_LAYDS";
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

        

        public string KT_maHD(string _maHD)
        {
            string kq;
            try
            {
                string store = "hoadon_ktmaHD";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NVarChar, 10)).Value = _maHD;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kq = dr["MaHD"].ToString();

                }
                else
                {
                    kq = null;
                }
                //SqlParameter ktma = cmd.Parameters.Add("@maddh", SqlDbType.VarChar,10);
                //kq = ktma.Value.ToString();

                //conn.Close();

                return kq;
            }
            catch (Exception e)
            {
                conn.Close();
                kq = "không connect duoc";
                return kq;
            }
        }

        public bool Update_TongTienHD(string _maHD, int _tongTien)
        {
            try
            {
                string store = "hoadon_update_tongtien";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.NVarChar, 10)).Value = _maHD;

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
                return false;
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
                return null;
            }
        }
    
    }
}
