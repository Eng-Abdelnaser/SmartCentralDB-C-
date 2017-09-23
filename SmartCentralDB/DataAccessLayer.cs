using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SmartCentralDB
{
    class DataAccessLayer
    {

        SqlConnection sqlconnection;
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(Properties.Settings.Default.ConctToDataBase);
        }
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        public DataTable SelectData(string Stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_Procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExecuteCommand(string Stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_Procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
