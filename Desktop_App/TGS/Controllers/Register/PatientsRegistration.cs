using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Register {
    class PatientsRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();
        StatusController statusController = new StatusController();

        public void PatientRegistration(string cpf, string rg, string name, string lastName, string nickname, string birthDate, string height, string weight, string email, string telephone, string cellphone, string street, string neighborhood, string city, string district, string cep, string complement, string number) {           
            if (validateController.CPF(cpf) && validateController.RG(rg) && validateController.Email(email)) {
                query.CommandText = $"INSERT INTO TB_PATIENTS (CPF_PATIENT, RG_PATIENT, NAME_PATIENT, LAST_NAME, NICKNAME, BIRTH_DATE, HEIGHT, WEIGHT_PATIENT, EMAIL, TELEPHONE, CELLPHONE, STREET, NEIGHBORHOOD, CITY, DISTRICT, CEP, COMPLEMENT, NUMBER) VALUES ('{cpf}', '{rg}', '{name}', '{lastName}', '{nickname}', '{birthDate}', '{height}', '{weight}', '{email}', '{telephone}', '{cellphone}', '{street}', '{neighborhood}', '{city}', '{district}', '{cep}', '{complement}', {int.Parse(number)});";
                try {
                    query.Connection = dbConn.Connect();
                    query.ExecuteNonQuery();
                    dbConn.Disconnect();
                    statusController.Created();
                } catch (SqlException e) {
                    statusController.NonCreated();
                }
            } else {
                statusController.NotAcceptable();
            }
        }
    }
}
