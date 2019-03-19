using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Demo_v1_1
{
    class DBConnect
    {
        public bool DBCon() {
            try
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MedicineCMS;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                //cnn.Close();
                return true;
            }
            catch(Exception) {
                    return false;
                    }
            }
    }
}
