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
        MyMsgBox MyMsgBox = new MyMsgBox();

        public void ConsultRegistration(string cpfPatient, string croDentist, string dateConsult, string timeConsult, int idProcedure) {
            
            try {
                query.CommandText = $"INSERT INTO TB_CONSULTS (CPF_PATIENT, CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, ID_PROCEDURE) VALUES ('{cpfPatient}', '{croDentist}', '{dateConsult}', '{timeConsult}', {idProcedure});";
                query.Connection = dbConn.Connect();
                query.ExecuteNonQuery();
                //query.CommandText = $"UPDATE TB_SCHEDULING SET STATUS_SCHEDULE = 1, ID_CONSULT = 1, CPF_EMPLOYEE = '803.047.456-75' WHERE DATE_SCHEDULE = '{dateConsult}' AND TIME_SCHEDULE = '{timeConsult}';";
                //query.ExecuteNonQuery();
                dbConn.Disconnect();
                MyMsgBox.Show("Success", "Consulta cadastrada com sucesso!", false);
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha no cadastro da consulta!", false);
            }
        }
    }
}
