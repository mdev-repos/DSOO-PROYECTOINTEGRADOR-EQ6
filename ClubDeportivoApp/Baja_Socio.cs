using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivoApp.Datos;
using ClubDeportivoApp.Entidades;

namespace ClubDeportivoApp
{
    public partial class Baja_Socio : Form
    {
        public Baja_Socio()
        {
            InitializeComponent();
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            Datos.Socio socioDatos = new Datos.Socio();

            if (!int.TryParse(txtDniInput.Text, out int dni) || txtDniInput.Text.Length < 7)
            {
                MessageBox.Show("Ingrese un DNI válido (7-8 dígitos)", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                String codSocio = $"SOC-{txtDniInput.Text}";
                E_Socio socio = socioDatos.ObtenerSocioPorCodigo(codSocio);

                if (socio == null)
                {
                    MessageBox.Show("No se encontró ningún socio asociado al DNI provisto", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtCodCliente.Text = socio.CodSocio;
                    txtNombreCliente.Text = socio.Nombre;
                    txtApellidoCliente.Text = socio.Apellido;

                    if (socio.Activo)
                    {
                        txtEstadoCliente.Text = "ACTIVO";
                        btnReincorporar.Enabled = false;
                        btnBaja.Enabled = true;
                    }
                    else
                    {
                        txtEstadoCliente.Text = "INACTIVO";
                        btnReincorporar.Enabled = true;
                        btnBaja.Enabled = false;
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtEstadoCliente.Text = "";
            txtDniInput.Text = "";
        }
    }
}
