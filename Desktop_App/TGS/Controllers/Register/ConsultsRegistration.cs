using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Register {
    class ConsultsRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();
        StatusController statusController = new StatusController();

        public void ConsultOpen(string croDentist, string dateConsult, string timeConsult) {
            if (validateController.CRO(croDentist) && validateController.Date(dateConsult) && validateController.Time(timeConsult)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"INSERT INTO TB_CONSULTS (CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, STATUS_SCHEDULE) VALUES ('{croDentist}', '{dateConsult}', '{timeConsult}', 0);";
                    query.ExecuteNonQuery();

                    dbConn.Disconnect();

                    statusController.Created();
                } catch (SqlException e) {
                    statusController.NonCreated();
                }
            } else {
                statusController.NotAcceptable();
            }
        }

        public void ConsultRegistration(string cpfPatient, int idProcedure, int idConsulta) {
            if (validateController.CPF(cpfPatient)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 1, CPF_EMPLOYEE = '{Session.CPF}', CPF_PATIENT = '{cpfPatient}', ID_PROCEDURE = {idProcedure} WHERE ID_CONSULT = {idConsulta};";
                    query.ExecuteNonQuery();

                    dbConn.Disconnect();

                    statusController.Created();
                } catch (SqlException e) {
                    statusController.NonCreated();
                }
            } else {
                statusController.NotAcceptable();
            }
        }
    }
}
