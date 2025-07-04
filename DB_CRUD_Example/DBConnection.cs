

namespace DB_CRUD_Example
{
    class DBConnection
    {
         
        public static string sqlServerConnString = "Data Source=DESKTOP-7IRU44D;Initial Catalog=BITCRUD;Integrated Security=True";

        public static string connectionString = Properties.Settings.Default.CRUD_dbConnectionString ;

      	public static string mySqlConnectionString = "server=localhost;database=users;user=root;password=";

    }
}
