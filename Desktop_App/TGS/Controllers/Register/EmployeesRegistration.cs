using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Register {
    class EmployeesRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        MyMsgBox MyMsgBox = new MyMsgBox();

        public void EmployeeRegistration(string cpf, string name, string lastName, string email, string telephone, string cellphone, string password) {
            Regex emailValidate = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

            string hashPassword = password;

            if (!(emailValidate.IsMatch(email))) {
                MyMsgBox.Show("Error", "E-mail inválido!", false);
            } else {
                query.CommandText = $"INSERT INTO TB_EMPLOYEES (CPF_EMPLOYEE, NAME_EMPLOYEE, LAST_NAME, EMAIL, TELEPHONE, CELLPHONE, PASSWORD_EMPLOYEE) VALUES ('{cpf}', '{name}', '{lastName}', '{email}', '{telephone}', '{cellphone}', '{hashPassword}');";
                try {
                    query.Connection = dbConn.Connect();
                    query.ExecuteNonQuery();
                    dbConn.Disconnect();
                    MyMsgBox.Show("Success", "Funcionário cadastrado com sucesso!", false);
                } catch (SqlException e) {
                    MyMsgBox.Show("Error", "Falha no cadastro do funcionário!", false);
                }
            }
        }
    }
}
