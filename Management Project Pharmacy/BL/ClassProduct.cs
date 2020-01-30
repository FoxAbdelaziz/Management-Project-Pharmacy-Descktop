using System.Data;
using Management_Project_Pharmacy.DAL;
namespace Management_Project_Pharmacy.BL
{
    class ClassProduct
    {
        public static DataTable SP_FillCategoryComboBox()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FillCategoryComboBox",CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_FillAcviteMatrileComboBox()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FillAcviteMatrileComboBox", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_FillSecintificNameComboBox()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FillSecintificNameComboBox", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_InsertProduct(string P_Name,string P_Description,byte[] P_Image,string BuyPrice,string SellPrice,int Cat_ID,int Am_ID,int Sn_ID,string Barcode)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertProduct", CommandType.StoredProcedure,
               DataAccessLayer.CreateParameter("@P_Name", SqlDbType.NVarChar, P_Name),
               DataAccessLayer.CreateParameter("@P_Description", SqlDbType.NVarChar, P_Description),
               DataAccessLayer.CreateParameter("@P_Image", SqlDbType.Image, P_Image),
               DataAccessLayer.CreateParameter("@BuyPrice", SqlDbType.VarChar, BuyPrice),
               DataAccessLayer.CreateParameter("@SellPrice", SqlDbType.VarChar, SellPrice),
               DataAccessLayer.CreateParameter("@Cat_ID", SqlDbType.Int, Cat_ID),
               DataAccessLayer.CreateParameter("@Am_ID", SqlDbType.Int, Am_ID),
               DataAccessLayer.CreateParameter("@Sn_ID", SqlDbType.Int, Sn_ID),
               DataAccessLayer.CreateParameter("@Barcode", SqlDbType.VarChar, Barcode)); 
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SelectAllProduct()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllProduct",CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SearchProduct(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SearchProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search",SqlDbType.NVarChar,Search));
            DataAccessLayer.Close();
            return dt;
        }
        public static byte[] SP_GetImageProduct(int ID )
        {
            //  (byte[]) >>> كاست  Cast تحويل 
            DataAccessLayer.Open();
            byte[] arr=(byte[]) DataAccessLayer.ExcuteScaler("SP_GetImageProduct",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID",SqlDbType.BigInt,ID));
            DataAccessLayer.Close();
            return arr;
        }

        public static DataTable SP_GetExpiredDateProduct(int ID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_GetExpiredDateProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, ID));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_DeleteProduct(int P_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DeleteProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@P_ID", SqlDbType.BigInt, P_ID));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_GetSelectedProduct(int P_ID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_GetSelectedProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@P_ID", SqlDbType.Int, P_ID));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SelectProductDetails()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectProductDetails", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }


        public static int SP_UpdateProduct(int P_ID,string P_Name, string P_Description, byte[] P_Image, string BuyPrice, string SellPrice, int Cat_ID, int Am_ID, int Sn_ID, string Barcode)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateProduct", CommandType.StoredProcedure,
               DataAccessLayer.CreateParameter("@P_ID", SqlDbType.BigInt, P_ID),
               DataAccessLayer.CreateParameter("@P_Name", SqlDbType.NVarChar, P_Name),
               DataAccessLayer.CreateParameter("@P_Description", SqlDbType.NVarChar, P_Description),
               DataAccessLayer.CreateParameter("@P_Image", SqlDbType.Image, P_Image),
               DataAccessLayer.CreateParameter("@BuyPrice", SqlDbType.VarChar, BuyPrice),
               DataAccessLayer.CreateParameter("@SellPrice", SqlDbType.VarChar, SellPrice),
               DataAccessLayer.CreateParameter("@Cat_ID", SqlDbType.Int, Cat_ID),
               DataAccessLayer.CreateParameter("@Am_ID", SqlDbType.Int, Am_ID),
               DataAccessLayer.CreateParameter("@Sn_ID", SqlDbType.Int, Sn_ID),
               DataAccessLayer.CreateParameter("@Barcode", SqlDbType.VarChar, Barcode));
            DataAccessLayer.Close();
            return i;
        }
    }
}
