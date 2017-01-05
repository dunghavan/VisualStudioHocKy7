using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnection
    {
        protected SqlConnection conn;
        public DBConnection()
        {
            string stringConnection = @"Data Source=DESKTOP-RRRGOKE;Initial Catalog=QuanLiCuaHangHoa;Integrated Security=True";
            try
            {
                conn = new SqlConnection(stringConnection);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                System.Diagnostics.Debug.WriteLine(e.InnerException);
            }
        }
    }
}
