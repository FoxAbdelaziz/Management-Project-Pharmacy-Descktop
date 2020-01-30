using System.Data;
using Management_Project_Pharmacy.DAL;
using System;

namespace Management_Project_Pharmacy.BL
{
    class ClassLogin
    {
        public static DataTable SP_Login(string username, string password)
        {
            DataAccessLayer.Open();
            DataTable dt = new DataTable();
            dt = DataAccessLayer.ExecuteTable("SP_Login", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@UserName", SqlDbType.NVarChar, username),
                DataAccessLayer.CreateParameter("@PassWord", SqlDbType.NVarChar, password));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_ControlInsert(string username, string upassword, DateTime datetime, string process)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertControl", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@username", SqlDbType.NVarChar, username),
                DataAccessLayer.CreateParameter("@password", SqlDbType.NVarChar, upassword),
                DataAccessLayer.CreateParameter("@DateTime", SqlDbType.DateTime, datetime),
                DataAccessLayer.CreateParameter("@Process", SqlDbType.NVarChar, process));
            DataAccessLayer.Close();
            return i;
        }

        public static int SP_DeleteControls()
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteControls", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SelectAllControls()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllControls", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SelectAllUsers()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllUsers", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
    }
}