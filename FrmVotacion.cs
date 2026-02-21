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
    
    public partial class FrmVotacion : Form
    {
        int tiempo = 60;

        public FrmVotacion()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblTiempo.Text = tiempo.ToString();

            if (tiempo == 0)
            {
                timer1.Stop();
                MessageBox.Show("Tiempo agotado");
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voto registrado correctamente");
            this.Close();
        }
    }
}
