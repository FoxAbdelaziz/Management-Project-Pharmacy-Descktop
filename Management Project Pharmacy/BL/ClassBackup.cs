using System;
using System.Data;
using Management_Project_Pharmacy.DAL;
namespace Management_Project_Pharmacy.BL
{
    class ClassBackup
    {
        public static string Backup_DB(string Path)
        {
            DataAccessLayer.Open();
            string Query = String.Format("Backup DataBase APharmacy_DB to Disk ='{0}' ", Path);
            DataAccessLayer.ExecuteNonQuery(Query,CommandType.Text);
            DataAccessLayer.Close();
            return "OK";
        }

        public static void Restor_DB(string Path)
        {
            DataAccessLayer.con = "Data Source=.;Initial Catalog=master;Integrated Security=True";
            DataAccessLayer.Open();
            string Query = String.Format("Alter Database APharmacy_DB SET offline with rollback immediate; Restor DataBase APharmacy_DB From Disk ='{0}' ", Path);
            DataAccessLayer.ExecuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();
        }
    }
}