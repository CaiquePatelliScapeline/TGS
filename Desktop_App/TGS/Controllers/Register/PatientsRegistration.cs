using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Register {
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
                query.CommandText = $"INSERT INTO TB_PATIENTS (CPF_PATIENT, RG_PATIENT, NAME_PATIENT, LAST_NAME, NICKNAME, BIRTH_DATE, HEIGHT, WEIGHT_PATIENT, EMAIL, TELEPHONE, CELLPHONE, STREET, NEIGHBORHOOD, CITY, DISTRICT, CEP, COMPLEMENT, NUMBER) VALUES ('{cpf}', '{rg}', '{name}', '{lastName}', '{nickname}', '{birthDate}', {height}, {weight}, '{email}', '{cellphone}', '{telephone}', '{street}', '{neighborhood}', '{city}', '{district}', '{cep}', '{complement}', {number});";
                try {
                    query.Connection = dbConn.Connect();
                    query.ExecuteNonQuery();
                    dbConn.Disconnect();
                    MyMsgBox.Show("Success", "Paciente cadastrado com sucesso!", false);
                } catch (SqlException e) {
                    MyMsgBox.Show("Error", "Falha no cadastro do paciente!", false);
                }
            }
        }
    }
}
