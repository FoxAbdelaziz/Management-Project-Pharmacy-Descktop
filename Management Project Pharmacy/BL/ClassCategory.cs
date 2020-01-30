using System;
using Management_Project_Pharmacy.DAL;
using System.Data;

namespace Management_Project_Pharmacy.BL
{
    class ClassCategory
    {
        public static int SP_InsertCategory(string CatName)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertCategory",System.Data.CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Cat_Name ", SqlDbType.NVarChar,CatName));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_SelectAllCategory()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllCategory",CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;

        }
        public static int SP_UpdateCategory(string CatName,int CatID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateCategory",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CatName",SqlDbType.NVarChar,CatName),
                DataAccessLayer.CreateParameter("@CatID", SqlDbType.Int,CatID));
            DataAccessLayer.Close();
            return i;
        }
        public static int SP_DeleteCategory(int CatID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteCategory", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CatID",SqlDbType.Int,CatID));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_SearchCategory(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchCategory", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.NVarChar,Search));
            DataAccessLayer.Close();
            return dt;

        }
    }
}
