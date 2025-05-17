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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InscripcionBtn_Click(object sender, EventArgs e)
        {

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InscripcionBtn_Click_1(object sender, EventArgs e)
        {
            Form inscripcionWdw = new Inscripcion();
            inscripcionWdw.ShowDialog();
        }
    }
}
