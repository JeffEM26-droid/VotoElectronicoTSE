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
    public partial class FrmRegistro : Form
    {// Esta es tu dirección de base de datos según tus capturas
        string cadenaConexion = "Server=DESKTOP-JKPU22Q\\MSSQLSERVER2025;Database=VotoElectronico2026;Integrated Security=True;";

        public FrmRegistro()
        {
            InitializeComponent();
        }
        // Este evento se ejecuta cuando abres el formulario
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            CargarProvincias();
        }
        // 1. CARGA LAS PROVINCIAS DESDE LA BASE DE DATOS
        private void CargarProvincias()
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                try
                {
                    con.Open();
                    // Usamos DISTINCT para que no se repitan las provincias
                    string sql = "SELECT DISTINCT Provincia FROM DistritoElectoral ORDER BY Provincia";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();


                    cmbProvincia.Items.Clear();
                    while (dr.Read())
                    {
                        cmbProvincia.Items.Add(dr["Provincia"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con SQL para provincias: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de cédula.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                try
                {
                    con.Open();
                    //Consulta exacta a tu tabla dbo.PadronNacional
                    string sql = "SELECT Nombre, PrimerApellido, SegundoApellido, FechaVencimiento FROM PadronNacional WHERE Cedula = @ced";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ced", txtCedula.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Ponemos los datos reales en los cuadros de texto
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtPrimerApellido.Text = reader["PrimerApellido"].ToString();
                        txtSegundoApellido.Text = reader["SegundoApellido"].ToString();

                        // Mostramos la fecha de vencimiento que viene de SQL
                        DateTime fechaVence = Convert.ToDateTime(reader["FechaVencimiento"]);
                        dtpVencimiento.Value = fechaVence;

                        // Validar si la persona tiene la cédula vigente (Requisito del proyecto)
                        if (fechaVence < DateTime.Now.Date)
                        {
                            MessageBox.Show("ATENCIÓN: Cédula vencida. No se permite el registro.");
                            btnGuardar.Enabled = false;
                        }
                        else
                        {
                            btnGuardar.Enabled = true;
                            MessageBox.Show("Ciudadano encontrado con éxito.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esa cédula no existe en el Padrón del TSE.");
                        LimpiarFormulario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión a la base de datos: " + ex.Message);
                }
            }
        }

        // 3. FILTRADO DE CANTONES (Cuando eliges una provincia)
        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedItem == null) return;

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT DISTINCT Canton FROM DistritoElectoral WHERE Provincia = @prov ORDER BY Canton";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@prov", cmbProvincia.SelectedItem.ToString());

                    SqlDataReader dr = cmd.ExecuteReader();
                    cmbCanton.Items.Clear();
                    cmbDistrito.Items.Clear();
                    while (dr.Read())
                    {
                        cmbCanton.Items.Add(dr["Canton"].ToString());
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        // NUEVO: Cargar Distritos cuando se selecciona un Cantón
        private void cmbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCanton.SelectedItem == null) return;

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT Distrito FROM DistritoElectoral WHERE Canton = @cant AND Provincia = @prov ORDER BY Distrito";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@cant", cmbCanton.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@prov", cmbProvincia.SelectedItem.ToString());

                    SqlDataReader dr = cmd.ExecuteReader();
                    cmbDistrito.Items.Clear();
                    while (dr.Read())
                    {
                        cmbDistrito.Items.Add(dr["Distrito"].ToString());
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            btnGuardar.Enabled = false;
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            //cierra el formulario de registro
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // RESTRICCIÓN Validar longitud de contraseña (8 a 15 caracteres)
            if (txtPassword.Text.Length < 8 || txtPassword.Text.Length > 15)
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 15 caracteres.");
                return;
            }

            // Validación de campos vacíos antes de enviar
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Cédula y Contraseña son obligatorios.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                try
                {
                    con.Open();

                    // Query que incluye todas las columnas necesarias y encriptación HASHBYTES
                    string sql = @"INSERT INTO Usuario (Cedula, Contrasena, Correo, Perfil, Nombre, PrimerApellido, SegundoApellido, Provincia, Canton, Distrito) 
                           VALUES (@ced, HASHBYTES('SHA2_256', @pass), @correo, @perfil, @nom, @ap1, @ap2, @prov, @cant, @dist)";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    // Parámetros con los nombres exactos
                    cmd.Parameters.AddWithValue("@ced", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text); // El SQL lo convierte a varbinary
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@perfil", "Votante"); // Perfil por defecto según el PDF
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ap1", txtPrimerApellido.Text);
                    cmd.Parameters.AddWithValue("@ap2", txtSegundoApellido.Text);
                    cmd.Parameters.AddWithValue("@prov", cmbProvincia.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@cant", cmbCanton.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@dist", cmbDistrito.SelectedItem?.ToString() ?? "");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("¡Usuario registrado con éxito! Ya puedes iniciar sesión.");
                    this.Close(); // Cierra el registro para volver al Login
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
                }







            }   
    }   } 
         
}      

