using System.Data.SqlClient;

namespace System.Datas
{
    public class Connection
    {
        private string DB;
        private string SV;
        private static Connection CON = null;
        private Connection()
        {
            this.DB = "DBSystem";
            this.SV = "localhost";
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection Chain = new SqlConnection();
            try
            {
                Chain.ConnectionString = $"Server={this.SV};Database={this.DB};Integrated Security=SSPI;";
            }
            catch (SqlException ex)
            {
                Chain = null;
                throw ex;
                throw new Exception(ex.Message);
            }
            return Chain;
        }
        public static Connection GetInstance()
        {
            if (CON == null)
            {
                CON = new Connection();
            }
            return CON;
        }
    }
}
