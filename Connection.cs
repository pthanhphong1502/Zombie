using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Game_băn_Zombie
{
    class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-LN09DV8A;Initial Catalog=QLDA;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
