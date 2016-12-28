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
    public class NhanVienDAO: DBConnection
    {
        public NhanVienDAO(): base(){ }

        private SqlParameter _maNV, _hoTen, _namSinh, _gioiTinh, _soDT, _email, _username, _password, _maLoaiNV;
        
        public bool addNhanVien(NhanVien _nhanVien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHANVIEN_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maNV = cmd.Parameters.Add(new SqlParameter("@maNhanVien", SqlDbType.VarChar, 10));
                _hoTen = cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.NVarChar, 50));
                _namSinh = cmd.Parameters.Add(new SqlParameter("@namSinh", SqlDbType.Int));
                _gioiTinh = cmd.Parameters.Add(new SqlParameter("@gioiTinh", SqlDbType.Bit));
                _soDT = cmd.Parameters.Add(new SqlParameter("@soDT", SqlDbType.VarChar, 15));
                _email = cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 50));
                _username = cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 50));
                _password = cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 50));
                _maLoaiNV= cmd.Parameters.Add(new SqlParameter("@maLoaiNV", SqlDbType.VarChar, 20));

                //Get value to parameters:
                _maNV.Value = _nhanVien.maNhanVien;
                _hoTen.Value = _nhanVien.hoTen;
                _namSinh.Value = _nhanVien.namSinh;
                _gioiTinh.Value = _nhanVien.gioiTinh;
                _soDT.Value = _nhanVien.soDienThoai;
                _email.Value = _nhanVien.email;
                _username.Value = _nhanVien.username;
                _password.Value = _nhanVien.password;
                _maLoaiNV.Value = _nhanVien.maLoaiNV;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return false;
            }
        }

        public bool deleteNhanVien(string _maNhanVien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHANVIEN_Del", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maNV = cmd.Parameters.Add(new SqlParameter("@maNhanVien", SqlDbType.VarChar, 10));
                _maNV.Value = _maNhanVien;

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

        public bool updateNhanVien(NhanVien _nhanVien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHANVIEN_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maNV = cmd.Parameters.Add(new SqlParameter("@maNhanVien", SqlDbType.VarChar, 10));
                _hoTen = cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.NVarChar, 50));
                _namSinh = cmd.Parameters.Add(new SqlParameter("@namSinh", SqlDbType.Int));
                _gioiTinh = cmd.Parameters.Add(new SqlParameter("@gioiTinh", SqlDbType.Bit));
                _soDT = cmd.Parameters.Add(new SqlParameter("@soDT", SqlDbType.VarChar, 15));
                _email = cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 50));
                _username = cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 50));
                _password = cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 50));
                _maLoaiNV = cmd.Parameters.Add(new SqlParameter("@maLoaiNV", SqlDbType.VarChar, 20));

                //
                _maNV.Value = _nhanVien.maNhanVien;
                _hoTen.Value = _nhanVien.hoTen;
                _namSinh.Value = _nhanVien.namSinh;
                _gioiTinh.Value = _nhanVien.gioiTinh;
                _soDT.Value = _nhanVien.soDienThoai;
                _email.Value = _nhanVien.email;
                _username.Value = _nhanVien.username;
                _password.Value = _nhanVien.password;
                _maLoaiNV.Value = _nhanVien.maLoaiNV;

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

        public NhanVien getNhanVien(string _maNhanVien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHANVIEN_getNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maNV = cmd.Parameters.Add(new SqlParameter("@maNhanVien", SqlDbType.VarChar, 10));
                _maNV.Value = _maNhanVien;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                NhanVien nhanVien = null;
                if(dr.Read())
                {
                    nhanVien = new NhanVien();
                    nhanVien.maNhanVien = dr["MaNV"].ToString();
                    nhanVien.hoTen = dr["HoTen"].ToString();
                    nhanVien.namSinh = (int)dr["NamSinh"];
                    nhanVien.gioiTinh = (int)dr["GioiTinh"] == 1 ? true : false;
                    nhanVien.soDienThoai = dr["SoDT"].ToString();
                    nhanVien.email = dr["Email"].ToString();
                    nhanVien.username = dr["Username"].ToString();
                    nhanVien.password = dr["Password"].ToString();
                }
                conn.Close();
                return nhanVien;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Lỗi: " + e.Message);
                return null;
            }
        }

        public DataTable getAllNhanVien()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHANVIEN_getAll", conn);
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

        public DataTable searchNhanVien(string maNhanVien, string hoTen, int namSinh, string maLoaiNV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NHANVIEN_Search", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                _maNV = cmd.Parameters.Add(new SqlParameter("@maNhanVien", SqlDbType.VarChar, 10));
                _hoTen = cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.NVarChar, 50));
                _namSinh = cmd.Parameters.Add(new SqlParameter("@namSinh", SqlDbType.Int));
                _maLoaiNV = cmd.Parameters.Add(new SqlParameter("@maLoaiNV", SqlDbType.VarChar, 20));

                //
                _maNV.Value = maNhanVien;
                _hoTen.Value = hoTen;
                _namSinh.Value = namSinh;
                _maLoaiNV.Value = maLoaiNV;

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
