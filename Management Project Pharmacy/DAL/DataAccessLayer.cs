using System;
using System.Data;
using System.Data.SqlClient;

namespace Management_Project_Pharmacy.DAL
{
    class DataAccessLayer
    {
   
        //  public static string con = @"Data Source=.;Initial Catalog=APharmacy_DB;Integrated Security=True";
        public static string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=APharmacy_DB;User ID=AbdelazizServer;Password=AbdelazizServer";
        
        
        public static SqlConnection cn;
        public static int ErrorCode;
        public static string ErrorMsg;
        // Open the coonection      
        public static void Open()
        {
            cn = new SqlConnection(con);
            cn.Open();
        }
        // Close the coonection      
        public static void Close()
        {
            cn = new SqlConnection(con);
            cn.Close();
        }
        //return one value
        public static object ExcuteScaler(string query, CommandType type, params SqlParameter[] arr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddRange(arr);
                cmd.CommandType = type;
                object o = cmd.ExecuteScalar();
                return o;
            }
            catch (SqlException ex)
            {
                ErrorMsg = ex.Message;
                ErrorCode = ex.ErrorCode;
                return null;
            }
   
        }

        // return thte number of row with deleted , updated , insertd
        public static int ExecuteNonQuery(string query, CommandType type, params SqlParameter[] arr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = type;
                cmd.Parameters.AddRange(arr);
                int n = cmd.ExecuteNonQuery();
                return n;
            }
            catch (SqlException ex)
            {
                ErrorMsg = ex.Message;
                ErrorCode = ex.ErrorCode;
                return 0;
            }  

   
        }
        // return table
        public static DataTable ExecuteTable(string query, CommandType type, params SqlParameter[] arr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = type;
                cmd.Parameters.AddRange(arr);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                ErrorMsg = ex.Message;
                ErrorCode = ex.ErrorCode;
                return null;
            }
        }
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            //return parameter
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;
        }
    }
}
