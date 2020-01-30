using System.Data;
using Management_Project_Pharmacy.DAL;
namespace Management_Project_Pharmacy.BL
{
    class ClassActiveMatrile
    {
        public static int SP_ActiveMatrileInsert(string Am_Name,string Am_Desc)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertActiveMatrile", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Am_Name",SqlDbType.NVarChar,Am_Name),
                DataAccessLayer.CreateParameter("@AM_Description",SqlDbType.NVarChar,Am_Desc));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_SelectAallActiveMatrile()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllActiveMatrile", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }public static DataTable SP_SearchActiveMatrile(string search)
        {

            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchActiveMatrile", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_UpdateActvieMatirel(int Am_ID,string Am_Name,string Am_Desc) {

            DataAccessLayer.Open();
            int i=DataAccessLayer.ExecuteNonQuery("SP_UpdateActvieMatirel", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Am_ID", SqlDbType.Int,Am_ID),
                DataAccessLayer.CreateParameter("@Am_Name", SqlDbType.NVarChar, Am_Name),
                DataAccessLayer.CreateParameter("@Am_Desc", SqlDbType.NVarChar,Am_Desc));
            DataAccessLayer.Close();
            return i;
        }

        public static int SP_DeleteActiveMatrile(int Am_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteActiveMatrile", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Am_ID", SqlDbType.Int,Am_ID));
            DataAccessLayer.Close();
            return i;
        }
    }
}
