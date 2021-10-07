using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Register {
    class ConsultsRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();

        public void ConsultRegistration(string croDentist, string dateConsult, string timeConsult) {          
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"INSERT INTO TB_CONSULTS (CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, STATUS_SCHEDULE) VALUES ('{croDentist}', '{dateConsult}', '{timeConsult}', 0);";
                query.ExecuteNonQuery();

                dbConn.Disconnect();

                MyMsgBox.Show("Success", "Consulta aberta com sucesso!", false);
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha na abertura da consulta!", false);
            }
        }

        public void ConsultOpen(string cpfPatient, int idProcedure, int idConsulta) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 1, CPF_EMPLOYEE = '{Session.CPF}', CPF_PATIENT = '{cpfPatient}', ID_PROCEDURE = {idProcedure} WHERE ID_CONSULT = {idConsulta};";
                query.ExecuteNonQuery();

                dbConn.Disconnect();

                MyMsgBox.Show("Success", "Consulta marcada com sucesso!", false);
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha no cadastro da consulta!", false);
            }
        }
    }
}
