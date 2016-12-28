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
    public class SanPhamDAO : DBConnection
    {
        public SanPhamDAO(): base(){ }
        private SqlParameter _maSP, _tenSP, _donVi, _donGia, _ghiChu, _maLoaiSP;
        public bool addSanPham(SanPham _sanpham)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SANPHAM_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maSP = cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10));
                _tenSP = cmd.Parameters.Add(new SqlParameter("@tenSP", SqlDbType.NVarChar, 50));
                _donVi = cmd.Parameters.Add(new SqlParameter("@donVi", SqlDbType.NVarChar, 20));
                _donGia = cmd.Parameters.Add(new SqlParameter("@donGia", SqlDbType.Int));
                _ghiChu = cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100));
                _maLoaiSP = cmd.Parameters.Add(new SqlParameter("@maLoaiSP", SqlDbType.NVarChar, 20));

                //Get value to parameters:
                _maSP.Value = _sanpham.MaSP;
                _tenSP.Value = _sanpham.TenSP;
                _donVi.Value = _sanpham.DonVi;
                _donGia.Value = _sanpham.DonGia;
                _ghiChu.Value = _sanpham.GhiChu;
                _maLoaiSP.Value = _sanpham.MaLoaiSP;

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
        public bool deleteSanPham(string _masp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SANPHAM_DELETE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maSP = cmd.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.VarChar, 10));
                _maSP.Value = _masp;

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
        public bool updateSanPham(SanPham _sanpham)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SANPHAM_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maSP = cmd.Parameters.Add(new SqlParameter("@maSP", SqlDbType.VarChar, 10));
                _tenSP = cmd.Parameters.Add(new SqlParameter("@tenSP", SqlDbType.NVarChar, 50));
                _donVi = cmd.Parameters.Add(new SqlParameter("@donVi", SqlDbType.NVarChar, 20));
                _donGia = cmd.Parameters.Add(new SqlParameter("@donGia", SqlDbType.Int));
                _ghiChu = cmd.Parameters.Add(new SqlParameter("@ghiChu", SqlDbType.NVarChar, 100));
                _maLoaiSP = cmd.Parameters.Add(new SqlParameter("@maLoaiSP", SqlDbType.NVarChar, 20));

                //Get value to parameters:
                _maSP.Value = _sanpham.MaSP;
                _tenSP.Value = _sanpham.TenSP;
                _donVi.Value = _sanpham.DonVi;
                _donGia.Value = _sanpham.DonGia;
                _ghiChu.Value = _sanpham.GhiChu;
                _maLoaiSP.Value = _sanpham.MaLoaiSP;

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
        public SanPham getSanPham(string _masp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SANPHAM_getSANPHAM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("_maSP", SqlDbType.VarChar, 10));
                _maSP.Value = _masp;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                SanPham sanpham = null;
                if (dr.Read())
                {
                    sanpham = new SanPham();
                    sanpham.MaSP = dr["MaSP"].ToString();
                    sanpham.TenSP = dr["TenSP"].ToString();
                    sanpham.DonVi = dr["DonVi"].ToString();
                    sanpham.DonGia = Convert.ToInt32(dr["DonVi"]);
                    sanpham.GhiChu = dr["GhiChu"].ToString();
                    sanpham.MaLoaiSP = dr["MaLoaiSP"].ToString();
                }
                conn.Close();
                return sanpham;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return null;
            }
        }
        public DataTable getAllSanPham()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SANPHAM_getAll", conn);
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

    }
}
