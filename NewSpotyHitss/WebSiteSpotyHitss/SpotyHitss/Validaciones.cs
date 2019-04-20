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
            Result _obj = new Result();
            _obj._ID = 0;
            _obj._result = false;
            if (string.IsNullOrEmpty(song.Trim()) || string.IsNullOrEmpty(connectionString.Trim()))
            {
                
                return _obj;

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
                        while (_sqlReader.Read())
                        {
                            _obj._ID = int.Parse(_sqlReader.GetValue(0).ToString());
                            _obj._result = true;
                            return _obj;
                        }
                    }
                    return _obj;
                    _sqlConn.Close();
                }
            }
        }
        public static Result ValidateIfPlaylistExist(string playlist, string connectionString)
        {
            Result _obj = new Result();
            _obj._ID = 0;
            _obj._result = false;
            if (string.IsNullOrEmpty(playlist.Trim()) || string.IsNullOrEmpty(connectionString.Trim()))
            {
                return _obj;
            }
            int temporal;
            string Query;
            if (int.TryParse(playlist, out temporal))
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
                        while (_sqlReader.Read())
                        {
                            _obj._ID = int.Parse(_sqlReader.GetValue(0).ToString());
                            _obj._result = true;
                            return _obj;
                        }
                    }
                    return _obj;
                    _sqlConn.Close();
                }
            }
        }
        public static bool ValidateIfSongAreIntoPlaylist(int playlist,int song, string connectionString)
        {
               
            string Query = "SELECT * FROM PlaylistSong WHERE ID_Playlist=" + playlist +" AND ID_Song="+song;          
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