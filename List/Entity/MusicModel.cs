using DataAccessLibrary;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Entity
{
    class MusicModel
    {
        public static void AddData(Song song)
        {
            using (SqliteConnection db = new SqliteConnection(DataAccess.SQL_connection_string))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText =
                    " INSERT INTO SongAnime(songthumnail,songname,songt,singer) VALUES (@Song_name,@Song_Thumnail,@Songt_name,@Singer_name);";
                insertCommand.Parameters.AddWithValue("@Song_name", song.songname);
                insertCommand.Parameters.AddWithValue("@Song_Thumnail", song.songthumnail);
                insertCommand.Parameters.AddWithValue("@Songt_name", song.songt);
                insertCommand.Parameters.AddWithValue("@Singer_name", song.singer);

                insertCommand.ExecuteReader();

            }

        }
    }
}
