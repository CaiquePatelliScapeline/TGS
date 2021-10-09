using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TGS.Controllers.Main {
    class ValidateController {
        public bool ValidateDate(string date) {
            return DateTime.TryParse(date, out DateTime time);
        }

        public bool ValidateEmail(string email) {
            Regex emailValidate = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");          
            return emailValidate.IsMatch(email);
        }
    }
}
