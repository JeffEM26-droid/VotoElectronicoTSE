using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotoElectronicoTSE
{

    public partial class FrmMenu : Form
    {
        public string PerfilUsuario { get; set; }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            // RESTRICCIÓN DEL PDF: Configurar menú según el perfil
            if (PerfilUsuario == "Votante")
            {
                // Ocultamos mantenimiento de datos y reportes para el votante
                mnuCandidatos.Visible = false;
                mnuPartidos.Visible = false;
                estadisticaToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                MessageBox.Show("Sesión iniciada como Votante. Solo tiene acceso a la votación.");
            }
            else if (PerfilUsuario == "Administrador")
            {
                // El administrador gestiona, pero no vota en esta pantalla
                votaciónToolStripMenuItem.Visible = false;

                MessageBox.Show("Sesión iniciada como Administrador. Acceso total a catálogos y reportes.");
            }
        }
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mnuCandidatos_Click(object sender, EventArgs e)
        {
            FrmCandidatos frm = new FrmCandidatos();
            frm.ShowDialog();
        }

        private void mnuPartidos_Click(object sender, EventArgs e)
        {
            FrmPartidos frm = new FrmPartidos();
            frm.ShowDialog();
        }

        private void votaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVotacion frm = new FrmVotacion();
            frm.ShowDialog();
        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frm = new FrmEstadisticas();
            frm.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.ShowDialog();
        }

        private void mnuCreditos_Click(object sender, EventArgs e)
        {
            FrmAcercade frm = new FrmAcercade();
            frm.ShowDialog();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
