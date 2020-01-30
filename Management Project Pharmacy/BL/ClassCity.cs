using System;
using System.Data;
using Management_Project_Pharmacy.DAL;

namespace Management_Project_Pharmacy.BL
{
    class ClassCity
    {
        public static int SP_InsertCity(string Cityname,int countryid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertCity", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@City_Name", SqlDbType.NVarChar, Cityname),
                DataAccessLayer.CreateParameter("@Country_ID", SqlDbType.Int, countryid));
            return i;
        }
        public static DataTable SP_SelectAllCity()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllCity", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SearchCity(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchCity", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search",SqlDbType.NVarChar,search));
            DataAccessLayer.Close();
            return dt;
        }

        // 
        public static int SP_UpdateCity(int cityid, string Cityname, int countryid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateCity", CommandType.StoredProcedure,
                                DataAccessLayer.CreateParameter("@City_ID", SqlDbType.Int, cityid),
            DataAccessLayer.CreateParameter("@City_Name", SqlDbType.NVarChar, Cityname),
                DataAccessLayer.CreateParameter("@Country_ID", SqlDbType.Int, countryid));
            return i;
        }

        public static int SP_DeleteCity(int cityid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteCity", CommandType.StoredProcedure,
                                DataAccessLayer.CreateParameter("@City_ID", SqlDbType.Int, cityid));
                                return i;
        }
    }
}
