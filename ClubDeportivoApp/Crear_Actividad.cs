using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoApp
{
    public partial class Crear_Actividad : Form
    {
        public Crear_Actividad()
        {
            InitializeComponent();
        }

        private void btnVolverActividad_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas volver?",
                                             "Confirmación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close(); // Cierra Crear_Actividad
            }
        }

        private void cbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDias.SelectedIndex != -1)
            {
                cbHorarios.Enabled = true; // Habilita el ComboBox de horarios
            }
            else
            {
                cbHorarios.Enabled = false; // Deshabilita el ComboBox de horarios si no hay selección
            }
        }

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {
            // Verifica que el usuario haya ingresado un nombre de actividad
            if (!string.IsNullOrWhiteSpace(txtActividad.Text))
            {
                txtCodigo.Text = "ACT-" + txtActividad.Text;
            }
            else
            {
                txtCodigo.Text = string.Empty; // Limpia el código si no hay actividad
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Restablecer todos los valores iniciales
            txtActividad.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtProfesor.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            cbDias.SelectedIndex = -1;
            cbHorarios.SelectedIndex = -1;

            // Mantener cbHorarios deshabilitado pero sin eliminarlo
            cbHorarios.Enabled = false;

            // Eliminar solo los ComboBox adicionales generados dinámicamente
            List<Control> controlesAEliminar = new List<Control>();

            foreach (Control control in this.Controls)
            {
                if (control is ComboBox && control != cbDias && control != cbHorarios)
                {
                    controlesAEliminar.Add(control);
                }
            }

            foreach (Control control in controlesAEliminar)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }
    }
}
