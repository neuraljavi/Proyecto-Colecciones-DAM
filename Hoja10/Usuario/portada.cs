using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFinalMisCositas;

namespace proyectoFinalMisCositas
{
    public partial class portada : Form
    {
        public portada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Colecciones = new index();
            Colecciones.Show();
            this.Hide();
        }

        private void btnNosotros_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Participantes:" +
                "\n\nJavier Campos Penas (Back-end & Scrum Master)" +
                "\n\nSegundo Isaac Cornejo Navarro (Base de datos)" +
                "\n\nAlejandra Hinojosa Gonzales (Front-end)" +
                "\n\nMiguel Paniagua Ramos (Base de datos)" +
                "\n\nAitor Paz García (Back-end)" +
                "\n\nSonia Pérez Candela (Front-end)", "Nosotros", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
