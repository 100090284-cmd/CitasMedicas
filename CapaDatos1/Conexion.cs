using System.Data.SqlClient;



namespace CapaDatos1
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Server=localhost\SQLEXPRESS;Database=CitasMedicasDB;Integrated Security=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}