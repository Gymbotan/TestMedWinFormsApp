using System;

namespace TestMedWinFormsApp.DB
{
    internal static class DBInfo
    {
        private static readonly string dbAddress = "database.db";
        private static readonly string connectionString = "Data Source=database.db";

        public static string ConnectionString { get {  return connectionString; } }
        public static string DatabaseAddress { get {  return dbAddress; } }
    }
}
