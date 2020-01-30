using System;
using System.Data;
using Management_Project_Pharmacy.DAL;

namespace Management_Project_Pharmacy.BL
{
    class ClassUsers
    {
        public static int SP_InsertUser(string uname,string upassword,string ufullname,int perid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertUser", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@U_Name", SqlDbType.NVarChar, uname),
                DataAccessLayer.CreateParameter("@U_Password", SqlDbType.NVarChar, upassword),
                DataAccessLayer.CreateParameter("@U_FullName", SqlDbType.NVarChar, ufullname),
                DataAccessLayer.CreateParameter("@Per_ID", SqlDbType.Int, perid));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SelectAllPermation()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllPermation", CommandType.StoredProcedure);
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

        public static DataTable SP_SearchUser(string serach)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchUser", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Serach", SqlDbType.NVarChar,serach));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_UpdateUser(int uid,string uname, string upassword, string ufullname, int perid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateUser", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@U_ID", SqlDbType.Int, uid),
                DataAccessLayer.CreateParameter("@U_Name", SqlDbType.NVarChar, uname),
                DataAccessLayer.CreateParameter("@U_Password", SqlDbType.NVarChar, upassword),
                DataAccessLayer.CreateParameter("@U_FullName", SqlDbType.NVarChar, ufullname),
                DataAccessLayer.CreateParameter("@Per_ID", SqlDbType.Int, perid));
            DataAccessLayer.Close();
            return i;
        }

        public static int SP_DeleteUser(int uid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteUser", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@U_ID", SqlDbType.Int, uid));
            DataAccessLayer.Close();
            return i;
        }
    }
}
