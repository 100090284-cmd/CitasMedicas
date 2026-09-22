using System.Data;
using System.Data.SqlClient;

namespace CapaDatos1
{
    public class UsuarioDatos
    {
        private readonly Conexion conexion = new Conexion();

        // =====================================================
        // VALIDAR USUARIO - LOGIN
        // =====================================================
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT COUNT(*)
                    FROM Usuarios
                    WHERE NombreUsuario = @NombreUsuario
                    AND Contrasena = @Contrasena
                    AND Estado = 1";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    cn.Open();

                    int resultado = (int)cmd.ExecuteScalar();

                    return resultado > 0;
                }
            }
        }

        // =====================================================
        // MOSTRAR USUARIOS
        // =====================================================
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT 
                        IDUSUARIO,
                        NombreCompleto,
                        NombreUsuario,
                        Contrasena,
                        Rol,
                        Estado
                    FROM Usuarios
                    ORDER BY IDUSUARIO DESC";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        // =====================================================
        // INSERTAR USUARIO
        // =====================================================
        public bool InsertarUsuario(
            string nombreCompleto,
            string nombreUsuario,
            string contrasena,
            string rol,
            int estado)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Usuarios
                    (
                        NombreCompleto,
                        NombreUsuario,
                        Contrasena,
                        Rol,
                        Estado
                    )
                    VALUES
                    (
                        @NombreCompleto,
                        @NombreUsuario,
                        @Contrasena,
                        @Rol,
                        @Estado
                    )";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    cmd.Parameters.AddWithValue("@Estado", estado);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // =====================================================
        // EDITAR USUARIO
        // =====================================================
        public bool EditarUsuario(
            int idUsuario,
            string nombreCompleto,
            string nombreUsuario,
            string contrasena,
            string rol,
            int estado)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    UPDATE Usuarios
                    SET
                        NombreCompleto = @NombreCompleto,
                        NombreUsuario = @NombreUsuario,
                        Contrasena = @Contrasena,
                        Rol = @Rol,
                        Estado = @Estado
                    WHERE IDUSUARIO = @IDUSUARIO";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@IDUSUARIO", idUsuario);
                    cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    cmd.Parameters.AddWithValue("@Estado", estado);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // =====================================================
        // ELIMINAR USUARIO
        // =====================================================
        public bool EliminarUsuario(int idUsuario)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    DELETE FROM Usuarios
                    WHERE IDUSUARIO = @IDUSUARIO";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@IDUSUARIO", idUsuario);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }

}