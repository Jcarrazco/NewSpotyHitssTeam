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

        //Lista los resultados de una busqueda de canciones por genero
        public OperationResult<int> ADDALBUM(string Album_Name, int Album_Year)
        {
            OperationResult<int> _opResult = new OperationResult<int>()
            {
                OpStatus = 0,
                OpMesssage = "ALL RIGHT",
                OpResult = -1
            };
            try
            {
                if (null == Album_Name)
                {
                    throw new ArgumentNullException("Album");
                }
                using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                {
                    _sqlConn.Open();

                    using (SqlCommand _sqlCommand = new SqlCommand("sp_Insertar_Album", _sqlConn))
                    {
                        _sqlCommand.CommandType = CommandType.StoredProcedure;

                        _sqlCommand.Parameters.AddWithValue("@Name", Album_Name);

                        _sqlCommand.Parameters.AddWithValue("@ReleaseYear", Album_Year);

                        _sqlCommand.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {
                _opResult.OpMesssage = "Bad Way";
                _opResult.OpResult = -2;
                throw ex;
            }
            return _opResult;
        }

        public OperationResult<List<Song>> ListGen(string Genre)
        {
            OperationResult<List<Song>> _opResult = new OperationResult<List<Song>>()
            {
                OpStatus = 0,
                OpMesssage = "An error occur in the execution",
                OpResult = new List<Song>()
            };

            try
            {
                if (null == Genre)
                {
                    //Excepcion no se introdujo un genero
                    throw new ArgumentNullException("Genre");
                }
                using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                {
                    _sqlConn.Open();

                    using (SqlCommand _sqlCommand = new SqlCommand("SP_List_Gen", _sqlConn))
                    {
                        _sqlCommand.CommandType = CommandType.StoredProcedure;

                        //Store procedure de BD que regresa la lista de canciones
                        _sqlCommand.Parameters.AddWithValue("@Gen_to_List", Genre);


                        using (IDataReader _reader = _sqlCommand.ExecuteReader(CommandBehavior.CloseConnection & CommandBehavior.SingleRow))
                        {
                            while (_reader.Read())
                            {
                                //agrega a una lista los resultados uno a uno
                                _opResult.OpResult.Add(new Song
                                {
                                    Id = _reader.GetInt32(0),
                                    Name = _reader.GetString(1),
                                    Year = _reader.GetInt32(2),
                                    Genre = _reader.GetString(3)
                                });
                            }
                        };

                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _opResult;

        }

        public List<SongArtist> ListArtist(string Artist)
        {
            //var connection = ConfigurationManager.ConnectionStrings["SQLExpress"].ConnectionString;
            List<SongArtist> ListResult = new List<SongArtist>();
            try
            {
                if (null == Artist)
                {
                    throw new ArgumentNullException("Artist");
                }
                using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                {
                    _sqlConn.Open();

                    using (SqlCommand _sqlCommand = new SqlCommand("SP_Select_By_Artist", _sqlConn))
                    {
                        _sqlCommand.CommandType = CommandType.StoredProcedure;

                        _sqlCommand.Parameters.AddWithValue("@Artist_2List", Artist);


                        using (IDataReader _reader = _sqlCommand.ExecuteReader(CommandBehavior.CloseConnection & CommandBehavior.SingleRow))
                        {
                            while (_reader.Read())
                            {
                                ListResult.Add(new SongArtist
                                {
                                    ID_Artist = _reader.GetInt32(0),
                                    Artist_Name = _reader.GetString(1),
                                    ID_Song = _reader.GetInt32(2),
                                    Song_Name = _reader.GetString(3)
                                });
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

            if (song != null)
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    using (SqlCommand _sqlCommand = new SqlCommand(this.sqlInsertSong, _conn))
                    {
                        _sqlCommand.Parameters.Add("Name", SqlDbType.VarChar);
                        _sqlCommand.Parameters.Add("ReleaseYear", SqlDbType.Int);
                        _sqlCommand.Parameters.Add("ArtistName", SqlDbType.VarChar);
                        _sqlCommand.Parameters.Add("FileSong", SqlDbType.VarBinary);

                        _sqlCommand.Parameters["Name"].Value = song.Name;
                        _sqlCommand.Parameters["ReleaseYear"].Value = song.Year;
                        _sqlCommand.Parameters["ArtistName"].Value = song.ArtistName;
                        _sqlCommand.Parameters["FileSong"].Value = song.DataSong ?? new Byte[1];

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