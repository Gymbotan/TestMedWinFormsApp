using System;
using System.Data;
using System.Data.SQLite;
using TestMedWinFormsApp.DB.Interfaces;
using TestMedWinFormsApp.Entities;

namespace TestMedWinFormsApp.DB
{
    internal class StepsRepository : IStepsRepository
    {
        public DataTable GetFullTable()
        {
            DataTable result = new DataTable();
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                var getAllData = "SELECT * from Steps ORDER BY Id ASC";

                SQLiteCommand command = new SQLiteCommand(getAllData, new SQLiteConnection(connection));

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Steps");

                result = ds.Tables["Steps"];
            }
            return result;
        }

        public void DeleteStepById(int id)
        {
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string deleteMode = "DELETE FROM 'Steps' WHERE Id = @id";

                using (var cmd = new SQLiteCommand(deleteMode, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddStep(Step step)
        {
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string addStep = "INSERT INTO 'Steps' (ModeId, Timer, Destination, Speed, Type, Volume) " +
                    "VALUES (@modeId, @timer, @destination, @speed, @type, @volume)";

                using (var cmd = new SQLiteCommand(addStep, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@modeId", step.ModeId);
                    cmd.Parameters.AddWithValue("@timer", step.Timer);
                    cmd.Parameters.AddWithValue("@destination", step.Destination);
                    cmd.Parameters.AddWithValue("@speed", step.Speed);
                    cmd.Parameters.AddWithValue("@type", step.Type);
                    cmd.Parameters.AddWithValue("@volume", step.Volume);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsStepExist(Step step)
        {
            long result;
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                string isStepExist = "SELECT count(*) from Steps where ModeId = @modeId AND Timer = @timer " +
                    "AND Destination = @destination AND Speed = @speed AND Type = @type AND Volume = @volume";

                using (var cmd = new SQLiteCommand(isStepExist, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@modeId", step.ModeId);
                    cmd.Parameters.AddWithValue("@timer", step.Timer);
                    cmd.Parameters.AddWithValue("@destination", step.Destination);
                    cmd.Parameters.AddWithValue("@speed", step.Speed);
                    cmd.Parameters.AddWithValue("@type", step.Type);
                    cmd.Parameters.AddWithValue("@volume", step.Volume);

                    result = (long)cmd.ExecuteScalar();
                }
            }
            return result > 0;
        }

        public void UpdateStep(Step step)
        {
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                connection.Open();

                string updateMode = "Update 'Steps' SET ModeId = @modeId, Timer = @timer, Destination = @destination, Speed = @speed, Type = @type, Volume = @volume WHERE Id = @id";

                using (var cmd = new SQLiteCommand(updateMode, connection))
                {
                    cmd.Parameters.AddWithValue("@id", step.Id);
                    cmd.Parameters.AddWithValue("@modeId", step.ModeId);
                    cmd.Parameters.AddWithValue("@timer", step.Timer);
                    cmd.Parameters.AddWithValue("@destination", step.Destination);
                    cmd.Parameters.AddWithValue("@speed", step.Speed);
                    cmd.Parameters.AddWithValue("@type", step.Type);
                    cmd.Parameters.AddWithValue("@volume", step.Volume);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
