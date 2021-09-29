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
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();
        MyMsgBox MyMsgBox = new MyMsgBox();

        public void ConsultRegistration(string cpfPatient, string croDentist, string dateConsult, string timeConsult, int idProcedure) {
            
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"INSERT INTO TB_CONSULTS (CPF_PATIENT, CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, ID_PROCEDURE) VALUES ('{cpfPatient}', '{croDentist}', '{dateConsult}', '{timeConsult}', {idProcedure});";
                query.ExecuteNonQuery();

                query.CommandText = $"SELECT ID_CONSULT FROM TB_CONSULTS WHERE DATE_CONSULT = '{dateConsult}' AND TIME_CONSULT = '{timeConsult}';";
                query.ExecuteNonQuery();
             
                reader = query.ExecuteReader();  //while (reader.Read()) {MyMsgBox.Show("Deu bom?", $"{reader["ID_CONSULT"]}", true);}
                reader.Read();
                query.CommandText = $"UPDATE TB_SCHEDULING SET STATUS_SCHEDULE = 1, ID_CONSULT = {Convert.ToInt32(reader["ID_CONSULT"])}, CPF_EMPLOYEE = '803.047.456-75' WHERE DATE_SCHEDULE = '{dateConsult}' AND TIME_SCHEDULE = '{timeConsult}';";
                reader.Close();
                query.ExecuteNonQuery();

                dbConn.Disconnect();

                MyMsgBox.Show("Success", "Consulta cadastrada com sucesso!", false);
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha no cadastro da consulta!", false);
            }
        }
    }
}
