using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;
using TGS.Controllers.Main;

namespace TGS.Controllers.Register {
    class PatientsRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();

        public void PatientRegistration(string cpf, string rg, string name, string lastName, string nickname, string birthDate, string height, string weight, string email, string telephone, string cellphone, string street, string neighborhood, string city, string district, string cep, string complement, string number) {           
            if (validateController.CPF(cpf) && validateController.RG(rg) && validateController.Email(email)) {
                MyMsgBox.Show("Error", "E-mail inválido!", false);
                query.CommandText = $"INSERT INTO TB_PATIENTS (CPF_PATIENT, RG_PATIENT, NAME_PATIENT, LAST_NAME, NICKNAME, BIRTH_DATE, HEIGHT, WEIGHT_PATIENT, EMAIL, TELEPHONE, CELLPHONE, STREET, NEIGHBORHOOD, CITY, DISTRICT, CEP, COMPLEMENT, NUMBER) VALUES ('{cpf}', '{rg}', '{name}', '{lastName}', '{nickname}', '{birthDate}', '{height}', '{weight}', '{email}', '{telephone}', '{cellphone}', '{street}', '{neighborhood}', '{city}', '{district}', '{cep}', '{complement}', {int.Parse(number)});";
                try {
                    query.Connection = dbConn.Connect();
                    query.ExecuteNonQuery();
                    dbConn.Disconnect();
                    MyMsgBox.Show("Success", "Paciente cadastrado com sucesso!", false);
                } catch (SqlException e) {
                    MyMsgBox.Show("Error", "Falha no cadastro do paciente!", false);
                }
            } else {

            }
        }
    }
}
