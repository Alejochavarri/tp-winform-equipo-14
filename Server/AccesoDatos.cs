using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Server
{
    public class AccesoDatos
    {
        public SqlConnection conection;
        public SqlDataReader lector;
        public SqlCommand cmd;
        public AccesoDatos()
        {
            conection = new SqlConnection("server=.\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true"); // ruta
            cmd = new SqlCommand();

        }

        public void setConsulta(string consulta) {  
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = consulta;
        }
        
        public void ejecutarConsulta()
        {
            cmd.Connection = conection;
            try
            {
                conection.Open();
                lector = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
        public SqlDataReader getLector() { 
            return lector;
        }

        public void cerrarConexion()
        {
            if (lector != null)
                conection.Close();
            conection.Close ();
        }
    }
}
