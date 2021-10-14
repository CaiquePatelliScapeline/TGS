using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;

namespace TGS.Controllers.Update {
    class DentistUpdate {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        ValidateController validateController = new ValidateController();
        StatusController statusController = new StatusController();

        public void Dentist(string id, string cro, string name, string lastName, string expertise) {
            if (validateController.CRO(cro)) {
                try {
                    query.Connection = dbConn.Connect();

                    query.CommandText = $"UPDATE TB_DENTISTS SET CRO_DENTIST = '{cro}', NAME_DENTIST = '{validateController.ToTitleCase(name)}', LAST_NAME = '{validateController.ToTitleCase(lastName)}', EXPERTISE = '{validateController.ToTitleCase(expertise)}' WHERE CRO_DENTIST = '{id}';";
                    query.ExecuteNonQuery();

                    dbConn.Disconnect();
                    statusController.Updated();
                } catch (SqlException e) {
                    statusController.NonUpdated();
                }
            }
        }
    }
}