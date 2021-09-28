using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TGS.Model {
    class DBConnection {
        
        public DBConnection() {
            if (Environment.MachineName == "LAPTOP-2P9K4L2I") {
                dbRoute = caiqueRoute;
            } else if (Environment.MachineName == "LENOVO-AMD-GL") {
                dbRoute = gianlucaRoute;
            } else {
                //Rota não identificada
            }

            dbConn.ConnectionString = dbRoute;
        }

        // Classes
        SqlConnection dbConn = new SqlConnection(); 

        // Fields 
        private const string caiqueRoute = @"Data Source=LAPTOP-2P9K4L2I\SQLEXPRESS;Initial Catalog=DB_TGS;Integrated Security=True";
        private const string gianlucaRoute = @"Data Source=LENOVO-AMD-GL\SQLEXPRESS;Initial Catalog=DB_TGS;Integrated Security=True";
        private string dbRoute;

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
