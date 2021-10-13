using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TGS.Model {
    public class Session {
        private static string name = "Admin";
        private static string cpf = "000.000.000-00";

        public static string Name {
            get {return Session.name;}
            set {Session.name = value;}
        }

        public static string CPF {
            get {return Session.cpf;}
            set {Session.cpf = value;}
        }
    }
}
