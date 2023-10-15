using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMARTLEARN.Model
{
    public class Host
    {
        public static string ConnectionString = "datasource=localhost;port=3306;Initial Catalog=smartlearn;username=root;password=";

        public static MySqlConnection connection = new MySqlConnection(ConnectionString);
    }
}
