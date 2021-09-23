using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TGS.dataBase {
    class DBConnection {
        
        public DBConnection() {
            dbConn.ConnectionString = dbRoute;
        }

        // Classes
        SqlConnection dbConn = new SqlConnection();

        // Fields
        private string dbRoute = @"Data Source=LENOVO-AMD-GL\SQLEXPRESS;Initial Catalog=DB_TGS;Integrated Security=True";

        public SqlConnection Connect() {
            if (dbConn.State == System.Data.ConnectionState.Closed) {
                dbConn.Open();            
            }
            return dbConn;
        }

        public void Disconnect() {
            if (dbConn.State == System.Data.ConnectionState.Open) {
                dbConn.Close();
            }
        }
    }
}
