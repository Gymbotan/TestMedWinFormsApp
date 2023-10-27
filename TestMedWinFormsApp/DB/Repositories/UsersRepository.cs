using System;
using System.Data.SQLite;
using TestMedWinFormsApp.DB.Interfaces;

namespace TestMedWinFormsApp.DB.Repositories
{
    internal class UsersRepository : IUsersRepository
    {
        public void AddUser(string login, string password)
        {
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string addUser = "INSERT INTO 'Users' ('Login', 'Password') VALUES (@login, @pass)";

                using (var cmd = new SQLiteCommand(addUser, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pass", password);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsUserExist(string login, string password)
        {
            long result;

            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string isUserExists = "SELECT count(*) from Users where Login = @login AND Password = @pass";

                using (var cmd = new SQLiteCommand(isUserExists, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pass", password);

                    result = (long) cmd.ExecuteScalar();
                }
            }
            return result > 0;
        }

        public bool IsLoginExist(string login)
        {
            long result;

            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string addUser = "SELECT count(*) from Users where Login = @login";

                using (var cmd = new SQLiteCommand(addUser, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@login", login);

                    result = (long)cmd.ExecuteScalar();                    
                }
            }
            return result > 0;
        }
    }
}
