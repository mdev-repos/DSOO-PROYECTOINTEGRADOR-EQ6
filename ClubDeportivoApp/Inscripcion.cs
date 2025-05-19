using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivoApp.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivoApp
{
    public partial class Inscripcion : Form
    {
        bool estado;
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || dtpFechaNac.Value == DateTime.Now ||
                txtDireccion.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Se deben completar todos los datos", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtSocio.Checked)
                {
                    string respuesta;
                    E_Socio socio = new E_Socio();
                    socio.Nombre = txtNombre.Text;
                    socio.Apellido = txtApellido.Text;
                    socio.Dni = Convert.ToInt32(txtDni.Text);
                    socio.FechaNac = dtpFechaNac.Value;
                    socio.Direccion = txtDireccion.Text;
                    socio.Telefono = txtTelefono.Text;
                    socio.Email = txtEmail.Text;
                    socio.FichaMedica = estado;
                    socio.CodSocio = $"SOC-{socio.Dni}";
                    socio.Carnet = true;
                    socio.FechaInscripcion = DateTime.Now.ToString("yyyy-MM-dd");
                    socio.Moroso = false;

                    Datos.Socio socioDatos = new Datos.Socio();
                    respuesta = socioDatos.Nuevo_Socio(socio);
                    MessageBox.Show("Socio: " + socio.Apellido + ", " + socio.Nombre);
                    bool esNumero = int.TryParse(respuesta, out int codigo);
                    if (esNumero)
                    {
                        if (codigo == 1)
                        {
                            MessageBox.Show("El socio ya existe", "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"El socio {socio.Nombre} {socio.Apellido} se registró con éxito con el código número: {socio.CodSocio} " + respuesta,
                                 "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                }
                else
                {

                }
            }
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {

        }

        private void rbtnFichaMedica_CheckedChanged(object sender, EventArgs e)
        {

            estado = rbtnFichaMedica.Checked;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtSocio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtNoSocio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea limpiar todos los campos?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                rbtSocio.Checked = false;
                rbtNoSocio.Checked = false;
                txtNombre.Clear();
                txtApellido.Clear();
                txtDni.Clear();
                dtpFechaNac.Value = DateTime.Now;
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                rbtnFichaMedica.Checked = false;
            }
        }
    }
}
