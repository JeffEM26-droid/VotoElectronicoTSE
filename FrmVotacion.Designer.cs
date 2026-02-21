namespace VotoElectronicoTSE
{
    partial class FrmVotacion
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.flpCandidatos = new System.Windows.Forms.FlowLayoutPanel();
            this.cboTipoEleccion = new System.Windows.Forms.ComboBox();
            this.lblTipoEleccion = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 54);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(26, 284);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 54);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar Voto";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // flpCandidatos
            // 
            this.flpCandidatos.AutoScroll = true;
            this.flpCandidatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpCandidatos.Location = new System.Drawing.Point(0, 538);
            this.flpCandidatos.Name = "flpCandidatos";
            this.flpCandidatos.Size = new System.Drawing.Size(1171, 166);
            this.flpCandidatos.TabIndex = 11;
            // 
            // cboTipoEleccion
            // 
            this.cboTipoEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEleccion.FormattingEnabled = true;
            this.cboTipoEleccion.Items.AddRange(new object[] {
            "Presidencial",
            "Diputados"});
            this.cboTipoEleccion.Location = new System.Drawing.Point(715, 37);
            this.cboTipoEleccion.Name = "cboTipoEleccion";
            this.cboTipoEleccion.Size = new System.Drawing.Size(121, 24);
            this.cboTipoEleccion.TabIndex = 10;
            // 
            // lblTipoEleccion
            // 
            this.lblTipoEleccion.AutoSize = true;
            this.lblTipoEleccion.Location = new System.Drawing.Point(600, 40);
            this.lblTipoEleccion.Name = "lblTipoEleccion";
            this.lblTipoEleccion.Size = new System.Drawing.Size(90, 16);
            this.lblTipoEleccion.TabIndex = 9;
            this.lblTipoEleccion.Text = "Tipo Eleccion";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(315, 40);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(21, 16);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = "60";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(23, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Emisión del Voto";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 704);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.flpCandidatos);
            this.Controls.Add(this.cboTipoEleccion);
            this.Controls.Add(this.lblTipoEleccion);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmVotacion";
            this.Text = "FrmVotacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.FlowLayoutPanel flpCandidatos;
        private System.Windows.Forms.ComboBox cboTipoEleccion;
        private System.Windows.Forms.Label lblTipoEleccion;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer timer1;
    }
}