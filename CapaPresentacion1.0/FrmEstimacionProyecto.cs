using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion1._0
{
    public partial class FrmEstimacionProyecto : Form
    {
        public FrmEstimacionProyecto()
        {
            InitializeComponent();
        }

        private void FrmEstimacionProyecto_Load(object sender, EventArgs e)
        {
            txtActores.Text = "3";
            txtCasosUso.Text = "10";

            txtUAW.Text = "9";
            txtUUCW.Text = "100";
            txtUUCP.Text = "109";

            txtTCF.Text = "0.875";
            txtECF.Text = "0.86";

            txtProductividad.Text = "20";
            txtPersonas.Text = "4";

            txtUCP.Text = "82.03";
            txtEsfuerzo.Text = "1641";
            txtDias.Text = "205";
            txtDiasEquipo.Text = "51";
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double uaw = 9;
                double uucw = 100;
                double tcf = 0.875;
                double ecf = 0.86;
                double productividad = 20;
                int personas = 4;

                // 1. Calcular UUCP
                double uucp = uaw + uucw;

                // 2. Calcular UCP
                double ucp = uucp * tcf * ecf;

                // 3. Calcular esfuerzo
                double esfuerzo = ucp * productividad;

                // 4. Calcular días
                double dias = esfuerzo / 8;

                // 5. Calcular días con el equipo
                double diasEquipo = dias / personas;

                // Mostrar resultados en los TextBox
                txtUAW.Text = uaw.ToString("0.00");
                txtUUCW.Text = uucw.ToString("0.00");
                txtUUCP.Text = uucp.ToString("0.00");
                txtTCF.Text = tcf.ToString("0.000");
                txtECF.Text = ecf.ToString("0.000");
                txtUCP.Text = ucp.ToString("0.00");
                txtEsfuerzo.Text = Math.Round(esfuerzo).ToString("N0");
                txtDias.Text = Math.Ceiling(dias).ToString();
                txtPersonas.Text = personas.ToString();
                txtDiasEquipo.Text = Math.Ceiling(diasEquipo).ToString();

                // Mostrar el cálculo completo
                string resultado =
                    "ESTIMACIÓN DEL SISTEMA CITAS MÉDICAS\n\n" +

                    "1. UUCP\n" +
                    "UAW + UUCW\n" +
                    "9 + 100 = " + uucp.ToString("0.00") + "\n\n" +

                    "2. UCP\n" +
                    "UUCP × TCF × ECF\n" +
                    "109 × 0.875 × 0.86 = " + ucp.ToString("0.00") + "\n\n" +

                    "3. ESFUERZO\n" +
                    "UCP × 20 horas\n" +
                    ucp.ToString("0.00") + " × 20 = " +
                    esfuerzo.ToString("N2") + " horas\n\n" +

                    "4. DÍAS DE TRABAJO\n" +
                    esfuerzo.ToString("N2") + " ÷ 8 = " +
                    dias.ToString("0.00") + " días\n\n" +

                    "5. EQUIPO DE 4 PERSONAS\n" +
                    dias.ToString("0.00") + " ÷ 4 = " +
                    diasEquipo.ToString("0.00") + " días\n\n" +

                    "RESULTADO FINAL\n" +
                    "82.03 UCP\n" +
                    "1,641 horas aproximadamente\n" +
                    "205 días con una persona\n" +
                    "51 días aproximadamente con 4 personas";

                MessageBox.Show(
                    resultado,
                    "Cálculo de estimación - Citas Médicas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al calcular: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        
    }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtUCP.Clear();
            txtEsfuerzo.Clear();
            txtDias.Clear();
            txtDiasEquipo.Clear();
        }
    }
}
       