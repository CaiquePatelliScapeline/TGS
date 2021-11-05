using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Update {
    public class EmployeeUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();
        StatusController statusController = new StatusController();

        public bool Employee(string id, string cpf, string name, string lastName, string email, string telephone, string cellphone, bool testing = false) {
            if (validateController.CPF(cpf) && validateController.Email(email) && validateController.Telephone(telephone) && validateController.Cellphone(cellphone) && validateController.Text(name) && validateController.Text(lastName)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"UPDATE TB_EMPLOYEES SET CPF_EMPLOYEE = '{cpf}', NAME_EMPLOYEE = '{name}', LAST_NAME = '{lastName}', EMAIL = '{email}', TELEPHONE = '{telephone}', CELLPHONE = '{cellphone}' WHERE CPF_EMPLOYEE = '{id}';";
                    query.ExecuteNonQuery();

                    dbConn.Disconnect();

                    if(!testing) statusController.Updated();
                    return true;
                } catch (SqlException e) {
                    if (!testing) statusController.NonUpdated();
                    return false;
                }
            } else {
                if (!testing) statusController.NotAcceptable();
                return false;
            }
        }
    }
}