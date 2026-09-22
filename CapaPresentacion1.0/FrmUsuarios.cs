using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion1._0
{
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        private int idUsuarioSeleccionado = 0;

        public FrmUsuarios()
        {
            InitializeComponent();

            Load += FrmUsuarios_Load;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
        }

       
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarEstados();
            CargarUsuarios();
            LimpiarCampos();
        }

     
        private void CargarRoles()
        {
            cmbRol.Items.Clear();

            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Recepcionista");
            cmbRol.Items.Add("Médico");

            cmbRol.SelectedIndex = -1;
        }

       
        private void CargarEstados()
        {
            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");

            cmbEstado.SelectedIndex = 0;
        }

       
        private void CargarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = usuarioNegocio.MostrarUsuarios();

                dgvUsuarios.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvUsuarios.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvUsuarios.MultiSelect = false;

                dgvUsuarios.ReadOnly = true;

                if (dgvUsuarios.Columns.Contains("IDUSUARIO"))
                    dgvUsuarios.Columns["IDUSUARIO"].HeaderText = "ID";

                if (dgvUsuarios.Columns.Contains("NombreCompleto"))
                    dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre Completo";

                if (dgvUsuarios.Columns.Contains("NombreUsuario"))
                    dgvUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario";

                if (dgvUsuarios.Columns.Contains("Contrasena"))
                    dgvUsuarios.Columns["Contrasena"].HeaderText = "Contraseña";

                if (dgvUsuarios.Columns.Contains("Rol"))
                    dgvUsuarios.Columns["Rol"].HeaderText = "Rol";

                if (dgvUsuarios.Columns.Contains("Estado"))
                    dgvUsuarios.Columns["Estado"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                int estado = cmbEstado.Text == "Activo" ? 1 : 0;

                bool resultado = usuarioNegocio.InsertarUsuario(
                    txtNombreCompleto.Text.Trim(),
                    txtNombreUsuario.Text.Trim(),
                    txtContrasena.Text,
                    cmbRol.Text,
                    estado
                );

                if (resultado)
                {
                    MessageBox.Show(
                        "Usuario registrado correctamente.",
                        "Registro exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar el usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el usuario:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUsuarioSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un usuario de la tabla.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!ValidarCampos())
                    return;

                int estado = cmbEstado.Text == "Activo" ? 1 : 0;

                bool resultado = usuarioNegocio.EditarUsuario(
                    idUsuarioSeleccionado,
                    txtNombreCompleto.Text.Trim(),
                    txtNombreUsuario.Text.Trim(),
                    txtContrasena.Text,
                    cmbRol.Text,
                    estado
                );

                if (resultado)
                {
                    MessageBox.Show(
                        "Usuario actualizado correctamente.",
                        "Actualización exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el usuario:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUsuarioSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un usuario de la tabla.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult confirmar = MessageBox.Show(
                    "¿Está seguro de eliminar este usuario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar != DialogResult.Yes)
                    return;

                bool resultado =
                    usuarioNegocio.EliminarUsuario(idUsuarioSeleccionado);

                if (resultado)
                {
                    MessageBox.Show(
                        "Usuario eliminado correctamente.",
                        "Eliminación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el usuario:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        


        private void LimpiarCampos()
        {
            idUsuarioSeleccionado = 0;

            txtNombreCompleto.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();

            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;

            dgvUsuarios.ClearSelection();

            txtNombreCompleto.Focus();
        }

      
        private void dgvUsuarios_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado =
                    Convert.ToInt32(fila.Cells["IDUSUARIO"].Value);

                txtNombreCompleto.Text =
                    fila.Cells["NombreCompleto"].Value?.ToString() ?? "";

                txtNombreUsuario.Text =
                    fila.Cells["NombreUsuario"].Value?.ToString() ?? "";

                txtContrasena.Text =
                    fila.Cells["Contrasena"].Value?.ToString() ?? "";

                cmbRol.Text =
                    fila.Cells["Rol"].Value?.ToString() ?? "";

                object valorEstado =
                    fila.Cells["Estado"].Value;

                if (valorEstado != null &&
                    valorEstado != DBNull.Value)
                {
                    bool activo = Convert.ToBoolean(valorEstado);

                    cmbEstado.Text = activo
                        ? "Activo"
                        : "Inactivo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el usuario:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre completo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombreCompleto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de usuario.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombreUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show(
                    "Ingrese la contraseña.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContrasena.Focus();
                return false;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un rol.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbRol.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el estado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbEstado.Focus();
                return false;
            }

            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}