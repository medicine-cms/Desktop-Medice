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
            //string connetionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MedicineCMS;Integrated Security=True";
            string connectionString = @"Data Source=pharma-azuresqlserver.database.windows.net;Initial Catalog=MedicineCMS;User ID=pharma;Password=Ceng!1234;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnn = new SqlConnection(connectionString);
            return cnn;
        } // Connect to Database
    }
}
