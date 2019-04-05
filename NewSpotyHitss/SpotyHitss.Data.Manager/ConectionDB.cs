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

        string connectionString = @"Server=HGDLAPCARRASCOJ\SQLEXPRESS;DataBase=Spotify;Trusted_Connection=True";
        //string connectionString = @"Data Source=10.166.143.73\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=dbase;User ID=sa;Password=password";

        public static string GetConnection()
        {
            return "";
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
    }
}