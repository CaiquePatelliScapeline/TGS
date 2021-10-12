using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TGS.Controllers.Main;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using TGS.Model;
using TGS.Views;

namespace TGS.Controllers.Criptography {
    class AuthenticateController {
        AlterPageController alterPageController = new AlterPageController();
        SqlCommand query = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConn = new DBConnection();
        MD5Hash md5Hash = new MD5Hash();

        public void Login(String email, String password, Form form) {
            ValidateController validateController = new ValidateController();

            if (validateController.Email(email)) {                      
                string hashPassword = md5Hash.CreateMD5Hash(password);
                query.Connection = dbConn.Connect();
                query.CommandText = $"SELECT CPF_EMPLOYEE, NAME_EMPLOYEE FROM TB_EMPLOYEES WHERE EMAIL = '{email}' AND PASSWORD_EMPLOYEE = '{hashPassword}';";
                reader = query.ExecuteReader();
                if (reader.Read()) {
                    Session.Name = $"{reader["NAME_EMPLOYEE"]}";
                    Session.CPF = $"{reader["CPF_EMPLOYEE"]}";
                    // MessageBox.Show($"{reader["CPF_EMPLOYEE"]}", $"{reader["NAME_EMPLOYEE"]}");
                    reader.Close();
                    dbConn.Disconnect();
                    alterPageController.AlterPage(form, "home");
                } else {
                    MyMsgBox.Show("Error", "E-mail ou senha inválida!", false);
                }
                reader.Close();
                dbConn.Disconnect();
            } else {
                MyMsgBox.Show("Error", "E-mail inválido!", false);
            }
        }

        public void Logout(Form form) {
            if (MyMsgBox.Show("Atenção", "Deseja realmente sair?", true) == DialogResult.Yes) {
                DestroySession();
                alterPageController.AlterPage(form, "login");
            }
        }

        public void DestroySession() {
            Session.Name = "";
            Session.CPF = "";
        }
    }
}
