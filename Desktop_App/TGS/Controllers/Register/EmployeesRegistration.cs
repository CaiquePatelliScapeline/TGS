using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TGS.Model;
using TGS.Views;
using TGS.Controllers.Main;
using TGS.Controllers.Criptography;

namespace TGS.Controllers.Register {
    class EmployeesRegistration {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        MD5Hash md5Hash = new MD5Hash();

        public void EmployeeRegistration(string cpf, string name, string lastName, string email, string telephone, string cellphone, string password) {        
            string hashPassword = md5Hash.CreateMD5Hash(password);

            ValidateController validateController = new ValidateController();

            if (validateController.ValidateEmail(email)) {
                query.CommandText = $"INSERT INTO TB_EMPLOYEES (CPF_EMPLOYEE, NAME_EMPLOYEE, LAST_NAME, EMAIL, TELEPHONE, CELLPHONE, PASSWORD_EMPLOYEE) VALUES ('{cpf}', '{name}', '{lastName}', '{email}', '{telephone}', '{cellphone}', '{hashPassword}');";
                try {
                    query.Connection = dbConn.Connect();
                    query.ExecuteNonQuery();
                    dbConn.Disconnect();
                    MyMsgBox.Show("Success", "Funcionário cadastrado com sucesso!", false);
                } catch (SqlException e) {
                    MyMsgBox.Show("Error", "Falha no cadastro do funcionário!", false);
                }
            } else {
                MyMsgBox.Show("Error", "E-mail inválido!", false);
            }
        }
    }
}
