using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TGS.Model;
using TGS.Views;
using TGS.Controllers.Main;

namespace TGS.Controllers.Register {
    class DentistsRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();

        public void DentistRegistration(string croDentist, string nameDentist, string lastName, string expertise) {
            if (validateController.CRO(croDentist)) {
                try {
                    query.CommandText = $"INSERT INTO TB_DENTISTS (CRO_DENTIST, NAME_DENTIST, LAST_NAME, EXPERTISE) VALUES ('{croDentist}', '{validateController.ToTitleCase(nameDentist)}', '{validateController.ToTitleCase(lastName)}', '{validateController.ToTitleCase(expertise)}');";
                    query.Connection = dbConn.Connect();
                    query.ExecuteNonQuery();
                    dbConn.Disconnect();
                    MyMsgBox.Show("Success", "Dentista cadastrado com sucesso!", false);
                } catch (SqlException e) {
                    MyMsgBox.Show("Erro", "Falha no cadastro do dentista!", false);
                }
            } else {
                MyMsgBox.Show("Erro", "Dados inválidos!", false);
            }
        }
    }
}
