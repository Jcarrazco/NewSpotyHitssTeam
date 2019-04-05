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

        string connectionString = @"Server=HGDLAPPEREZLX\SQLEXPRESS;DataBase=Spotify;Trusted_Connection=True";
        //string connectionString = @"Data Source=10.166.143.73\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=dbase;User ID=sa;Password=password";

        public static string GetConnection()
        {
            return "";
        }

        public List<SongArtist> ListArtist (string Artist)
        {
            //var connection = ConfigurationManager.ConnectionStrings["SQLExpress"].ConnectionString;
            List <SongArtist> ListResult = new List<SongArtist>();
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
                                ListResult.Add(new SongArtist {
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
    }
}