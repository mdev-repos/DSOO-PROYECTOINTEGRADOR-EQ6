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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void CobrarBtn_Click(object sender, EventArgs e)
        {
            Form pagarWdw = new Pagar();
            pagarWdw.ShowDialog();

            this.Close();
        }

        private void ListarMorososBtn_Click(object sender, EventArgs e)
        {
            Form listadoWdw = new Listado();
            listadoWdw.ShowDialog();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ComprobantesBtn_Click(object sender, EventArgs e)
        {
            Form comprobantesWdw = new Comprobantes();
            comprobantesWdw.ShowDialog();
        }
    }
}
