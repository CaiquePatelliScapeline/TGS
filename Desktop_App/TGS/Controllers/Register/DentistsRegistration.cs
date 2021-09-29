using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Register {
    class DentistsRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        MyMsgBox MyMsgBox = new MyMsgBox();

        public void DentistRegistration(string croDentist, string nameDentist, string lastName, string expertise) {

            try {
                query.CommandText = $"INSERT INTO TB_DENTISTS (CRO_DENTIST, NAME_DENTIST, LAST_NAME, EXPERTISE) VALUES ('{croDentist}', '{nameDentist}', '{lastName}', '{expertise}');";
                query.Connection = dbConn.Connect();
                query.ExecuteNonQuery();
                dbConn.Disconnect();
                MyMsgBox.Show("Success", "Dentista cadastrado com sucesso!", false);
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha no cadastro do dentista!", false);
            }
        }
    }
}
