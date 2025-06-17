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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void InscripcionBtn_Click(object sender, EventArgs e)
        {
            Form inscripcionWdw = new Inscripcion();
            inscripcionWdw.ShowDialog();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

<<<<<<< HEAD
        private void BajaBtn_Click(object sender, EventArgs e)
        {
            Form bajaWdw = new Baja_Socio();
            bajaWdw.ShowDialog();
=======
        private void ListarBtn_Click(object sender, EventArgs e)
        {
            VerClientes verClientes = new VerClientes();
            verClientes.Show();
>>>>>>> 52cb9a33b27e26d5f1d56cfd18dc456506ed35e5
        }
    }
}
