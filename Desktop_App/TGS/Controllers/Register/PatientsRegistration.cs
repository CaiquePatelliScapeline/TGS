using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;

namespace TGS.dataBase {
    class PatientsRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        MyMsgBox MyMsgBox = new MyMsgBox();

        public void PatientRegistration(string cpf, string rg, string name, string lastName, string nickname, string birthDate, decimal height, decimal weight, string email, string telephone, string cellphone, string street, string neighborhood, string city, string district, string cep, string complement, string number) {

            Regex emailValidate = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

            if (!(emailValidate.IsMatch(email))) {
                MyMsgBox.Show("Error", "E-mail inválido!", false);
            } else {
                //query.CommandText = $"INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('{}')";
                try {
                    query.Connection = dbConn.Connect();
                    query.ExecuteNonQuery();
                    dbConn.Disconnect();
                    MyMsgBox.Show("Success", "Procedimento cadastrado com sucesso!", false);
                } catch (SqlException e) {
                    MyMsgBox.Show("Error", "Falha no cadastro do procedimento!", false);
                }
            }
        }
    }
}
