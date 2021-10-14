﻿using System.Data.SqlClient;
using TGS.Model;
using TGS.Controllers.Main;


namespace TGS.Controllers.Delete {
    class PatientDelete {
        // Classes
        SqlCommand query = new SqlCommand();
        DBConnection dbConn = new DBConnection();
        StatusController statusController = new StatusController();

        public void Patient(string id) {
            try {
                query.Connection = dbConn.Connect();

                query.CommandText = $"DELETE FROM TB_PATIENTS WHERE CPF_PATIENT = '{id}';";
                query.ExecuteNonQuery();

                dbConn.Disconnect();
                statusController.Deleted();
            } catch (SqlException e) {
                statusController.NonDeleted();
            }
        }
    }
}