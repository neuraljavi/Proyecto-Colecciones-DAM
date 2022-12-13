using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hoja10.Datos;

namespace proyectoFinalMisCositas
{
    public partial class misColecciones : Form
    {

        private int idSeleccionado;

        public int getIdSeleccionado()
        {
            return idSeleccionado;
        }

        public void setIdSeleccionado(int idSeleccionadoIntroducir)
        {
            idSeleccionado = idSeleccionadoIntroducir;
        }

        public misColecciones()
        {
            InitializeComponent();
        }

        private void btnVolverAIndex_Click(object sender, EventArgs e)
        {
            var volverIndex = new index();
            volverIndex.Show();
            this.Hide();
        }

        private void btnVerColeccion_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                var vercoleccion = new coleccionX(idSeleccionado);
                vercoleccion.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ninguna colección seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void misColecciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hoja10DataSet.Colecciones' Puede moverla o quitarla según sea necesario.
            this.coleccionesTableAdapter.Fill(this.hoja10DataSet.Colecciones);

        }

        private void btnBorrarColeccion_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                var dialog = MessageBox.Show("¿Está seguro de que desea eliminar esta colección?" +
                    "\nEsta acción no puede ser deshecha", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    using (var contexto = new Hoja10Entities1())
                    {
                        Colecciones coleccionEliminar = contexto.Colecciones.First(x => x.Id == idSeleccionado);
                        List<RelColecArt> relaciones = new List<RelColecArt>();
                        List<Articulo> articulos = new List<Articulo>();
                        relaciones.AddRange(contexto.RelColecArt.ToList().Where(x => x.id_Colecciones == idSeleccionado));
                        foreach (var relacion in relaciones)
                        {
                            articulos.AddRange(contexto.Articulo.ToList().Where(x => x.Id == relacion.id_Articulo));
                        }
                        contexto.RelColecArt.RemoveRange(relaciones);
                        contexto.Articulo.RemoveRange(articulos);
                        contexto.Colecciones.Remove(coleccionEliminar);
                        contexto.SaveChanges();
                        dataMisColecciones.DataSource = contexto.Colecciones.ToList();
                    }
                    
                }
            }
        }

        private void dataMisColecciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataMisColecciones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataMisColecciones.CurrentRow.Selected = true;
                    idSeleccionado = int.Parse(dataMisColecciones.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                }
            }
            catch (Exception)
            {
                idSeleccionado = 0;
            }
        }

        private void inputBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            using (var contexto = new Hoja10Entities1())
            {
                var filtro = contexto.Colecciones;
                var resultado = new List<Colecciones>();
                if (seleccionDeCampo.SelectedItem != null)
                {
                    switch (seleccionDeCampo.SelectedItem.ToString())
                    {
                        case ("Tipo de artículo"):
                            resultado = filtro.Where(x => x.TipoDeArticulo.ToLower().Contains(inputBusqueda.Text.ToLower())).ToList();
                            break;
                        default:
                            resultado = filtro.Where(x => x.Nombre.ToLower().Contains(inputBusqueda.Text.ToLower())).ToList();
                            break;
                    }
                    dataMisColecciones.DataSource = resultado;
                }
                if (inputBusqueda.Text == "")
                {
                    dataMisColecciones.DataSource = filtro.ToList();
                }
            }
        }
    }
}
