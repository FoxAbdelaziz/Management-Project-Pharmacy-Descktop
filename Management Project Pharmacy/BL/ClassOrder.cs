using System;
using System.Data;
using Management_Project_Pharmacy.DAL;

namespace Management_Project_Pharmacy.BL
{
    class ClassOrder
    {
        public static int SP_InsertOrder(DateTime OrderDate,string Total,int cu_id,string Sellername, DataTable TypeOrderDetails)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertOrder",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@OrderDate",SqlDbType.Date,OrderDate),
                DataAccessLayer.CreateParameter("@Total",SqlDbType.VarChar,Total),
                DataAccessLayer.CreateParameter("@Cu_ID",SqlDbType.Int,cu_id),
                DataAccessLayer.CreateParameter("@Seler_Name",SqlDbType.NVarChar,Sellername),
                DataAccessLayer.CreateParameter("@TypeOrderDetails",SqlDbType.Structured,TypeOrderDetails));
            DataAccessLayer.Close();
            return i;
        }


        public static DataTable SP_SelectAllOrders()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllOrders", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int max_id()
        {
            DataAccessLayer.Open();
            int max = int.Parse(DataAccessLayer.ExcuteScaler("select max(Order_ID) from TblOrders",CommandType.Text).ToString());
            DataAccessLayer.Close();
            return max;
        }
    }
}
