using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TGS.dataBase {
    class ProceduresRegistration {
        
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        MyMsgBox MyMsgBox = new MyMsgBox();

        public void ProcedureRegistration(string procedureTitle) {
            //query.CommandText = "INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES (@procedureTitle)";
            //query.Parameters.AddWithValue("@procedureTitle", procedureTitle);
            query.CommandText = $"INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('{procedureTitle}')";
            try {
                query.Connection = dbConn.Connect();
                query.ExecuteNonQuery();
                dbConn.Disconnect();
                MyMsgBox.Show("Success", "Procedimento cadastrado com sucesso!", false);
            } catch(SqlException e) {
                MyMsgBox.Show("Error", "Falha no cadastro do procedimento!", false);
            }
        }
    }
}
