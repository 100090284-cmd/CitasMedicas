using CapaDatos1;

namespace CapaNegocio
{
    public class ConexionNegocio
    {
        public bool ProbarConexion()
        {
            ConexionPrueba prueba = new ConexionPrueba();

            return prueba.ProbarConexion();
        }
    }
}