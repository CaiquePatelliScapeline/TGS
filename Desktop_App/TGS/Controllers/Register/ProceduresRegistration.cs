using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Register {
    class ProceduresRegistration {
        
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();
        StatusController statusController = new StatusController();

        public void ProcedureRegistration(string procedureTitle) {
            try {
                query.CommandText = $"INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('{validateController.ToTitleCase(procedureTitle)}')";
                query.Connection = dbConn.Connect();
                query.ExecuteNonQuery();
                dbConn.Disconnect();
                statusController.Created();
            } catch(SqlException e) {
                statusController.NonCreated();
            }
        }
    }
}
