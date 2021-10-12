using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TGS.Model;
using TGS.Views;
using TGS.Controllers.Main;

namespace TGS.Controllers.Update {
    class EmployeeUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();

        public void Employee(string id, string cpf, string name, string lastName, string email, string telephone, string cellphone) {
            if (validateController.CPF(cpf) && validateController.Email(email) && validateController.Telephone(telephone) && validateController.Cellphone(cellphone)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"UPDATE TB_EMPLOYEES SET CPF_EMPLOYEE = '{cpf}', NAME_EMPLOYEE = '{name}', LAST_NAME = '{lastName}', EMAIL = '{email}', TELEPHONE = '{telephone}', CELLPHONE = '{cellphone}' WHERE CPF_EMPLOYEE = '{id}';";
                    query.ExecuteNonQuery();

                    dbConn.Disconnect();
                } catch (SqlException e) {
                    MyMsgBox.Show("Erro", "Falha ao atualizar o registro do funcionário!", false);
                }
            } else {
                MyMsgBox.Show("Erro", "Dados inválidos!", false);
            }
        }
    }
}