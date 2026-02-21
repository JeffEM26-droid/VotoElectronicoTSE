namespace VotoElectronicoTSE
{
    partial class FrmAcercade
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
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblDesarrollador = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAbrirManual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(30, 48);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(56, 16);
            this.lblSistema.TabIndex = 0;
            this.lblSistema.Text = "Sistema";
            // 
            // lblDesarrollador
            // 
            this.lblDesarrollador.AutoSize = true;
            this.lblDesarrollador.Location = new System.Drawing.Point(260, 48);
            this.lblDesarrollador.Name = "lblDesarrollador";
            this.lblDesarrollador.Size = new System.Drawing.Size(90, 16);
            this.lblDesarrollador.TabIndex = 1;
            this.lblDesarrollador.Text = "Desarrollador";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(519, 48);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(42, 16);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(772, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // btnAbrirManual
            // 
            this.btnAbrirManual.Location = new System.Drawing.Point(33, 204);
            this.btnAbrirManual.Name = "btnAbrirManual";
            this.btnAbrirManual.Size = new System.Drawing.Size(154, 43);
            this.btnAbrirManual.TabIndex = 4;
            this.btnAbrirManual.Text = "Abrir Manual";
            this.btnAbrirManual.UseVisualStyleBackColor = true;
            this.btnAbrirManual.Click += new System.EventHandler(this.btnAbrirManual_Click);
            // 
            // FrmAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.btnAbrirManual);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblDesarrollador);
            this.Controls.Add(this.lblSistema);
            this.Name = "FrmAcercade";
            this.Text = "FrmAcercade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblDesarrollador;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAbrirManual;
    }
}