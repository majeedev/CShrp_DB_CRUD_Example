
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
namespace DB_CRUD_Example
{
    class User
    {


        static string myConn = Properties.Settings.Default.CRUD_dbConnectionString;
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        private const string selectQuery = "Select id as ID , user_id as UserId ,email as Email, address as Address from Users";
        private const string InserQuery = "Insert into Users(user_id  ,user_pass, email ,address) Values(@UserId , @UserPass,@Email,@Address)";
        private const string UpdateQuery = "Update Users set user_id=@UserId, user_pass=@UserPass ,email =@Email , address= @Address where id=@ID";
        private const string DeleteQuery = "Delete from Users where id=@ID";

       
        public static DataTable GetUsers()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(selectQuery, con))
                {
                    
                    Console.Write(selectQuery);
                     
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }


        public bool InsertUser(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InserQuery, con))
                {
                    com.Parameters.AddWithValue("@UserId", user.UserId);
                    com.Parameters.AddWithValue("@UserPass", user.UserPass);
                    com.Parameters.AddWithValue("@Email", user.Email);
                    com.Parameters.AddWithValue("@Address", user.Address);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool UpdateUser(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@Id", user.Id);
                    com.Parameters.AddWithValue("@UserId", user.UserId);
                    com.Parameters.AddWithValue("@UserPass", user.UserPass);
                    com.Parameters.AddWithValue("@Email", user.Email);
                    com.Parameters.AddWithValue("@Address", user.Address);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool DeletetUser(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", user.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}