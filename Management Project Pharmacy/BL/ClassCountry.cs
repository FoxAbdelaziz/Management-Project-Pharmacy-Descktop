using System;
using Management_Project_Pharmacy.DAL;
using System.Data;

namespace Management_Project_Pharmacy.BL
{
    class ClassCountry
    {
        public static int SP_InsertCountry(string countrycode,string countryname)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertCountry",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CountryCode",SqlDbType.NVarChar,countrycode),
                DataAccessLayer.CreateParameter("@CountryName",SqlDbType.NVarChar,countryname));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SelectAllCountry()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllCountry", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_SearchCountry(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchCountry", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search",SqlDbType.NVarChar,Search));
            DataAccessLayer.Close();
            return dt;
        }
        //

        public static int SP_UpdateCountry( int countryID, string countrycode, string countryname)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateCountry", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Country_ID", SqlDbType.NVarChar, countryID),
                DataAccessLayer.CreateParameter("@Country_Code", SqlDbType.NVarChar, countrycode),
                DataAccessLayer.CreateParameter("@Country_Name", SqlDbType.NVarChar, countryname));
            DataAccessLayer.Close();
            return i;
        }

        public static int SP_DeleteCountry(int Country_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteCountry", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Country_ID", SqlDbType.Int, Country_ID));
            DataAccessLayer.Close();
            return i;
        }
    }
}
