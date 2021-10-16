using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Register {
    public class ProceduresRegistration {
        
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();
        StatusController statusController = new StatusController();

        public bool ProcedureRegistration(string procedureTitle, bool testing = false) {
            try {
                query.CommandText = $"INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('{validateController.ToTitleCase(procedureTitle)}')";
                query.Connection = dbConn.Connect();
                query.ExecuteNonQuery();
                dbConn.Disconnect();

                if (!testing) statusController.Created();
                return true;
            } catch(SqlException e) {
                if (!testing) statusController.NonCreated();
                return false;
            }
        }
    }
}
