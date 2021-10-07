using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Update {
    class PatientUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();

        public void Patient(string id, string cpf, string rg, string name, string lastName, string nickname, string birthDate, string height, string weight, string email, string telephone, string cellphone, string street, string neighborhood, string city, string district, string cep, string complement, int number) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"UPDATE TB_PATIENTS SET CPF_PATIENT = '{cpf}', RG_PATIENT='{rg}', NAME_PATIENT = '{name}', LAST_NAME = '{lastName}', NICKNAME = '{nickname}, BIRTH_DATE = '{birthDate}', HEIGHT = '{height}', WEIGHT_PATIENT = '{weight}', EMAIL = '{email}', TELEPHONE = '{telephone}', CELLPHONE = '{cellphone}', STREET = '{street}', NEIGHBORHOOD = '{neighborhood}', CITY = '{city}', DISTRICT = '{district}', CEP = '{cep}', COMPLEMENT = '{complement}', NUMBER = {number} WHERE CPF_PATIENT = '{id}';";
                query.ExecuteNonQuery();

                dbConn.Disconnect();
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao atualizar o registro do paciente!", false);
            }
        }
    }
}