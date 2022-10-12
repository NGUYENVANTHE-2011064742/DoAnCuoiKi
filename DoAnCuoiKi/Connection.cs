using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DoAnCuoiKi
{
    class Connection
    {
        private static string stringConnection = (@"Data Source=NGUYENVANTHE;Initial Catalog=QUANLYQUANAN;Integrated Security=True");
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
