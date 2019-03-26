using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Demo_v1_2
{
    class DBConnect
    {
        public static SqlConnection getConnection()
        {
            string connetionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MedicineCMS;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            return cnn;
        } // Connect to Database
    }
}
