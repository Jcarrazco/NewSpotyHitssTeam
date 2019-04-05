using DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class Connection
    {
      
        string connectionString = @"Server=HGDLAPOLMEDOOR\SQLEXPRESS;;DataBase=Spotify;Trusted_Connection=True";
     
        public List<Album> ListGen(string _Album)
        {
            List<Album> ListResult = new List<Album>();
            try
            {
                if (null == _Album)
                {
                    throw new ArgumentNullException("_Album");
                }
                using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                {
                    _sqlConn.Open();

                    using (SqlCommand _sqlCommand = new SqlCommand("sp_Insertar_Album", _sqlConn))
                    {
                        _sqlCommand.CommandType = CommandType.StoredProcedure;

                        _sqlCommand.Parameters.AddWithValue("@sp_Insertar_Album", _Album);


                        using (IDataReader _reader = _sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection & System.Data.CommandBehavior.SingleRow))
                        {
                            while (_reader.Read())
                            {
                                ListResult.Add(new Album
                                {
                                    Id = _reader.GetInt32(0),
                                    Name = _reader.GetString(1),
                                    Year = _reader.GetInt32(2)
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
