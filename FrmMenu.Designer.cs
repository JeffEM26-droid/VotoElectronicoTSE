namespace VotoElectronicoTSE
{
    partial class FrmMenu
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
            this.mnuArchivo = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMantenimientos = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPadron = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDistrito = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCandidatos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPartidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTipoEleccion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVotacion = new System.Windows.Forms.MenuStrip();
            this.votaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEstadistica = new System.Windows.Forms.MenuStrip();
            this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcerca = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreditos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArchivo.SuspendLayout();
            this.mnuMantenimientos.SuspendLayout();
            this.mnuVotacion.SuspendLayout();
            this.mnuEstadistica.SuspendLayout();
            this.mnuReportes.SuspendLayout();
            this.mnuAcerca.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mnuArchivo.Location = new System.Drawing.Point(0, 140);
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(1230, 28);
            this.mnuArchivo.TabIndex = 6;
            this.mnuArchivo.Text = "Archivo";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCerrarSesion,
            this.mnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuCerrarSesion
            // 
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.Size = new System.Drawing.Size(179, 26);
            this.mnuCerrarSesion.Text = "Cerrar Sesión";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(224, 26);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuMantenimientos
            // 
            this.mnuMantenimientos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMantenimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem});
            this.mnuMantenimientos.Location = new System.Drawing.Point(0, 112);
            this.mnuMantenimientos.Name = "mnuMantenimientos";
            this.mnuMantenimientos.Size = new System.Drawing.Size(1230, 28);
            this.mnuMantenimientos.TabIndex = 7;
            this.mnuMantenimientos.Text = "Mantenimientos";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPadron,
            this.mnuDistrito,
            this.mnuCandidatos,
            this.mnuPartidos,
            this.mnuTipoEleccion});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mnuPadron
            // 
            this.mnuPadron.Name = "mnuPadron";
            this.mnuPadron.Size = new System.Drawing.Size(224, 26);
            this.mnuPadron.Text = "Padrón";
            // 
            // mnuDistrito
            // 
            this.mnuDistrito.Name = "mnuDistrito";
            this.mnuDistrito.Size = new System.Drawing.Size(224, 26);
            this.mnuDistrito.Text = "Distrito";
            // 
            // mnuCandidatos
            // 
            this.mnuCandidatos.Name = "mnuCandidatos";
            this.mnuCandidatos.Size = new System.Drawing.Size(224, 26);
            this.mnuCandidatos.Text = "Candidatos";
            this.mnuCandidatos.Click += new System.EventHandler(this.mnuCandidatos_Click);
            // 
            // mnuPartidos
            // 
            this.mnuPartidos.Name = "mnuPartidos";
            this.mnuPartidos.Size = new System.Drawing.Size(224, 26);
            this.mnuPartidos.Text = "Partidos";
            this.mnuPartidos.Click += new System.EventHandler(this.mnuPartidos_Click);
            // 
            // mnuTipoEleccion
            // 
            this.mnuTipoEleccion.Name = "mnuTipoEleccion";
            this.mnuTipoEleccion.Size = new System.Drawing.Size(224, 26);
            this.mnuTipoEleccion.Text = "Tipo Elección";
            // 
            // mnuVotacion
            // 
            this.mnuVotacion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuVotacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votaciónToolStripMenuItem});
            this.mnuVotacion.Location = new System.Drawing.Point(0, 84);
            this.mnuVotacion.Name = "mnuVotacion";
            this.mnuVotacion.Size = new System.Drawing.Size(1230, 28);
            this.mnuVotacion.TabIndex = 8;
            this.mnuVotacion.Text = "Votación";
            // 
            // votaciónToolStripMenuItem
            // 
            this.votaciónToolStripMenuItem.Name = "votaciónToolStripMenuItem";
            this.votaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.votaciónToolStripMenuItem.Text = "Votación";
            this.votaciónToolStripMenuItem.Click += new System.EventHandler(this.votaciónToolStripMenuItem_Click);
            // 
            // mnuEstadistica
            // 
            this.mnuEstadistica.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEstadistica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticaToolStripMenuItem});
            this.mnuEstadistica.Location = new System.Drawing.Point(0, 56);
            this.mnuEstadistica.Name = "mnuEstadistica";
            this.mnuEstadistica.Size = new System.Drawing.Size(1230, 28);
            this.mnuEstadistica.TabIndex = 9;
            this.mnuEstadistica.Text = "Estadistica";
            // 
            // estadisticaToolStripMenuItem
            // 
            this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.estadisticaToolStripMenuItem.Text = "Estadistica";
            this.estadisticaToolStripMenuItem.Click += new System.EventHandler(this.estadisticaToolStripMenuItem_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.mnuReportes.Location = new System.Drawing.Point(0, 28);
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(1230, 28);
            this.mnuReportes.TabIndex = 10;
            this.mnuReportes.Text = "Reportes";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // mnuAcerca
            // 
            this.mnuAcerca.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAcerca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.mnuAcerca.Location = new System.Drawing.Point(0, 0);
            this.mnuAcerca.Name = "mnuAcerca";
            this.mnuAcerca.Size = new System.Drawing.Size(1230, 28);
            this.mnuAcerca.TabIndex = 11;
            this.mnuAcerca.Text = "Acerca de";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreditos,
            this.mnuManual});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // mnuCreditos
            // 
            this.mnuCreditos.Name = "mnuCreditos";
            this.mnuCreditos.Size = new System.Drawing.Size(224, 26);
            this.mnuCreditos.Text = "Creditos";
            this.mnuCreditos.Click += new System.EventHandler(this.mnuCreditos_Click);
            // 
            // mnuManual
            // 
            this.mnuManual.Name = "mnuManual";
            this.mnuManual.Size = new System.Drawing.Size(147, 26);
            this.mnuManual.Text = "Manual";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 450);
            this.Controls.Add(this.mnuArchivo);
            this.Controls.Add(this.mnuMantenimientos);
            this.Controls.Add(this.mnuVotacion);
            this.Controls.Add(this.mnuEstadistica);
            this.Controls.Add(this.mnuReportes);
            this.Controls.Add(this.mnuAcerca);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.mnuArchivo.ResumeLayout(false);
            this.mnuArchivo.PerformLayout();
            this.mnuMantenimientos.ResumeLayout(false);
            this.mnuMantenimientos.PerformLayout();
            this.mnuVotacion.ResumeLayout(false);
            this.mnuVotacion.PerformLayout();
            this.mnuEstadistica.ResumeLayout(false);
            this.mnuEstadistica.PerformLayout();
            this.mnuReportes.ResumeLayout(false);
            this.mnuReportes.PerformLayout();
            this.mnuAcerca.ResumeLayout(false);
            this.mnuAcerca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.MenuStrip mnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPadron;
        private System.Windows.Forms.ToolStripMenuItem mnuDistrito;
        private System.Windows.Forms.ToolStripMenuItem mnuCandidatos;
        private System.Windows.Forms.ToolStripMenuItem mnuPartidos;
        private System.Windows.Forms.ToolStripMenuItem mnuTipoEleccion;
        private System.Windows.Forms.MenuStrip mnuVotacion;
        private System.Windows.Forms.ToolStripMenuItem votaciónToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuEstadistica;
        private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuAcerca;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCreditos;
        private System.Windows.Forms.ToolStripMenuItem mnuManual;
    }
}