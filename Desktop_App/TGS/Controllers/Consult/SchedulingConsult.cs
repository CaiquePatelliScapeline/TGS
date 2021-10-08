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

        public string[,] ScheduleClosedConsult() {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = "SELECT COUNT(ID_CONSULT) AS TOTAL FROM TB_CONSULTS WHERE STATUS_SCHEDULE = 1;";
                reader = query.ExecuteReader();
                reader.Read();

                string total = $"{reader["TOTAL"]}";
                string[,] consults = new string[int.Parse(total), 6];

                reader.Close();

                query.CommandText = $"SELECT C.ID_CONSULT, C.DATE_CONSULT, C.TIME_CONSULT, D.NAME_DENTIST, D.LAST_NAME AS LAST_NAME_DENTIST, C.STATUS_SCHEDULE, P.NAME_PATIENT, P.LAST_NAME AS LAST_NAME_PATIENT, P.NICKNAME, PR.PROCEDURE_TITLE FROM TB_DENTISTS AS D, TB_CONSULTS AS C, TB_PATIENTS AS P, TB_PROCEDURES AS PR WHERE C.CRO_DENTIST = D.CRO_DENTIST AND C.CPF_PATIENT = P.CPF_PATIENT AND C.ID_PROCEDURE = PR.ID_PROCEDURE ORDER BY C.ID_CONSULT;";
                reader = query.ExecuteReader();

                int i = 0;
                while (reader.Read()) {
                    consults[i, 0] = $"{reader["ID_CONSULT"]}";

                    string date = Convert.ToString(reader["DATE_CONSULT"]);

                    consults[i, 1] = $"{date.Substring(0, date.IndexOf(' '))}";
                    consults[i, 2] = $"{reader["TIME_CONSULT"]}";
                    consults[i, 3] = $"{reader["NAME_DENTIST"]} {reader["LAST_NAME_DENTIST"]}";

                    if (string.IsNullOrEmpty(Convert.ToString(reader["NICKNAME"]))) {
                        consults[i, 4] = $"{reader["NAME_PATIENT"]} {reader["LAST_NAME_PATIENT"]}";
                    } else {
                        consults[i, 4] = $"{reader["NICKNAME"]}";
                    }

                    consults[i, 5] = $"{reader["PROCEDURE_TITLE"]}";                  
                }

                reader.Close();
                dbConn.Disconnect();
                return consults;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar a listagem de consultas!", false);
                return null;
            }
        }

        public string[] ClosedConsult(string id) {
            try {
                query.Connection = dbConn.Connect();

                string[] consult = new string[5];

                query.CommandText = $"SELECT C.DATE_CONSULT, C.TIME_CONSULT, D.NAME_DENTIST, D.LAST_NAME AS LAST_NAME_DENTIST, P.NAME_PATIENT, P.LAST_NAME AS LAST_NAME_PATIENT, P.NICKNAME, PR.PROCEDURE_TITLE FROM TB_DENTISTS AS D, TB_CONSULTS AS C, TB_PATIENTS AS P, TB_PROCEDURES AS PR WHERE C.ID_CONSULT = {id} AND C.STATUS_SCHEDULE = 1 AND C.CRO_DENTIST = D.CRO_DENTIST AND C.CPF_PATIENT = P.CPF_PATIENT AND C.ID_PROCEDURE = PR.ID_PROCEDURE ORDER BY C.ID_CONSULT;";

                reader = query.ExecuteReader();

                reader.Read();

                consult[0] = $"{reader["DATE_CONSULT"]}";
                consult[1] = $"{reader["TIME_CONSULT"]}";
                consult[2] = $"{reader["NAME_DENTIST"]} {reader["LAST_NAME_DENTIST"]}";
                if (string.IsNullOrEmpty(Convert.ToString(reader["NICKNAME"]))) {
                    consult[3] = $"{reader["NAME_PATIENT"]} {reader["LAST_NAME_PATIENT"]}";
                } else {
                    consult[3] = $"{reader["NICKNAME"]}";
                }
                consult[4] = $"{reader["PROCEDURE_TITLE"]}";

                reader.Close();

                dbConn.Disconnect();

                return consult;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar o detalhe da consulta!", false);
                return null;
            }
        }

        public string[,] ScheduleOpenedConsult() {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = "SELECT COUNT(ID_CONSULT) FROM TB_CONSULTS WHERE STATUS_SCHEDULE = 0;";
                reader = query.ExecuteReader();
                reader.Read();

                string total = $"{reader["TOTAL"]}";
                string[,] consults = new string[int.Parse(total), 4];

                reader.Close();

                query.CommandText = $"SELECT C.ID_CONSULT, C.DATE_CONSULT, C.TIME_CONSULT, D.NAME_DENTIST, D.LAST_NAME AS LAST_NAME_DENTIST, C.STATUS_SCHEDULE FROM TB_DENTISTS AS D, TB_CONSULTS AS C WHERE C.STATUS_SCHEDULE = 0 AND C.CRO_DENTIST = D.CRO_DENTIST ORDER BY C.ID_CONSULT;";
                reader = query.ExecuteReader();

                int i = 0;
                while (reader.Read()) {
                    consults[i, 0] = $"{reader["ID_CONSULT"]}";
                    consults[i, 1] = $"{reader["DATE_CONSULT"]}";
                    consults[i, 2] = $"{reader["TIME_CONSULT"]}";
                    consults[i, 3] = $"{reader["NAME_DENTIST"]} {reader["LAST_NAME_DENTIST"]}";
                }

                reader.Close();
                dbConn.Disconnect();
                return consults;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar a listagem de horários livres!", false);
                return null;
            }
        }

        public string[] OpenedConsult(string id) {
            try {
                query.Connection = dbConn.Connect();

                string[] consult = new string[3];

                query.CommandText = $"SELECT C.ID_CONSULT, C.DATE_CONSULT, C.TIME_CONSULT, D.NAME_DENTIST, D.LAST_NAME AS LAST_NAME_DENTIST, C.STATUS_SCHEDULE FROM TB_DENTISTS AS D, TB_CONSULTS AS C WHERE C.STATUS_SCHEDULE = 0 AND C.CRO_DENTIST = D.CRO_DENTIST ORDER BY C.ID_CONSULT;";

                reader = query.ExecuteReader();

                reader.Read();

                consult[0] = $"{reader["DATE_CONSULT"]}";
                consult[1] = $"{reader["TIME_CONSULT"]}";
                consult[2] = $"{reader["NAME_DENTIST"]} {reader["LAST_NAME_DENTIST"]}";

                reader.Close();

                dbConn.Disconnect();

                return consult;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar os detalhes do horário livre!", false);
                return null;
            }
        }
    }
}
