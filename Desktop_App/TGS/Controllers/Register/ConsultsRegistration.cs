using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;
using TGS.Controllers.Main;

namespace TGS.Controllers.Register {
    class ConsultsRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();

        public void ConsultOpen(string croDentist, string dateConsult, string timeConsult) {
            if (validateController.CRO(croDentist) && validateController.Date(dateConsult) && validateController.Time(timeConsult)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"INSERT INTO TB_CONSULTS (CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, STATUS_SCHEDULE) VALUES ('{croDentist}', '{dateConsult}', '{timeConsult}', 0);";
                    query.ExecuteNonQuery();

                    dbConn.Disconnect();

                    MyMsgBox.Show("Success", "Consulta aberta com sucesso!", false);
                } catch (SqlException e) {
                    MyMsgBox.Show("Erro", "Falha na abertura da consulta!", false);
                }
            } else {
                MyMsgBox.Show("Erro", "Dados inválidos!", false);
            }
        }

        public void ConsultRegistration(string cpfPatient, int idProcedure, int idConsulta) {
            if (validateController.CPF(cpfPatient)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 1, CPF_EMPLOYEE = '{Session.CPF}', CPF_PATIENT = '{cpfPatient}', ID_PROCEDURE = {idProcedure} WHERE ID_CONSULT = {idConsulta};";
                    query.ExecuteNonQuery();

                    dbConn.Disconnect();

                    MyMsgBox.Show("Success", "Consulta marcada com sucesso!", false);
                } catch (SqlException e) {
                    MyMsgBox.Show("Error", "Falha no cadastro da consulta!", false);
                }
            } else {
                MyMsgBox.Show("Erro", "Dados inválidos!", false);
            }
        }
    }
}
