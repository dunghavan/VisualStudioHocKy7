using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CT_PhieuGiaoHangDAO:DBConnection
    {
        public bool Update_CT_PhieuGiaoHang(string _maPGH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                string store = "CT_PHIEUGIAOHANG_UPDATE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;
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
                return false;
            }
        }

        public bool Delete_CT_PhieuGiaoHang(string _maPGH, string _maSP)
        {
            try
            {
                string store = "CT_PHIEUGIAOHANG_DELETE";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;
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
                return false;
            }
        }

        public bool Delete_CT_PhieuGiaoHangThepMaPGH(string _maPGH)
        {
            try
            {
                string store = " ct_phieugiaohang_deletetheomapgh";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;
                



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

        public bool Insert_CT_PhieuGiaoHang(string _maPGH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                string store = "CT_PHIEUGIAOHANG_INSERT";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;
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
                return false;
            }
        }

        public DataTable Search_CT_PhieuGiaoHang(string _maPGH, string _maSP, int _soLuong, double _thanhTien, string _ghiChu)
        {
            try
            {
                string store = "CT_PHIEUGIAOHANG_SEARCH";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maPGH", SqlDbType.NVarChar, 10));
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
                return null;
            }
        }

        public DataTable Load_DSCT_PhieuGiaoHang()
        {
            try
            {
                string store = "CT_PHIEUGIAOHANG_LAYDS";
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

        public int KTSoLuongTheoMaSP(string _maDDH, string _maSP)
        {
            int kq;
            try
            {
                string store = "CT_DONDATHANG_LAYSL_THEOMASP";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maDDH", SqlDbType.NVarChar, 10));
                cmd.Parameters.Add(new SqlParameter("_maSP", SqlDbType.NVarChar, 10));
                if (conn.State != ConnectionState.Open)
                    conn.Open();



                SqlParameter sl = cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                kq = (int)sl.Value;

                conn.Close();
                return kq;
            }
            catch (Exception e)
            {
                conn.Close();
                kq = 0;
                return kq;
            }
        }

        public DataTable Load_DSCT_theomaPGH(string _maPGH)
        {
            try
            {
                string kq;
                string store = "ct_phieugiaohang_laydstheomapgh";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;


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

        public int KT_SoLuong_TheoDDH(string _maDDH, string _maSP)
        {
            int kq;
            try
            {
                string store = "phieugiaohang_ktsoluong_ddh";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.NVarChar, 10)).Value = _maSP;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kq = int.Parse(dr["SoLuong"].ToString());

                }
                else
                {
                    kq = -1;
                }
                //SqlParameter ktma = cmd.Parameters.Add("@maddh", SqlDbType.VarChar,10);
                //kq = ktma.Value.ToString();

                conn.Close();

                return kq;
            }
            catch (Exception e)
            {
                conn.Close();
                kq = -1;
                return kq;
            }
        }
        public int KT_SoLuong_TheoMaSP_CTPGH(string _maPGH, string _maSP)
        {
            int kq=0;
            try
            {
                string store = "ct_phieugiaohang_laysl_theomasp";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPGH", SqlDbType.NVarChar, 10)).Value = _maPGH;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.NVarChar, 10)).Value = _maSP;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kq = int.Parse(dr["SoLuong"].ToString());

                }
                else
                {
                    kq = -1;
                }
                //SqlParameter ktma = cmd.Parameters.Add("@maddh", SqlDbType.VarChar,10);
                //kq = ktma.Value.ToString();

                conn.Close();

                return kq;
            }
            catch (Exception e)
            {
                conn.Close();
                kq = -1;
                return kq;
            }
        }

        public int KT_SoLuong_DaGiao(string _maDDH, string _maSP)
        {

            int kq = 0;
            try
            {
                conn.Close();
                string store = "ct_phieugiaohang_ktsldagiao";
                SqlCommand cmd = new SqlCommand(store, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDDH", SqlDbType.NVarChar, 10)).Value = _maDDH;
                cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.NVarChar, 10)).Value = _maSP;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                kq = (int)cmd.ExecuteScalar();

                //SqlParameter ktma = cmd.Parameters.Add("@maddh", SqlDbType.VarChar,10);
                //kq = ktma.Value.ToString();
                conn.Close();

                return kq;
            }
            catch (Exception e)
            {
                conn.Close();
                kq = -1;
                return kq;
            }
        }



    }
}
