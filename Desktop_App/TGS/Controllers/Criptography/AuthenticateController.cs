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
            Regex emailValidate = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

            if (!(emailValidate.IsMatch(email))) {
                MyMsgBox.Show("Error", "E-mail inválido!", false);
            } else {
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
            }
        }

        public void Logout(Form form) {
            if (MyMsgBox.Show("Deseja realmente sair?", "Atenção", true) == DialogResult.Yes) {
                Session.Name = "";
                Session.CPF = "";
                alterPageController.AlterPage(form, "login");
            }
        }
    }
}
