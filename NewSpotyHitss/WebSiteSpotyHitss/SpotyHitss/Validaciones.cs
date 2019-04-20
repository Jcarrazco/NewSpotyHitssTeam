using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteSpotyHitss.SpotyHitss
{
    public static class Validaciones
    {
        public static Result ValidateIfSongExist(string song, string connectionString)
        {
            Resultado
            if (string.IsNullOrEmpty(song.Trim()) || string.IsNullOrEmpty(connectionString.Trim()))
            {
               _obj.
            }
            int temporal;
            string Query;
            if (int.TryParse(song, out temporal))
            {
                Query = "SELECT * FROM Song WHERE ID=" + song;
            }
            else
            {
                 Query = "SELECT * FROM Song WHERE Name='" + song + "'";
            }
            using (SqlConnection _sqlConn = new SqlConnection(connectionString))
            {
                _sqlConn.Open();
                using (SqlCommand _sqlCommand = new SqlCommand(Query, _sqlConn))
                {
                    SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                    if (_sqlReader.HasRows)
                    {
                        return true;
                    }
                    return false;
                    _sqlConn.Close();
                }
            }
        }
        public static bool ValidateIfPlaylistExist(string playlist, string connectionString)
        {
            if (string.IsNullOrEmpty(playlist.Trim()) || string.IsNullOrEmpty(connectionString.Trim()))
            {
                return false;
            }
            int temporal;
            string Query;
            if (int.TryParse(song, out temporal))
            {
                Query = "SELECT * FROM Playlist WHERE ID=" + playlist;
            }
            else
            {
                Query = "SELECT * FROM Playlist WHERE Name='" + playlist + "'";
            }
            using (SqlConnection _sqlConn = new SqlConnection(connectionString))
            {
                _sqlConn.Open();
                using (SqlCommand _sqlCommand = new SqlCommand(Query, _sqlConn))
                {
                    SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                    if (_sqlReader.HasRows)
                    {
                        return true;
                    }
                    return false;
                    _sqlConn.Close();
                }
            }
        }
    }
}