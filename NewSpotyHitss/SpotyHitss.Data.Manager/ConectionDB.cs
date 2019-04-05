using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SpotyHitss.Data.Objects;

namespace SpotyHitss.Data.Manager
{
    public class ConectionDB
    {

        string connectionString = ConfigurationManager.ConnectionStrings["SqlExpress"].ConnectionString;
        string sqlInsertSong = "SP_InsertSong @Name, @ReleaseYear, @ArtistName, @FileSong";

        public static string GetConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SqlExpress"].ConnectionString;
            return connectionString;
        }

        public List<Song> ListGen (string Genre)
        {
            //var connection = ConfigurationManager.ConnectionStrings["SQLExpress"].ConnectionString;
            List <Song> ListResult = new List<Song>();
            try
            {
                if (null == Genre)
                {
                    throw new ArgumentNullException("Genre");
                }
                using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                {
                    _sqlConn.Open();

                    using (SqlCommand _sqlCommand = new SqlCommand("SP_List_Gen", _sqlConn))
                    {
                        _sqlCommand.CommandType = CommandType.StoredProcedure;

                        _sqlCommand.Parameters.AddWithValue("@Gen_to_List", Genre);


                        using (IDataReader _reader = _sqlCommand.ExecuteReader(CommandBehavior.CloseConnection & CommandBehavior.SingleRow))
                        {
                            while (_reader.Read())
                            {
                                ListResult.Add(new Song {Id = _reader.GetInt32(0),
                                    Name = _reader.GetString(1),
                                    Year = _reader.GetInt32(2),
                                    Genre = _reader.GetString(3)});
                            }
                        };

                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListResult;

        }

        public OperationResult<int> InsertSong(Song song)
        {
            OperationResult<int> _opResult = new OperationResult<int>()
            {
                OpStatus = 0,
                OpMesssage = "An error occur in the execution",
                OpResult = -1
            };

            if(song != null)
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    using(SqlCommand _sqlCommand = new SqlCommand(this.sqlInsertSong, _conn))
                    {
                        _sqlCommand.Parameters.Add("Name", SqlDbType.VarChar);
                        _sqlCommand.Parameters.Add("ReleaseYear", SqlDbType.Int);
                        _sqlCommand.Parameters.Add("ArtistName", SqlDbType.VarChar);
                        _sqlCommand.Parameters.Add("FileSong", SqlDbType.VarBinary);

                        _sqlCommand.Parameters["Name"].Value = song.Name;
                        _sqlCommand.Parameters["ReleaseYear"].Value = song.Year;
                        _sqlCommand.Parameters["ArtistName"].Value = song.ArtistName;
                        _sqlCommand.Parameters["FileSong"].Value = song.DataSong;

                        using (IDataReader _reader = _sqlCommand.ExecuteReader(CommandBehavior.CloseConnection & CommandBehavior.SingleRow))
                        {
                            if (_reader.Read())
                            {
                                _opResult.OpStatus = (Byte)_reader[0];
                                _opResult.OpMesssage = (string)_reader[1];
                                _opResult.OpResult = (int)_reader[2];
                            }
                        }
                    }

                }
            }
            return _opResult;
        }
    }
}