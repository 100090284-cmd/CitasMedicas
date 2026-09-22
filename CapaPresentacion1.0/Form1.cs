using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            ConexionNegocio conexion = new ConexionNegocio();

            if (conexion.ProbarConexion())
            {
                MessageBox.Show(
                    "CONEXIÓN EXITOSA\n\n" +
                    "La aplicación está conectada correctamente a:\n" +
                    "CitasMedicasDB",
                    "Citas Médicas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "NO SE PUDO CONECTAR\n\n" +
                    "Servidor: localhost\\SQLEXPRESS\n" +
                    "Base de datos: CitasMedicasDB",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show(
                    "Ingrese el usuario.",
                    "Citas Médicas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Ingrese la contraseña.",
                    "Citas Médicas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtContrasena.Focus();
                return;
            }

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            bool acceso = usuarioNegocio.ValidarUsuario(usuario, contrasena);

            if (acceso)
            {
                FrmPrincipal principal = new FrmPrincipal();

                principal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtContrasena.Clear();
                txtContrasena.Focus();

               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
