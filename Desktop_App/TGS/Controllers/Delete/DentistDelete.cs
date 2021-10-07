using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Delete {
    class DentistDelete {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();

        public void Dentist(string id) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"DELETE FROM TB_DENTISTS WHERE CRO_DENTIST = '{id}';";
                query.ExecuteNonQuery();

                dbConn.Disconnect();
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao deletar o registro do dentista!", false);
            }
        }
    }
}