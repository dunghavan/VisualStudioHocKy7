using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;


namespace DAO
{
    public class DonDatHangDAO : DBConnection
    {
        public bool Update_DonDatHang(string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, DateTime _ngayGiao, string _ghiChu)
        {
            try
            {
                string store = "DONDATHANG_UPDATE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.DateTime, 10)).Value = _ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NVarChar, 10)).Value = _maNV;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.NVarChar, 100)).Value = _maKH;
                cmd.Parameters.Add(new SqlParameter("@tongTien", SqlDbType.Int, 100)).Value = _tongTien;
                cmd.Parameters.Add(new SqlParameter("@ngayGiaodukien", SqlDbType.DateTime, 10)).Value = _ngayGiao;
                cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100)).Value = _ghiChu;



                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                conn.Close();
                return true;
            }
            catch (Exception e)
            {

                string s = e.Message;
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                return false;
            }
        }

        public bool Update_TongTienDDH(string _maDDH, int _tongTien)
        {
            try
            {
                string store = "DONDATHANG_UPDATETONGTIEN";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;

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
    

        public bool Delete_DonDatHang(string _maDDH)
        {
            try
            {
                string store = "DONDATHANG_DELETE";
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

        public bool Insert_DonDatHang(string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, DateTime _ngayGiao, string _ghiChu)
        {
            try
            {
                string store = "DONDATHANG_INSERT";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.VarChar, 10)).Value = _maDDH;
                cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date, 10)).Value = _ngayLap;
                cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NVarChar, 10)).Value = _maNV;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.NVarChar, 10)).Value = _maKH;
                cmd.Parameters.Add(new SqlParameter("@tongTien", SqlDbType.Int, 100)).Value = _tongTien;
                cmd.Parameters.Add(new SqlParameter("@ngayGiaoDuKien", SqlDbType.DateTime, 10)).Value = _ngayGiao;
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
        //public bool Insert_DonDatHang( DateTime _ngayLap, string _maNV, string _maKH, double _tongTien, DateTime _ngayGiao, string _ghiChu)
        //{
        //    OpenConnect();
        //    string store = "DONDATHANG_INSERT";
        //    sqlCommand = new SqlCommand(store, connect);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;

        //    sqlCommand.Parameters.Add(new SqlParameter("@ngaylap", _ngayLap));
        //    sqlCommand.Parameters.Add(new SqlParameter("@manv", _maNV));
        //    sqlCommand.Parameters.Add(new SqlParameter("@makh", _maKH));
        //    sqlCommand.Parameters.Add(new SqlParameter("@tongtien", _tongTien));
        //    sqlCommand.Parameters.Add(new SqlParameter("@ngaygiao", _ngayGiao));
        //    sqlCommand.Parameters.Add(new SqlParameter("@ghichu", _ghiChu));

        //    sqlCommand.ExecuteNonQuery();
        //    CloseConnect();
        //    return true;
        //}

        public DataTable Search_DonDatHang(string _maDDH, DateTime _ngayLap, string _maNV, string _maKH, DateTime _ngayGiao, double _tongTien)
        {
            try
            {
                string store = "DONDATHANG_SEARCH";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maDDH", SqlDbType.NChar, 50));
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
            //OpenConnect();
            //DataTable data = new DataTable();
            //string store = "DONDATHANG_TIMKIEM";
            //sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
            //sqlCommand.Parameters.Add(new SqlParameter("@maddh", _maDDH));
            //sqlCommand.Parameters.Add(new SqlParameter("@ngayLap", _ngayLap));
            //sqlCommand.Parameters.Add(new SqlParameter("@manv", _maNV));
            //sqlCommand.Parameters.Add(new SqlParameter("@makh", _maKH));
            //sqlCommand.Parameters.Add(new SqlParameter("@ngaygiaodukien", _ngayGiao));
            //sqlCommand.Parameters.Add(new SqlParameter("@tongtien", _tongTien));


            //sqlAdapter = new SqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(data);
            //CloseConnect();
            //return data;
        }

        public DataTable Load_DSDonDatHang()
        {
            try
            {
                string store = "DONDATHANG_LAYDS";
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
        public DataTable Load_DSDonDatHang_TheoMaDDH()
        {
            try
            {
                string store = "DONDATHANG_LAYDSmaddh";
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

        public int KTCongNo(string _maKH)
        {
            int kq;
            try
            {
                string store = "CONGNO_LAYCONGNO";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.NVarChar, 10)).Value=_maKH;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kq = int.Parse(dr["NoKyCuoi"].ToString());
                    
                }

                //SqlParameter no = cmd.Parameters.Add("@NoKyCuoi",SqlDbType.Int);
                //kq = (int)no.Value;
                else
                {
                    kq = -1;
                }
                return kq;
                
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                kq = -1;
                return kq;
            }  
        }

        public string KT_maDDH(string _maDDH)
        {
            string kq;
            try
            {
                string store = "dondathang_ktmaDDH";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kq = dr["MaDDH"].ToString();

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
                Console.WriteLine("Lỗi lớp DAO: " + e.Message);
                kq = "không connect duoc";
                return kq;
            }
        }

        
        


    }
}

    
