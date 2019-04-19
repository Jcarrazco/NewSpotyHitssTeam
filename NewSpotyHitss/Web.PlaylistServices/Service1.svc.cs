using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Web.PlaylistServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection("server=HGDLAPMORAALEG\\SQLEXPRESS; DataBase=Spotify; integrated security = true");

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        //Método para borrar una playlist
        public string borrar_playlist(string lista)
        {
            string mensaje;
            con.Open(); //abrir la conección con la variable "con"
            using (SqlCommand cmd = new SqlCommand("borrar_playlist", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@playlist", SqlDbType.Int).Value = lista;
                cmd.ExecuteNonQuery();
                mensaje = "Playlist Eliminada";
            }
            con.Close();
            return mensaje;
        }

        public string crear_playlist(string nombre, string descripcion)
        {
            string mensaje = "Fallo la creacion";
            con.Open();
            using (SqlCommand cmd = new SqlCommand("modificar_playlist", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
                cmd.ExecuteNonQuery();
                mensaje = "Playlist creada";
            }
                return mensaje;
        }

    }
}
