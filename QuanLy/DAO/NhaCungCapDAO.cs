using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO : DBConnection
    {
        public NhaCungCapDAO() : base() { }
        private SqlParameter _maNCC, _TenNCC, _diaChi, _soDT, _ghiChu, _isActive;
        public bool addNhaCungCap(NhaCungCap _nhacungcap)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("NHACUNGCAP_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maNCC = cmd.Parameters.Add(new SqlParameter("@maNCC", SqlDbType.VarChar, 10));
                _TenNCC = cmd.Parameters.Add(new SqlParameter("@ten", SqlDbType.NVarChar, 50));
                _diaChi = cmd.Parameters.Add(new SqlParameter("@diaChi", SqlDbType.NVarChar, 50));
                _soDT = cmd.Parameters.Add(new SqlParameter("@soDT", SqlDbType.VarChar, 15));
                _ghiChu = cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100));
                _isActive = cmd.Parameters.Add(new SqlParameter("@isActive", SqlDbType.Bit));

                //Get value to parameters:
                _maNCC.Value = _nhacungcap.MaNCC;
                _TenNCC.Value = _nhacungcap.TenNCC;
                _diaChi.Value = _nhacungcap.DiaChi;
                _soDT.Value = _nhacungcap.SoDT;
                _ghiChu.Value = _nhacungcap.GhiChu;
                _isActive.Value = _nhacungcap.IsActive;

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
        public bool deleteNhaCungCap(string _maNhaCungCap)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHACUNGCAP_DELETE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maNCC = cmd.Parameters.Add(new SqlParameter("@MaNCC", SqlDbType.VarChar, 10));
                _maNCC.Value = _maNhaCungCap;

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
        public bool updateNhaCungCap(NhaCungCap _nhacungcap)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHACUNGCAP_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maNCC = cmd.Parameters.Add(new SqlParameter("@maNCC", SqlDbType.VarChar, 10));
                _TenNCC = cmd.Parameters.Add(new SqlParameter("@ten", SqlDbType.NVarChar, 50));
                _diaChi = cmd.Parameters.Add(new SqlParameter("@diaChi", SqlDbType.NVarChar, 50));
                _soDT = cmd.Parameters.Add(new SqlParameter("@soDT", SqlDbType.VarChar, 15));
                _ghiChu = cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100));
                _isActive = cmd.Parameters.Add(new SqlParameter("@isActive", SqlDbType.Bit));

                //
                _maNCC.Value = _nhacungcap.MaNCC;
                _TenNCC.Value = _nhacungcap.TenNCC;
                _diaChi.Value = _nhacungcap.DiaChi;
                _soDT.Value = _nhacungcap.SoDT;
                _ghiChu.Value = _nhacungcap.GhiChu;
                _isActive.Value = _nhacungcap.IsActive;

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
        public NhaCungCap getNhaCungCap(string _manhacungcap)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHACUNGCAP_getNCC", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maNCC", SqlDbType.VarChar, 10));
                _maNCC.Value = _manhacungcap;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                NhaCungCap nhacungcap = null;
                if (dr.Read())
                {
                    nhacungcap = new NhaCungCap();
                    nhacungcap.MaNCC = dr["MaNCC"].ToString();
                    nhacungcap.TenNCC = dr["Ten"].ToString();
                    nhacungcap.DiaChi = dr["DiaChi"].ToString();
                    nhacungcap.SoDT = dr["SoDT"].ToString();
                    nhacungcap.GhiChu = dr["Email"].ToString();
                }
                conn.Close();
                return nhacungcap;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return null;
            }
        }
        public DataTable getAllNhaCungCap()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHACUNGCAP_getAll", conn);
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

        public DataTable searchNCC(string maNCC, string tenNCC)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHACUNGCAP_Search", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maNCC", SqlDbType.VarChar, 10)).Value = maNCC;
                cmd.Parameters.Add(new SqlParameter("@tenNCC", SqlDbType.NVarChar, 50)).Value = tenNCC;


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
