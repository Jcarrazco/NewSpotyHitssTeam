using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SpotyHitss.Data.Manager
{
    public class UserDataManager
    {
        //Conexion para SQL 

        string connectionString = ConfigurationManager.ConnectionStrings["LocalSpotyHitss"].ConnectionString;
        string MasSonada = "Cancion_mas_sonada";
        string CancionPlayList = "Cancion_en_que_playlist";
        /*static UserDatamanager()
        {

        }*/
        public List<string> CancionEnMasPlaylist(int SongData)
        {
            List<string> canciones = new List<string>();
            try
            {

                using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                {
                    _sqlConn.Open();

                    using (SqlCommand _sqlCommand = new SqlCommand(CancionPlayList, _sqlConn))
                    {
                        _sqlCommand.CommandType = CommandType.StoredProcedure;
                        _sqlCommand.Parameters.AddWithValue("@Song", SongData);



                        using (IDataReader _reader = _sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (_reader.Read())
                            {

                                canciones.Add((string)_reader[0]);

                            }
                        }
                        ;

                    }
                }

            }
            catch (Exception ex)
            {


            }

            return canciones;
        }

        //\\\\\\\{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}\\\\\\\//

        public List<int> CancionMasSonada()
        {
            List<int> songs = new List<int>();

            try
            {
                using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                {
                    _sqlConn.Open();

                    using (SqlCommand _sqlCommand = new SqlCommand(MasSonada, _sqlConn))
                    {

                        using (IDataReader _reader = _sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (_reader.Read())
                            {
                                songs.Add((int)_reader[0]);
                                songs.Add((int)_reader[1]);
                            }
                        }
                        ;
                    }
                }
            }
            catch (Exception ex)
            { }
            return songs;

        }


    }
}

