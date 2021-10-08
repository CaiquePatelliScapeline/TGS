using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Update {
    class ScheduleUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();

        public void ScheduleUpdating(string cpfEmployee, string cpfPatient, string dateSchedule,string timeSchedule, int oldId, int idProcedure) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 0, CPF_EMPLOYEE = '{cpfEmployee}', CPF_PATIENT = null, ID_PROCEDURE = null WHERE ID_CONSULT = {oldId};";
                reader = query.ExecuteReader();
                reader.Read();
                reader.Close();

                query.CommandText = $"UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 1, CPF_EMPLOYEE = '{cpfEmployee}', CPF_PATIENT = '{cpfPatient}', ID_PROCEDURE = {idProcedure} WHERE DATE_SCHEDULE = '{dateSchedule}' AND TIME_SCHEDULE = '{timeSchedule}';";
                reader = query.ExecuteReader();
                reader.Read();
                reader.Close();
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao atualizar a consulta!", false);
            }
        }
    }
}
