using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TGS.Controllers.Main {
    class ValidateController {
        public bool ValidateDate(string date) {
            return DateTime.TryParse(date, out DateTime dateTime);
        }

        public bool ValidateTime(string time) {
            Regex timeValidate = new Regex(@"/^(\d{2})\:(\d{2})\.?(\d{4})?$/");
            return timeValidate.IsMatch(time);
        }

        public bool ValidateEmail(string email) {
            Regex emailValidate = new Regex(@"/^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$/");          
            return emailValidate.IsMatch(email);
        }

        public bool ValidateRG(string rg) {
            Regex rgValidate = new Regex(@"/^((\d{2})\.(\d{3})\.(\d{3})\-(\d))$/");
            return rgValidate.IsMatch(rg);
        }

        public bool ValidateCPF(string cpf) {
            Regex cpfValidate = new Regex(@"/^((\d{3})\.(\d{3})\.(\d{3})\-(\d{2}))$/");
            return cpfValidate.IsMatch(cpf);
        }

        public bool ValidateCRO(string cro) {
            Regex croValidate = new Regex(@"/^(\d{2}).(\d{3})$/");
            return croValidate.IsMatch(cro);
        }

        public bool ValidateTelephone(string telephone) {
            Regex telephoneValidate = new Regex(@"/^(\((\d{2})\))(\d{4})-(\d{4})$/");
            return telephoneValidate.IsMatch(telephone);
        }

        public bool ValidateCellphone(string cellphone) {
            Regex cellphoneValidate = new Regex(@"/^(\((\d{2})\))(\d{5})-(\d{4})$/");
            return cellphoneValidate.IsMatch(cellphone);
        }

        public string ToTitleCase(string str) {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}
