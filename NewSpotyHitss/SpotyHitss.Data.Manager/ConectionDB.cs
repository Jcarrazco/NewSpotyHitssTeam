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

        public static string GetConnection()
        {
            return "";
        }

        public OperationResult<int> ADDALBUM (string Album_Name,int Album_Year)
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

      
    }
}