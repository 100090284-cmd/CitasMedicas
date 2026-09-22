using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion1._0
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "¿Está seguro de que desea cerrar sesión?",
       "Citas Médicas",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (resultado == DialogResult.Yes)
            {
                Form1 login = new Form1();

                login.Show();

                this.Close();
            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios formularioUsuarios = new FrmUsuarios();
            formularioUsuarios.ShowDialog();
        }

        private void estimaciónDelProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstimacionProyecto frm = new FrmEstimacionProyecto();
            frm.ShowDialog();
        }
    }
}
