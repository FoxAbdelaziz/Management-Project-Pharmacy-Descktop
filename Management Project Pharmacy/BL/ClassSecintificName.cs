using System.Data;
using Management_Project_Pharmacy.DAL;
namespace Management_Project_Pharmacy.BL
{
    class ClassSecintificName
    {
        public static int SP_InsertSecintificName(string Sn_name)
        {
            DataAccessLayer.Open();
            int i= DataAccessLayer.ExecuteNonQuery("SP_InsertSecintificName",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Sn_Name", SqlDbType.NVarChar,Sn_name));
            DataAccessLayer.Close();
            return i;
            
        }
        public static DataTable SP_SelectAllSecintificName()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllSecintificName", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable SP_SearchSecintificName(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchSecintificName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search",SqlDbType.NVarChar,Search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_UpdateSecintifcName(int Sn_ID,string Sn_Name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateSecintifcName",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Sn_ID",SqlDbType.Int,Sn_ID),
                DataAccessLayer.CreateParameter("@Sn_Name",SqlDbType.NVarChar,Sn_Name));
            DataAccessLayer.Close();
            return i;
        }
        public static int SP_DeleteSecintifcName(int Sn_ID)
        {
            DataAccessLayer.Open();

            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteSecintifcName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Sn_ID", SqlDbType.Int, Sn_ID));
            DataAccessLayer.Close();
            return i;
        }
    }
}