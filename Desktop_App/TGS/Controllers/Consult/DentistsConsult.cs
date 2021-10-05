﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;


namespace TGS.Controllers.Consult {
    class DentistsConsult {
        // Classes
        SqlCommand query = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();

        public string[,] DentistConsult() {

            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"SELECT COUNT(CRO_DENTIST) AS TOTAL FROM TB_DENTISTS;";
                reader = query.ExecuteReader();

                reader.Read();
                string total = $"{reader["TOTAL"]}";
                string[,] procedures = new string[int.Parse(total), 3];
                reader.Close();


                query.CommandText = $"SELECT * FROM TB_DENTISTS ORDER BY CRO_DENTIST;";
                reader = query.ExecuteReader();

                int i = 0;
                while (reader.Read()) {
                    procedures[i, 0] = $"{reader["CRO_DENTIST"]}";
                    procedures[i, 1] = $"{reader["NAME_DENTIST"]} {reader["LAST_NAME"]}";
                    procedures[i++, 2] = $"{reader["EXPERTISE"]}";
                }

                reader.Close();

                dbConn.Disconnect();

                return procedures;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar a listagem de dentistas!", false);
                return null;
            }
        }
    }
}