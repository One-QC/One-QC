using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace One_QC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            string ConnectionString = One_QC.Properties.Settings.Default.SQL_OneQCConnectionString;


            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());

            }
        }
    }
}
