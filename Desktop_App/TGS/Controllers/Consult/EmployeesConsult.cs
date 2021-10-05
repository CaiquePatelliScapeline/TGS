﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Consult {
    class EmployeesConsult {
        // Classes
        SqlCommand query = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();

        public string[,] EmployeeConsult() {

            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"SELECT COUNT(CPF_EMPLOYEE) AS TOTAL FROM TB_EMPLOYEES;";
                reader = query.ExecuteReader();

                reader.Read();
                string total = $"{reader["TOTAL"]}";
                string[,] procedures = new string[int.Parse(total), 5];
                reader.Close();


                query.CommandText = $"SELECT CPF_EMPLOYEE, NAME_EMPLOYEE, LAST_NAME, EMAIL, TELEPHONE, CELLPHONE FROM TB_EMPLOYEES ORDER BY CPF_EMPLOYEE;";
                reader = query.ExecuteReader();

                int i = 0;
                while (reader.Read()) {
                    procedures[i, 0] = $"{reader["CPF_EMPLOYEE"]}";
                    procedures[i, 1] = $"{reader["NAME_EMPLOYEE"]} {reader["LAST_NAME"]}";
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