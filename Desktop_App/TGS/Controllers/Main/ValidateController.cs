﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using TGS.Views;

namespace TGS.Controllers.Main {
    class ValidateController {
        public bool Date(string date) {
            return DateTime.TryParse(date, out DateTime dateTime);
        }

        public bool Time(string time) {
            Regex timeValidate = new Regex(@"/^(\d{2})\:(\d{2})\:(\d{2})\.?(\d{4})?$/");
            MyMsgBox.Show("Time", $"{timeValidate.IsMatch(time)}", false);
            return timeValidate.IsMatch(time);
        }

        public bool Email(string email) {
            Regex emailValidate = new Regex(@"/^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$/");          
            return emailValidate.IsMatch(email);
        }

        public bool RG(string rg) {
            Regex rgValidate = new Regex(@"/^((\d{2})\.(\d{3})\.(\d{3})\-(\d))$/");
            return rgValidate.IsMatch(rg);
        }

        public bool CPF(string cpf) {
            Regex cpfValidate = new Regex(@"/^((\d{3})\.(\d{3})\.(\d{3})\-(\d{2}))$/");
            MyMsgBox.Show("CPF", $"{cpf.Length}", false);
            MyMsgBox.Show("CPF", $"{cpfValidate.IsMatch(cpf)}", false);
            return cpfValidate.IsMatch(cpf);
        }

        public bool CRO(string cro) {
            Regex croValidate = new Regex(@"/^(\d{2})\.(\d{3})$/");
            MyMsgBox.Show("CRO", $"{croValidate.IsMatch(cro)}", false);
            return croValidate.IsMatch(cro);
        }

        public bool CEP(string cep) {
            Regex cepValidate = new Regex(@"/^(\d{2})\.(\d{3})-(\d{3})$/");
            return cepValidate.IsMatch(cep);
        }

        public bool Telephone(string telephone) {
            Regex telephoneValidate = new Regex(@"/^(\((\d{2})\))(\d{4})-(\d{4})$/");
            return telephoneValidate.IsMatch(telephone);
        }

        public bool Cellphone(string cellphone) {
            Regex cellphoneValidate = new Regex(@"/^(\((\d{2})\))(\d{5})-(\d{4})$/");
            return cellphoneValidate.IsMatch(cellphone);
        }

        public string ToTitleCase(string str) {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}
