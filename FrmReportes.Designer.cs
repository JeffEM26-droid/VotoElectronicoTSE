namespace VotoElectronicoTSE
{
    partial class FrmReportes
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
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.cboCandidato = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(449, 49);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(126, 34);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // cboCandidato
            // 
            this.cboCandidato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCandidato.FormattingEnabled = true;
            this.cboCandidato.Location = new System.Drawing.Point(247, 55);
            this.cboCandidato.Name = "cboCandidato";
            this.cboCandidato.Size = new System.Drawing.Size(142, 24);
            this.cboCandidato.TabIndex = 5;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(36, 55);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(142, 24);
            this.cboProvincia.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(36, 276);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(952, 246);
            this.reportViewer1.TabIndex = 7;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 560);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.cboCandidato);
            this.Controls.Add(this.cboProvincia);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.ComboBox cboCandidato;
        private System.Windows.Forms.ComboBox cboProvincia;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}