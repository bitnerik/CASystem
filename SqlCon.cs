using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CASystem
{
    public static class SqlCon
    {
        public static SqlConnection SqlConnection { get; }
        static SqlCon()
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CADB"].ConnectionString);
            Initialise();
        }
        static void Initialise()
        {
            SqlConnection.Open();

            if (SqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Database connection failure. Check Database connection path");
            }
        }
    }
}
