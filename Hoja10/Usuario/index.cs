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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void btnCrearColeccion_Click(object sender, EventArgs e)
        {
            var nuevaCol = new nuevaColeccion();
            nuevaCol.Show();
            this.Hide();
        }

        private void btnMisColecciones_Click(object sender, EventArgs e)
        {
            var colecciones = new misColecciones();
            colecciones.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
