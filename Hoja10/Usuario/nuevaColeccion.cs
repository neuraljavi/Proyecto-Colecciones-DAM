using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hoja10.Logica;
using Hoja10.Datos;

namespace proyectoFinalMisCositas
{
    public partial class nuevaColeccion : Form
    {
        public nuevaColeccion()
        {
            InitializeComponent();
        }

        private void btnVolverAIndex_Click(object sender, EventArgs e)
        {
            var volver = new index();
            volver.Show();
            this.Hide();
        }

        private void btnAnadirColeccion_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(inputNombre.Text);
            list.Add(inputTipo.Text);
            if (Validar.noSonNull(list))
            {
                Colecciones nuevaCole = new Colecciones();
                nuevaCole.Nombre = inputNombre.Text;
                nuevaCole.TipoDeArticulo = inputTipo.Text;
                var dialog = MessageBox.Show("Está seguro de añadir esta colección?" +
                    "\nNombre: " + nuevaCole.Nombre +
                    "\nTipo: " + nuevaCole.TipoDeArticulo,
                    "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    using (var contexto = new Hoja10Entities1())
                    {
                        contexto.Colecciones.Add(nuevaCole);
                        contexto.SaveChanges();
                    }
                    var colecciones = new misColecciones();
                    colecciones.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Por favor, no deje ningún campo sin rellenar",
                    "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
