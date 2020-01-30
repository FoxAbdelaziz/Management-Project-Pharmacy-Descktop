using System;
using Management_Project_Pharmacy.DAL;
using System.Data;

namespace Management_Project_Pharmacy.BL
{
    class ClassMassege
    {
        public static int SP_InsertMasege(string MsgTital,string MsgDetail,DateTime MDate,string UName,string ReadOrNoRead)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_InsertMasege",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@MassegeTitle",SqlDbType.NVarChar,MsgTital),
                DataAccessLayer.CreateParameter("@MassegeDetails",SqlDbType.NVarChar,MsgDetail),
                DataAccessLayer.CreateParameter("@MDate",SqlDbType.Date,MDate),
                DataAccessLayer.CreateParameter("@U_Name",SqlDbType.NVarChar,UName),
                DataAccessLayer.CreateParameter("@ReadOrNoRead",SqlDbType.NVarChar,ReadOrNoRead));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_SelectCountMsg(string UName,string readornoread)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SelectCountMsg",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@UName",SqlDbType.NVarChar,UName),
                DataAccessLayer.CreateParameter("@ReadOrNoRead",SqlDbType.NVarChar,readornoread));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_ShowMessageByName(string UName)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_ShowMessageByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@U_Name", SqlDbType.NVarChar, UName));
                DataAccessLayer.Close();
            return dt;
        }

        public static int SP_UpdateMessageByName(string UName, string ReadOrNoRead)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UpdateMessageByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@U_Name", SqlDbType.NVarChar, UName),
                DataAccessLayer.CreateParameter("@ReadOrNoRead", SqlDbType.NVarChar, ReadOrNoRead));
            DataAccessLayer.Close();
            return i;
        }

    }
}
