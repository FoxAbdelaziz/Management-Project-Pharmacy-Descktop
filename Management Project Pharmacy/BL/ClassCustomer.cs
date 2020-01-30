using System;
using System.Data;
using Management_Project_Pharmacy.DAL;
namespace Management_Project_Pharmacy.BL
{
    class ClassCustomer
    {
        public static DataTable SP_SelectCityByCountry(int countrytid)
        {
            DataAccessLayer.Open();

            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectCityByCountry",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@countryID", SqlDbType.Int,countrytid));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_InsertCustomer(string cuname,string cuaddress,string cumobile,byte[] cuimage,int cityid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertCustomer", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Cu_Name",SqlDbType.NVarChar,cuname),
                DataAccessLayer.CreateParameter("@Cu_Address",SqlDbType.NVarChar,cuaddress),
                DataAccessLayer.CreateParameter("@Cu_Mobile",SqlDbType.VarChar,cumobile),
                DataAccessLayer.CreateParameter("@Cu_Image",SqlDbType.Image,cuimage),
                DataAccessLayer.CreateParameter("@City_ID",SqlDbType.Int,cityid));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SelectAllCustomer()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllCustomer", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SearchCustomer(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchCustomer", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search",SqlDbType.NVarChar,search));
            DataAccessLayer.Close();
            return dt;
        }
 

        public static DataTable SP_SelectCustomer()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectCustomer", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }


        public static int SP_UpdateCustomer(int cuid,string cuname, string cuaddress, string cumobile, byte[] cuimage, int cityid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateCustomer", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Cu_Name", SqlDbType.NVarChar, cuname),
                DataAccessLayer.CreateParameter("@Cu_Address", SqlDbType.NVarChar, cuaddress),
                DataAccessLayer.CreateParameter("@Cu_Mobile", SqlDbType.VarChar, cumobile),
                DataAccessLayer.CreateParameter("@Cu_Image", SqlDbType.Image, cuimage),
                DataAccessLayer.CreateParameter("@City_ID", SqlDbType.Int, cityid),
                DataAccessLayer.CreateParameter("@Cu_ID", SqlDbType.Int, cuid));
            DataAccessLayer.Close();
            return i;
        }

        public static int SP_DeleteCustomer(int cuid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteCustomer", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Cu_ID", SqlDbType.Int, cuid));
            DataAccessLayer.Close();
            return i;
        }
    }
}
