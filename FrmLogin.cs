using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotoElectronicoTSE
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistro formularioRegistro = new FrmRegistro();
            formularioRegistro.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // 1. Validaciones de texto básicas
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar cédula y contraseña");
                return;
            }

            string connectionString = "Server=DESKTOP-JKPU22Q\\MSSQLSERVER2025;Database=VotoElectronico2026;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // RESTRICCIÓN DEL PDF: Validar por usuario, contraseña y PERFIL.
                    // Usamos HASHBYTES para comparar la contraseña encriptada (varbinary).
                    string query = "SELECT Perfil FROM Usuario WHERE Cedula = @cedula AND Contrasena = HASHBYTES('SHA2_256', @pass)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text); // El SQL lo encripta para comparar

                    // Ejecutamos y obtenemos el Perfil (si existe)
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string perfilUsuario = resultado.ToString();

                        // RESTRICCIÓN: Mostrar mensaje de éxito y dirigir según el perfil
                        MessageBox.Show("Bienvenido jefry. Acceso concedido como: " + perfilUsuario);

                        // abre el menú
                        FrmMenu menu = new FrmMenu();

             

                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Si el resultado es null, los datos no coinciden
                        MessageBox.Show("Cédula o contraseña incorrectos. Verifique sus datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Ramsés (Servidor): " + ex.Message);
                }








            }
        }
    }
}
