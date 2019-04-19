using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using Academy.Apis.Common;

namespace Academy.Apis.Data.DataManagers
{
    public class UserDatamanager
    {
        string connectionString = "Server=HGDLAPARRACS\\SQLEXPRESS ;DataBase=Spotify35; Trusted_Connection=True";
        string createUser = "SP_Compartir_Playlist @User_ID,  @Playlist_ID ";
        static UserDatamanager()
        {

        }
        /*public OperationResult<int> CreateUser(DataObjects.UserPlaylist UserData)
        {
            OperationResult<int> _opResult = new OperationResult<int>() { OpStatus = 0, OpMessage = "No se logro ejecutar el SP", OpResult = -1 };
            
            try
            {
                if (null == UserData)
                {
                    throw new ArgumentNullException("UserData");
                }
                using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                {
                    _sqlConn.Open();

                    using (SqlCommand _sqlCommand = new SqlCommand(createUser, _sqlConn))
                    {
                        _sqlCommand.Parameters.Add("User", SqlDbType.VarChar);
                        _sqlCommand.Parameters.Add("Playlist", SqlDbType.VarChar);
                        

                        _sqlCommand.Parameters["User"].Value = UserData.UserId;
                        _sqlCommand.Parameters["Playlist"].Value = UserData.PlaylistId;
                       

                        using (IDataReader _reader= _sqlCommand.ExecuteReader(CommandBehavior.CloseConnection & CommandBehavior.SingleRow))
                        {
                            if (_reader.Read())
                            {
                                //_opResult.OpStatus = (byte)_reader[0];
                                _opResult.OpMessage = (string)_reader[0];
                                //_opResult.OpResult = (int)_reader[2];
                            }
                        }
                        ;

                    }
                }

            }
            catch (Exception ex)
            {
                _opResult.OpStatus = 2;
                _opResult.OpMessage = ex.Message;
            }
            return _opResult;

        }*/


    }
}
