using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Delete {
    class ConsultDelete {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        StatusController statusController = new StatusController();

        public void Schedule(int id) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"DELETE FROM TB_CONSULTS WHERE ID_CONSULT = {id};";
                query.ExecuteNonQuery();

                dbConn.Disconnect();
                statusController.Deleted();
            } catch (SqlException e) {
                statusController.NonDeleted();
            }
        }

        public void Consult(int id) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 0, CPF_EMPLOYEE = '{Session.CPF}', CPF_PATIENT = NULL, ID_PROCEDURE = NULL WHERE ID_CONSULT = {id};";
                query.ExecuteNonQuery();

                dbConn.Disconnect();
                statusController.Deleted();
            } catch (SqlException e) {
                statusController.NonDeleted();
            }
        }
    }
}