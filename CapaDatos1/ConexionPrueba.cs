using System;
using System.Data.SqlClient;
using CapaDatos1;



namespace CapaDatos1
{
    public class ConexionPrueba
    {
        public bool ProbarConexion()
        {
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}