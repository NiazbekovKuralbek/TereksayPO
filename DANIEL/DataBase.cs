using System.Data.SqlClient;

namespace WindowsFormsApp2Tereksay
{
    public class DataBase
    {
        private SqlConnection con =
                    new SqlConnection(@"Data Source=;Initial Catalog=Opt_mebel;Integrated Security=True");
                //Server=BEKZHAN\MURIM;Database=Opt_mebel
                public void openConnection()
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }
                }
        
                public void closeConnection()
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
        
                public SqlConnection getConnection()
                {
                    return con;
                }
    }
}