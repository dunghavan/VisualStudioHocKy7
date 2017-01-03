using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using log4net;
using log4net.Core;

namespace DAO
{
    public class DBConnection
    {
        public static readonly ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected SqlConnection conn;
        public DBConnection()
        {
            string stringConnection = @"Data Source=DESKTOP-RRRGOKE;Initial Catalog=QuanLiCuaHangHoa;Integrated Security=True";
            conn = new SqlConnection(stringConnection);
        }
    }
}