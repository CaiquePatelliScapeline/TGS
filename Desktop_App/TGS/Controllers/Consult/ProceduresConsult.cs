﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Consult {
    class ProceduresConsult {
        // Classes
        SqlCommand query = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();

        public string[,] ProcedureConsult() {

            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"SELECT COUNT(ID_PROCEDURE) AS TOTAL FROM TB_PROCEDURES;";
                reader = query.ExecuteReader();

                reader.Read();
                string total = $"{reader["TOTAL"]}";
                string[,] procedures = new string[int.Parse(total), 2];
                reader.Close();


                query.CommandText = $"SELECT * FROM TB_PROCEDURES ORDER BY ID_PROCEDURE;";
                reader = query.ExecuteReader();

                int i = 0;
                while (reader.Read()) {
                    procedures[i, 0] = $"{reader["ID_PROCEDURE"]}";
                    procedures[i++, 1] = $"{reader["PROCEDURE_TITLE"]}";
                }

                reader.Close();

                dbConn.Disconnect();

                return procedures;
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao carregar a listagem de procedimentos!", false);
                return null;
            }
        }
    }
}
