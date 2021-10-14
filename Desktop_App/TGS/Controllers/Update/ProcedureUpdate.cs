using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Update {
    class ProcedureUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();
        StatusController statusController = new StatusController();

        public void Procedure(int id, string title) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"UPDATE TB_PROCEDURES SET PROCEDURE_TITLE = '{validateController.ToTitleCase(title)}' WHERE ID_PROCEDURE = {id};";
                query.ExecuteNonQuery();

                dbConn.Disconnect();
                statusController.Updated();
            } catch (SqlException e) {
                statusController.NonUpdated();
            }
        }
    }
}