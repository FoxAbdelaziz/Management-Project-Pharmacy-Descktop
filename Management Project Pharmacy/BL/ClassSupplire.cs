using System.Data;
using Management_Project_Pharmacy.DAL;

namespace Management_Project_Pharmacy.BL
{
    class ClassSupplire
    {
        public static int SP_InsertSupplire(string Su_name,string Su_Mobile)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertSupplire", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Su_Name", SqlDbType.NVarChar, Su_name),
                DataAccessLayer.CreateParameter("@Su_Mobile", SqlDbType.VarChar, Su_Mobile));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SelcetAllSupplier()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelcetAllSupplier", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SearchSupplier(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchSupplier", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search",SqlDbType.NVarChar,Search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SelectByIDSupplire(int Su_ID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectByIDSupplire", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Su_ID", SqlDbType.Int, Su_ID));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_UpdateSupllire(int Su_ID,string Su_name, string Su_Mobile)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateSupllire", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Su_ID", SqlDbType.Int, Su_ID),
                DataAccessLayer.CreateParameter("@Su_Name", SqlDbType.NVarChar, Su_name),
                DataAccessLayer.CreateParameter("@Su_Mobile", SqlDbType.VarChar, Su_Mobile));
            DataAccessLayer.Close();
            return i;
        }
        public static int SP_DeleteSupllire(int Su_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteSupllire", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Su_ID", SqlDbType.Int, Su_ID));
                DataAccessLayer.Close();
            return i;
        }
    }
}
