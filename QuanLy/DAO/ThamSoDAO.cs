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
    public class ThamSoDAO : DBConnection
    {
        public ThamSoDAO() : base() { }

        public bool updateThamSo(ThamSo _thamSo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("THAMSO_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tenThamSo", SqlDbType.NVarChar, 20)).Value = _thamSo.tenThamSo;
                cmd.Parameters.Add(new SqlParameter("@giaTri", SqlDbType.Int)).Value = _thamSo.giaTri;

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

        public DataTable getAllThamSo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("THAMSO_getAll", conn);
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
