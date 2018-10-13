using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace DataAccessLibrary
{
    public static class DataAccess
    {

        public static string SQL_connection_string = "Filename=sqliteSample.db";
        public static void InitializeDatabase()
        {
            using (SqliteConnection db =
                new SqliteConnection(SQL_connection_string))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS SongAnime (id  INTEGER PRIMARY KEY, " +
                    "songname NVARCHAR(2048) ,songthumnail NVARCHAR(2048) ," +
                    "singer NVARCHAR(50),songt NVARCHAR(50) )";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
    }
}