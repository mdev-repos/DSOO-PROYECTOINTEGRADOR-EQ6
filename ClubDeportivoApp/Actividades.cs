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
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CrearBtn_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario Crear_Actividad
            Crear_Actividad crearActividadForm = new Crear_Actividad();
            // Copia el tamaño de la ventana anterior
            crearActividadForm.Size = this.Size;
            // Mostramos el formulario
            crearActividadForm.ShowDialog(); // Muestra como ventana modal
        }
    }
}
