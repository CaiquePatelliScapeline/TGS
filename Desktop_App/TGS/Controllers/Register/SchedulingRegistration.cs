using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;


namespace TGS.Controllers.Register {
    class SchedulingRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        MyMsgBox MyMsgBox = new MyMsgBox();

        public void ScheduleRegistration(string croDentist, string dataSchedule, string timeSchedule, string statusSchedule) {

            try {
                query.CommandText = $"INSERT INTO TB_SCHEDULING (CRO_DENTIST, DATE_SCHEDULE, TIME_SCHEDULE, STATUS_SCHEDULE) VALUES ('{croDentist}', '{dataSchedule}', '{timeSchedule}', {statusSchedule});";
                query.Connection = dbConn.Connect();
                query.ExecuteNonQuery();
                dbConn.Disconnect();
                MyMsgBox.Show("Success", "Agenda aberta com sucesso!", false);
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha na abertura da agenda!", false);
            }
        }
    }
}
