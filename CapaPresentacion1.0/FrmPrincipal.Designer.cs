namespace CapaPresentacion1._0
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estimaciónDelProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMedicos
            // 
            this.btnMedicos.Location = new System.Drawing.Point(40, 9);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(188, 82);
            this.btnMedicos.TabIndex = 0;
            this.btnMedicos.Text = "MÉDICOS";
            this.btnMedicos.UseVisualStyleBackColor = true;
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(40, 116);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(188, 82);
            this.btnCitas.TabIndex = 0;
            this.btnCitas.Text = "CITAS MÉDICAS";
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(40, 223);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(188, 82);
            this.btnConsultas.TabIndex = 0;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(288, 9);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(198, 82);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "PACIENTES";
            this.btnPacientes.UseVisualStyleBackColor = true;
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Location = new System.Drawing.Point(288, 116);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(198, 82);
            this.btnEspecialidades.TabIndex = 0;
            this.btnEspecialidades.Text = "ESPECIALIDADES";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(288, 223);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(198, 82);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(244, 489);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(305, 58);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "CERRAR SESIÓN";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(153, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 46);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CITAS MEDICAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema De Gestion Medica";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(26, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 584);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.btnMedicos);
            this.panel3.Controls.Add(this.btnUsuarios);
            this.panel3.Controls.Add(this.btnConsultas);
            this.panel3.Controls.Add(this.btnEspecialidades);
            this.panel3.Controls.Add(this.btnCitas);
            this.panel3.Controls.Add(this.btnPacientes);
            this.panel3.Location = new System.Drawing.Point(129, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 317);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(74, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 134);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónDelSistemaToolStripMenuItem
            // 
            this.gestiónDelSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estimaciónDelProyectoToolStripMenuItem});
            this.gestiónDelSistemaToolStripMenuItem.Name = "gestiónDelSistemaToolStripMenuItem";
            this.gestiónDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.gestiónDelSistemaToolStripMenuItem.Text = "Gestión del sistema";
            // 
            // estimaciónDelProyectoToolStripMenuItem
            // 
            this.estimaciónDelProyectoToolStripMenuItem.Name = "estimaciónDelProyectoToolStripMenuItem";
            this.estimaciónDelProyectoToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.estimaciónDelProyectoToolStripMenuItem.Text = "Estimación del proyecto";
            this.estimaciónDelProyectoToolStripMenuItem.Click += new System.EventHandler(this.estimaciónDelProyectoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas Médicas - Sistema Principal";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estimaciónDelProyectoToolStripMenuItem;
    }
}