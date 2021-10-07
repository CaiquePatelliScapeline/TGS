﻿using System;
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

        public string[,] Patients() {

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

        public string[] Patient(string id) {
            try {
                query.Connection = dbConn.Connect();

                string[] details = new string[18];

                query.CommandText = $"SELECT * FROM TB_PATIENTS WHERE CPF_PATIENT = '{id}';";
                reader = query.ExecuteReader();

                reader.Read();

                details[0] = $"{reader["CPF_PATIENT"]}";
                details[1] = $"{reader["RG_PATIENT"]}";
                details[2] = $"{reader["NAME_PATIENT"]}";
                details[3] = $"{reader["LAST_NAME"]}";
                details[4] = $"{reader["NICKNAME"]}";
                details[5] = $"{reader["BIRTH_DATE"]}";
                details[6] = $"{reader["HEIGHT"]}";
                details[7] = $"{reader["WEIGHT_PATIENT"]}";
                details[8] = $"{reader["EMAIL"]}";
                details[9] = $"{reader["TELEPHONE"]}";
                details[10] = $"{reader["CELLPHONE"]}";
                details[11] = $"{reader["STREET"]}";
                details[12] = $"{reader["NEIGHBORHOOD"]}";
                details[13] = $"{reader["CITY"]}";
                details[14] = $"{reader["DISTRICT"]}";
                details[15] = $"{reader["CEP"]}";
                details[16] = $"{reader["COMPLEMENT"]}";
                details[17] = $"{reader["NUMBER"]}";

                reader.Close();

                dbConn.Disconnect();

                return details;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar os detalhes do paciente!", false);
                return null;
            }
        }
    }
}