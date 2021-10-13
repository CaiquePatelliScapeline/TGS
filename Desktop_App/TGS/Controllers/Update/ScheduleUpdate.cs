﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;
using TGS.Controllers.Main;

namespace TGS.Controllers.Update {
    class ScheduleUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();

        public void ScheduleUpdating(string cpfPatient, string dateSchedule,string timeSchedule, int oldId, string procedureTitle) {
            if (validateController.CPF(cpfPatient) && validateController.Date(dateSchedule) && validateController.Time(timeSchedule)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 0, CPF_EMPLOYEE = '{Session.CPF}', CPF_PATIENT = null, ID_PROCEDURE = null WHERE ID_CONSULT = {oldId};";
                    query.ExecuteNonQuery();
                    query.CommandText = $"SELECT ID_PROCEDURE FROM TB_PROCEDURES WHERE PROCEDURE_TITLE = '{procedureTitle}'";
                    reader = query.ExecuteReader();
                    reader.Read();
                    int idProcedure = int.Parse($"{reader["ID_PROCEDURE"]}");
                    reader.Close();

                    query.CommandText = $"UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 1, CPF_EMPLOYEE = '{Session.CPF}', CPF_PATIENT = '{cpfPatient}', ID_PROCEDURE = {idProcedure} WHERE DATE_SCHEDULE = '{dateSchedule}' AND TIME_SCHEDULE = '{timeSchedule}';";
                    query.ExecuteNonQuery();
                } catch (SqlException e) {
                    MyMsgBox.Show("Erro", "Falha ao atualizar a consulta!", false);
                }
            } else {
                MyMsgBox.Show("Erro", "Dados Inválidos!", false);
            }
        }
    }
}
