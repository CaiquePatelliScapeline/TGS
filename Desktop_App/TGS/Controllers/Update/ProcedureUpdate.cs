using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Update {
    class ProcedureUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();

        public void Procedure(int id, string title) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"UPDATE TB_PROCEDURES SET PROCEDURE_TITLE = '{title}' WHERE ID_PROCEDURE = {id};";
                query.ExecuteNonQuery();

                dbConn.Disconnect();
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao atualizar o registro do procedimento!", false);
            }
        }
    }
}