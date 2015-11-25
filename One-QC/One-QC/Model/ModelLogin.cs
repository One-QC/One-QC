using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_QC.Model
{
    class ModelLogin
    {

        public DataSet loginAuthentication(String userId, String pass)
        {
            string connectionString = One_QC.Properties.Settings.Default.SQL_OneQCConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("OneQC_loginCheck",conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@cUserId",SqlDbType.NVarChar).Value = userId;
            cmd.Parameters.Add("@cUserPass", SqlDbType.NVarChar).Value = pass;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;


        }
    }
}
