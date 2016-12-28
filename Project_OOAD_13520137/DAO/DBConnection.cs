using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnection
    {
        protected SqlConnection conn;
        public DBConnection()
        {
            string stringConnection = @"Data Source=DESKTOP-RRRGOKE;Initial Catalog=QuanLiCuaHangHoa;Integrated Security=True";
            conn = new SqlConnection(stringConnection);
        }
    }
}