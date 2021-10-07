using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Update {
    class EmployeeUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();

        public void Employee(string id, string cpf, string name, string lastName, string email, string telephone, string cellphone) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"UPDATE TB_EMPLOYEES SET CPF_EMPLOYEE = '{cpf}', NAME_EMPLOYEE = '{name}', LAST_NAME = '{lastName}', EMAIL = '{email}', TELEPHONE = '{telephone}', CELLPHONE = '{cellphone}' WHERE CPF_EMPLOYEE = '{id}';";
                query.ExecuteNonQuery();

                dbConn.Disconnect();
            } catch (SqlException e) {
                MyMsgBox.Show("Error", "Falha ao atualizar o registro do funcionário!", false);
            }
        }
    }
}