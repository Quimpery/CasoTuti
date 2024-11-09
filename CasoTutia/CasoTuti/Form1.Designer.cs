namespace CasoTuti
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCliente = new System.Windows.Forms.ListBox();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.btnCancelarTurno = new System.Windows.Forms.Button();
            this.btnVerProfesional = new System.Windows.Forms.Button();
            this.btnAgregarProfesional = new System.Windows.Forms.Button();
            this.btnImportarTurnos = new System.Windows.Forms.Button();
            this.btnExportarProfesional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCliente
            // 
            this.listCliente.FormattingEnabled = true;
            this.listCliente.ItemHeight = 16;
            this.listCliente.Location = new System.Drawing.Point(12, 24);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(380, 196);
            this.listCliente.TabIndex = 0;
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Location = new System.Drawing.Point(408, 24);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(100, 66);
            this.btnAsignarTurno.TabIndex = 1;
            this.btnAsignarTurno.Text = "AgregarTurno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            this.btnAsignarTurno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarTurno
            // 
            this.btnCancelarTurno.Location = new System.Drawing.Point(528, 24);
            this.btnCancelarTurno.Name = "btnCancelarTurno";
            this.btnCancelarTurno.Size = new System.Drawing.Size(100, 66);
            this.btnCancelarTurno.TabIndex = 2;
            this.btnCancelarTurno.Text = "Cancelar turno";
            this.btnCancelarTurno.UseVisualStyleBackColor = true;
            // 
            // btnVerProfesional
            // 
            this.btnVerProfesional.Location = new System.Drawing.Point(528, 96);
            this.btnVerProfesional.Name = "btnVerProfesional";
            this.btnVerProfesional.Size = new System.Drawing.Size(100, 66);
            this.btnVerProfesional.TabIndex = 3;
            this.btnVerProfesional.Text = "Ver Profesional";
            this.btnVerProfesional.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProfesional
            // 
            this.btnAgregarProfesional.Location = new System.Drawing.Point(408, 96);
            this.btnAgregarProfesional.Name = "btnAgregarProfesional";
            this.btnAgregarProfesional.Size = new System.Drawing.Size(100, 66);
            this.btnAgregarProfesional.TabIndex = 4;
            this.btnAgregarProfesional.Text = "Agregar Profesional";
            this.btnAgregarProfesional.UseVisualStyleBackColor = true;
            // 
            // btnImportarTurnos
            // 
            this.btnImportarTurnos.Location = new System.Drawing.Point(12, 262);
            this.btnImportarTurnos.Name = "btnImportarTurnos";
            this.btnImportarTurnos.Size = new System.Drawing.Size(100, 66);
            this.btnImportarTurnos.TabIndex = 6;
            this.btnImportarTurnos.Text = "Importar Turnos";
            this.btnImportarTurnos.UseVisualStyleBackColor = true;
            // 
            // btnExportarProfesional
            // 
            this.btnExportarProfesional.Location = new System.Drawing.Point(167, 262);
            this.btnExportarProfesional.Name = "btnExportarProfesional";
            this.btnExportarProfesional.Size = new System.Drawing.Size(96, 66);
            this.btnExportarProfesional.TabIndex = 7;
            this.btnExportarProfesional.Text = "Exportar Profesional";
            this.btnExportarProfesional.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 381);
            this.Controls.Add(this.btnExportarProfesional);
            this.Controls.Add(this.btnImportarTurnos);
            this.Controls.Add(this.btnAgregarProfesional);
            this.Controls.Add(this.btnVerProfesional);
            this.Controls.Add(this.btnCancelarTurno);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.listCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listCliente;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Button btnCancelarTurno;
        private System.Windows.Forms.Button btnVerProfesional;
        private System.Windows.Forms.Button btnAgregarProfesional;
        private System.Windows.Forms.Button btnImportarTurnos;
        private System.Windows.Forms.Button btnExportarProfesional;
    }
}

