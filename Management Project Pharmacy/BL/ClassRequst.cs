using System;
using Management_Project_Pharmacy.DAL;
using System.Data;

namespace Management_Project_Pharmacy.BL
{
    class ClassRequst
    {
        public static int SP_InsertRequst(DateTime Req_Date,string Total,int Su_ID,string Buyer_Name,DataTable TypeRequstDetails,DataTable TypeExpiredDate)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertRequst",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Req_Date", SqlDbType.Date, Req_Date),
                DataAccessLayer.CreateParameter("@Total",SqlDbType.VarChar,Total),
                DataAccessLayer.CreateParameter("@Su_ID",SqlDbType.Int,Su_ID),
                DataAccessLayer.CreateParameter("@Buyer_Name",SqlDbType.NVarChar,Buyer_Name),
                DataAccessLayer.CreateParameter("@TypeRequstDetails",SqlDbType.Structured,TypeRequstDetails),
                DataAccessLayer.CreateParameter("@TypeExpiredDate",SqlDbType.Structured,TypeExpiredDate));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SelectAllRequest()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectAllRequest", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static object Max_ReqID()
        {
            DataAccessLayer.Open();
            object ob = DataAccessLayer.ExcuteScaler("Select max(Req_ID) From TblRequsts",CommandType.Text);
            DataAccessLayer.Close();
            return ob;
        }
    }
}
