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
                string respuesta;
                E_Cliente cliente = new E_Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Dni = Convert.ToInt32(txtDni.Text);
                cliente.FechaNac = dtpFechaNac.Value;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Email = txtEmail.Text;
                cliente.FichaMedica = estado;
                Datos.Clientes clientes = new Datos.Clientes();
                respuesta = clientes.Nuevo_Cliente(cliente);
                MessageBox.Show("Cliente" + cliente.Apellido);
                bool esNumero = int.TryParse(respuesta, out int codigo);
                if (esNumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("El cliente ya existe", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El cliente se registró con éxito con el código número: " + respuesta,
                             "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
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
    }
}
