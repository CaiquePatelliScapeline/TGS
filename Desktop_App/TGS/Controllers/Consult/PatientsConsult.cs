using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;


namespace TGS.Controllers.Consult {
    class PatientsConsult {
        // Classes
        SqlCommand query = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();

        public string[,] PatientConsult() {

            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"SELECT COUNT(CPF_PATIENT) AS TOTAL FROM TB_PATIENTS;";
                reader = query.ExecuteReader();

                reader.Read();
                string total = $"{reader["TOTAL"]}";
                string[,] procedures = new string[int.Parse(total), 5];
                reader.Close();


                query.CommandText = $"SELECT CPF_PATIENT, NAME_PATIENT, LAST_NAME, NICKNAME, EMAIL, TELEPHONE, CELLPHONE FROM TB_PATIENTS ORDER BY CPF_PATIENT;";
                reader = query.ExecuteReader();

                int i = 0;
                while (reader.Read()) {
                    procedures[i, 0] = $"{reader["CPF_PATIENT"]}";
                    if (string.IsNullOrEmpty(Convert.ToString(reader["NICKNAME"]))) {
                        procedures[i, 1] = $"{reader["NAME_PATIENT"]} {reader["LAST_NAME"]}";
                    } else {
                        procedures[i, 1] = $"{reader["NICKNAME"]}";
                    }                
                    procedures[i, 2] = $"{reader["EMAIL"]}";
                    procedures[i, 3] = $"{reader["TELEPHONE"]}";
                    procedures[i++, 4] = $"{reader["CELLPHONE"]}";
                }

                reader.Close();

                dbConn.Disconnect();

                return procedures;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar a listagem de funcionários!", false);
                return null;
            }
        }
    }
}