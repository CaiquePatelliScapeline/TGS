using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Update {
    class PatientUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();
        StatusController statusController = new StatusController();

        public void Patient(string id, string cpf, string rg, string name, string lastName, string nickname, string birthDate, string height, string weight, string email, string telephone, string cellphone, string street, string neighborhood, string city, string district, string cep, string complement, int number) {
            if (validateController.CPF(cpf) && validateController.RG(rg) && validateController.Date(birthDate) && validateController.Email(email) && validateController.Telephone(telephone) && validateController.Cellphone(cellphone) && validateController.CEP(cep)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"UPDATE TB_PATIENTS SET CPF_PATIENT = '{cpf}', RG_PATIENT='{rg}', NAME_PATIENT = '{validateController.ToTitleCase(name)}', LAST_NAME = '{validateController.ToTitleCase(lastName)}', NICKNAME = '{validateController.ToTitleCase(nickname)}, BIRTH_DATE = '{birthDate}', HEIGHT = '{height}', WEIGHT_PATIENT = '{weight}', EMAIL = '{email}', TELEPHONE = '{telephone}', CELLPHONE = '{cellphone}', STREET = '{validateController.ToTitleCase(street)}', NEIGHBORHOOD = '{validateController.ToTitleCase(neighborhood)}', CITY = '{validateController.ToTitleCase(city)}', DISTRICT = '{validateController.ToTitleCase(district)}', CEP = '{cep}', COMPLEMENT = '{complement}', NUMBER = {number} WHERE CPF_PATIENT = '{id}';";
                    query.ExecuteNonQuery();

                    dbConn.Disconnect();
                    statusController.Updated();
                } catch (SqlException e) {
                    statusController.NonUpdated();
                }
            } else {
                statusController.NotAcceptable();
            }
        }
    }
}