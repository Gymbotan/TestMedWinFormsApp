using System;
using System.Data;
using System.Data.SQLite;
using TestMedWinFormsApp.DB.Interfaces;
using TestMedWinFormsApp.Entities;
using TestMedWinFormsApp.Exceptions;

namespace TestMedWinFormsApp.DB
{
    internal class ModesRepository : IModesRepository
    {
        public DataTable GetFullTable()
        {
            DataTable result = new DataTable();
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                var getAllData = "SELECT * from Modes ORDER BY Id ASC";

                SQLiteCommand command = new SQLiteCommand(getAllData, connection);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Modes");

                result = ds.Tables["Modes"];
            }
            return result;
        }

        public void DeleteModeById(int id)
        {
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string deleteMode = "DELETE FROM 'Modes' WHERE Id = @id";

                using (var cmd = new SQLiteCommand(deleteMode, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddMode(Mode mode)
        {
            if (IsModeExist(mode))
            {
                throw new DBException($"A mode with name = {mode.Name}, max bottle number = {mode.MaxBottleNumber} " +
                    $"and max tips = {mode.MaxUsedTips} is already exists");
            }
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string addMode = "INSERT INTO 'Modes' ('Name', 'MaxBottleNumber', 'MaXUsedTips') VALUES (@name, @bottles, @tips)";

                using (var cmd = new SQLiteCommand(addMode, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@name", mode.Name);
                    cmd.Parameters.AddWithValue("@bottles", mode.MaxBottleNumber);
                    cmd.Parameters.AddWithValue("@tips", mode.MaxUsedTips);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsModeExist(Mode mode)
        {
            long result;
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string isModeExist = "SELECT count(*) from Modes where Name = @name AND MaxBottleNumber = @bottles AND MaXUsedTips = @tips";

                using (var cmd = new SQLiteCommand(isModeExist, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@name", mode.Name);
                    cmd.Parameters.AddWithValue("@bottles", mode.MaxBottleNumber);
                    cmd.Parameters.AddWithValue("@tips", mode.MaxUsedTips);

                    result = (long)cmd.ExecuteScalar();
                }
            }
            return result > 0;
        }

        public void UpdateMode(Mode mode) 
        {
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string updateMode = "Update 'Modes' SET Name = @name, MaxBottleNumber = @bottles, MaXUsedTips = @tips WHERE Id = @id";

                using (var cmd = new SQLiteCommand(updateMode, connection))
                {
                    cmd.Parameters.AddWithValue("@id", mode.Id);
                    cmd.Parameters.AddWithValue("@name", mode.Name);
                    cmd.Parameters.AddWithValue("@bottles", mode.MaxBottleNumber);
                    cmd.Parameters.AddWithValue("@tips", mode.MaxUsedTips);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
