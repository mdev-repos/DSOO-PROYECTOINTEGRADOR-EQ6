﻿using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ClubDeportivoApp
{
    public partial class Pagar : Form
    {
        public Pagar()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
            this.Activate();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                string query;
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();
                string tipoQuery = @"SELECT 'socio' AS tipo FROM Socio WHERE Dni = @dni 
                     UNION 
                     SELECT 'nosocio' AS tipo FROM NoSocios WHERE Dni = @dni";

                MySqlCommand tipoCmd = new MySqlCommand(tipoQuery, mySqlConnection);
                tipoCmd.Parameters.AddWithValue("@dni", txtDni.Text);

                object? result = tipoCmd.ExecuteScalar();
                string? tipo = result != null ? result.ToString() : null;

                if (tipo == null)
                {
                    MessageBox.Show("El cliente no está registrado como socio ni como no socio.");
                    return;
                }

                if (tipo == "socio")
                {

                    query = @"SELECT c.Nombre, c.Apellido, soc.CodSocio, cuotMens.ValorMensual, cuotMens.TipoDePago, cuotMens.Vencimiento, cuotMens.CodCuotaMensual
                        FROM Clientes c INNER JOIN Socio soc ON c.Dni = soc.Dni INNER JOIN CuotaMensual cuotMens 
                        ON soc.CodSocio = cuotMens.CodSocio where c.Dni = @dni";
                }
                else if (tipo == "nosocio")
                {
                    query = @"SELECT c.Nombre, c.Apellido,noSoc.CodNoSocio, cuotDia.ValorFinal, cuotDia.TipoDePago, cuotDia.CodCuotaDiaria
                    FROM Clientes c inner join NoSocios noSoc ON c.Dni = noSoc.Dni inner join Actividades act 
                    ON noSoc.CodNoSocio = act.CodNoSocio inner join CuotaDiaria cuotDia ON cuotDia.CodNoSocio 
                    = noSoc.CodNoSocio where c.Dni = @dni";
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado como socio ni no socio.");
                    return;
                }

                MySqlCommand comando = new MySqlCommand(query, mySqlConnection);
                comando.Parameters.AddWithValue("@Dni", txtDni.Text);
                comando.CommandType = CommandType.Text;


                MySqlDataReader mySqlDataReader;
                mySqlDataReader = comando.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        txtBoxResNombre.Text = mySqlDataReader["Nombre"].ToString();
                        txtBoxResApellido.Text = mySqlDataReader["Apellido"].ToString();

                        if (tipo == "socio")
                        {
                            txtBoxResCodCuota.Text = mySqlDataReader["CodCuotaMensual"].ToString();
                            txtBoxResCod.Text = mySqlDataReader["CodSocio"].ToString();
                            txtBoxResValor.Text = mySqlDataReader["ValorMensual"].ToString();
                            cbResTipoPago.Text = mySqlDataReader["TipoDePago"].ToString();
                            txtBoxResVencimiento.Text = mySqlDataReader["Vencimiento"].ToString();
                        }
                        else if (tipo == "nosocio")
                        {
                            txtBoxResCodCuota.Text = mySqlDataReader["CodCuotaDiaria"].ToString();
                            txtBoxResCod.Text = mySqlDataReader["CodNoSocio"].ToString();
                            txtBoxResValor.Text = mySqlDataReader["ValorFinal"].ToString();
                            cbResTipoPago.Text = mySqlDataReader["TipoDePago"].ToString();
                            txtBoxResVencimiento.Text = "No posee.";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro el cliente.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Opciones>().Any())
            {
                Application.OpenForms.OfType<Opciones>().First().Show();
            }
            else
            {
                Opciones opciones = new Opciones();
                opciones.Show();
            }
            this.Close();
        }
    }

}
