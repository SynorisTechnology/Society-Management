using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace DataLayer
{
    public class DataAccess
    {
        static string strConn = ConfigurationSettings.AppSettings["DBConn"].ToString();
        SqlConnection DbConnection = new SqlConnection(strConn);
        private static SqlConnection DBConn = null;
        public static SqlConnection Connection
        {
            get
            {
                if (DBConn == null || DBConn.ConnectionString == "")
                {
                    DBConn = new SqlConnection(strConn);
                }

                return DBConn;
            }
            set { }
        }

        public static DataSet GetData(string SPName, List<SqlParameter> Parameters)
        {
            using (SqlConnection con = Connection)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = SPName;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = con;

                    if (Parameters != null)
                    {
                        foreach (SqlParameter parameter in Parameters)
                        {
                            cmd.Parameters.Add(parameter);
                        }
                    }

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    DataSet ds = new DataSet();

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    con.Close();
                    return ds;
                }
            }
        }
        public static DataSet GetDataByQery(string Query)
        {
            SqlConnection cn = new SqlConnection();
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        public static OpreationResult ExecuteNonQuery(string SPName, List<SqlParameter> Parameters)
        {
            string message = string.Empty;
            using (SqlConnection con = Connection)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = SPName;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = con;

                    foreach (SqlParameter parameter in Parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }

                    SqlParameter MessageId = new SqlParameter("@ReturnValue", SqlDbType.Int, -1);
                    MessageId.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(MessageId);
                    SqlParameter Message = new SqlParameter("@MessageOut", SqlDbType.Char, 500);
                    Message.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(Message);
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();

                    OpreationResult objOR = new OpreationResult();

                    objOR.ReturnValue = (int)cmd.Parameters["@ReturnValue"].Value;
                    objOR.ReturnMessage = (string)cmd.Parameters["@MessageOut"].Value;

                    con.Close();
                    return objOR;
                }
            }
        }
    }
}
