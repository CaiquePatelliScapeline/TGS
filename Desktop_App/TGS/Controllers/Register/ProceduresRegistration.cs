using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TGS.Model;
using TGS.Views;
using TGS.Controllers.Main;

namespace TGS.Controllers.Register {
    class ProceduresRegistration {
        
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();

        public void ProcedureRegistration(string procedureTitle) {
            try {
                query.CommandText = $"INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('{validateController.ToTitleCase(procedureTitle)}')";
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
