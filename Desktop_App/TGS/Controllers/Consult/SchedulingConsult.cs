using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;


namespace TGS.Controllers.Consult {
    class SchedulingConsult {
        // Classes
        SqlCommand query = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();

        public string[,] ScheduleConsult() {

            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"SELECT COUNT(ID_SCHEDULE) AS TOTAL FROM TB_SCHEDULING;";
                reader = query.ExecuteReader();

                reader.Read();
                string total = $"{reader["TOTAL"]}";
                string[,] procedures = new string[int.Parse(total), 6];
                reader.Close();


                query.CommandText = $"SELECT S.DATE_SCHEDULE, S.TIME_SCHEDULE, D.NAME_DENTIST, D.LAST_NAME AS LAST_NAME_DENTIST, S.STATUS_SCHEDULE, P.NAME_PATIENT, P.LAST_NAME AS LAST_NAME_PATIENT, P.NICKNAME AS NICKNAME_PATIENT, PR.PROCEDURE_TITLE FROM TB_SCHEDULING AS S, TB_DENTISTS AS D, TB_CONSULTS AS C, TB_PATIENTS AS P, TB_PROCEDURES AS PR WHERE S.CRO_DENTIST = D.CRO_DENTIST AND C.CPF_PATIENT = P.CPF_PATIENT AND C.ID_PROCEDURE = PR.ID_PROCEDURE ORDER BY S.ID_SCHEDULE;";
                reader = query.ExecuteReader();

                int i = 0;
                while (reader.Read()) {
                    procedures[i, 0] = $"{reader["DATE_SCHEDULE"]}";
                    procedures[i, 1] = $"{reader["TIME_SCHEDULE"]}";
                    procedures[i, 2] = $"{reader["NAME_DENTIST"]} {reader["LAST_NAME_DENTIST"]}";
                    if (string.IsNullOrEmpty(Convert.ToString(reader["NICKNAME_PATIENT"]))) {
                        procedures[i, 3] = $"{reader["NAME_PATIENT"]} {reader["LAST_NAME_PATIENT"]}";
                    } else {
                        procedures[i, 3] = $"{reader["NICKNAME_PATIENT"]}";
                    }
                    procedures[i, 4] = $"{reader["PROCEDURE_TITLE"]}";
                    if (Convert.ToBoolean(reader["STATUS_SCHEDULE"])) { 
                        procedures[i++, 5] = "Ocupado";
                    } else {
                        procedures[i++, 5] = "Livre";
                    }
                }

                reader.Close();

                dbConn.Disconnect();

                return procedures;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar a listagem de consultas!", false);
                return null;
            }
        }
    }
}
