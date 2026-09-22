using System.Data;
using CapaDatos1;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        private readonly UsuarioDatos usuarioDatos = new UsuarioDatos();

        // LOGIN
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            return usuarioDatos.ValidarUsuario(usuario, contrasena);
        }

        // MOSTRAR
        public DataTable MostrarUsuarios()
        {
            return usuarioDatos.MostrarUsuarios();
        }

        // INSERTAR
        public bool InsertarUsuario(
            string nombreCompleto,
            string nombreUsuario,
            string contrasena,
            string rol,
            int estado)
        {
            return usuarioDatos.InsertarUsuario(
                nombreCompleto,
                nombreUsuario,
                contrasena,
                rol,
                estado);
        }

        // EDITAR
        public bool EditarUsuario(
            int idUsuario,
            string nombreCompleto,
            string nombreUsuario,
            string contrasena,
            string rol,
            int estado)
        {
            return usuarioDatos.EditarUsuario(
                idUsuario,
                nombreCompleto,
                nombreUsuario,
                contrasena,
                rol,
                estado);
        }

        // ELIMINAR
        public bool EliminarUsuario(int idUsuario)
        {
            return usuarioDatos.EliminarUsuario(idUsuario);
        }
    }
}