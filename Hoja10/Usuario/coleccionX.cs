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
using System.Resources;
using SpreadsheetLight;
using System.IO;

namespace proyectoFinalMisCositas
{
    public partial class coleccionX : Form
    {
        private int idColSeleccionada;
        private int idObjetoSeleccionado = 0;

        public int getIdSeleccionado()
        {
            return idColSeleccionada;
        }

        public void setIdSeleccionado(int idSeleccionadoIntroducir)
        {
            idColSeleccionada = idSeleccionadoIntroducir;
        }

        public int getIdObjetoSeleccionado()
        {
            return idObjetoSeleccionado;
        }

        public void setIdObjetoSeleccionado(int idSeleccionadoIntroducir)
        {
            idObjetoSeleccionado = idSeleccionadoIntroducir;
        }

        public coleccionX(int idSeleccionado)
        {
            this.idColSeleccionada = idSeleccionado;
            InitializeComponent();
            using (var contexto = new Hoja10Entities1())
            {
                List<Articulo> articulos = new List<Articulo>();
                var relaciones = contexto.RelColecArt.ToList().Where(x => x.id_Colecciones == idColSeleccionada);
                foreach (var relacion in relaciones)
                {
                    articulos.AddRange(contexto.Articulo.ToList().Where(x => x.Id == relacion.id_Articulo));
                }
                dgvMisObjetos.DataSource = articulos;
                var lista = contexto.Colecciones.First(x => x.Id == idColSeleccionada);
                nombreColeccion.Text = lista.Nombre;
            }
            dgvMisObjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articuloTableAdapter.Fill(this.hoja10DataSet1.Articulo);
            idObjetoSeleccionado = 0;
        }

        private void btnVolverAIndex_Click(object sender, EventArgs e)
        {
            var index = new index();
            index.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevoArticulo = new nuevoArticulo(idColSeleccionada);
            try
            {
                nuevoArticulo.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                nuevoArticulo.Hide();
            }
        }

        public void coleccionX_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hoja10DataSet2.Articulo' Puede moverla o quitarla según sea necesario.
            this.articuloTableAdapter1.Fill(this.hoja10DataSet2.Articulo);
            // TODO: esta línea de código carga datos en la tabla 'hoja10DataSet1.Articulo' Puede moverla o quitarla según sea necesario.
            using (var contexto = new Hoja10Entities1())
            {
                var filtro = contexto.Articulo.ToList().Where(x => x.Id == getIdSeleccionado());
            }
            this.articuloTableAdapter.Fill(this.hoja10DataSet1.Articulo);

            Show();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            if (idObjetoSeleccionado != 0)
            {
                var modifArticulo = new articuloX(idObjModif: idObjetoSeleccionado, idColModif: idColSeleccionada);
                modifArticulo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ningún objeto seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBorrarArticulo_Click(object sender, EventArgs e)
        {
            if (idObjetoSeleccionado != 0)
            {
                var dialog = MessageBox.Show("¿Está seguro de que desea eliminar este artículo?" +
                    "\nEsta acción no puede ser deshecha", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    using (var contexto = new Hoja10Entities1())
                    {
                        RelColecArt relacionEliminar = contexto.RelColecArt.First(x => x.id_Articulo ==
                            contexto.Articulo.FirstOrDefault(r => r.Id == idObjetoSeleccionado).Id);
                        contexto.RelColecArt.Remove(relacionEliminar);
                        Articulo articuloEliminar = contexto.Articulo.FirstOrDefault(x => x.Id == idObjetoSeleccionado);
                        contexto.Articulo.Remove(articuloEliminar);
                        contexto.SaveChanges();
                        List<Articulo> articulos = new List<Articulo>();
                        var relaciones = contexto.RelColecArt.ToList().Where(x => x.id_Colecciones == idColSeleccionada);
                        foreach (var relacion in relaciones)
                        {
                            articulos.AddRange(contexto.Articulo.ToList().Where(x => x.Id == relacion.id_Articulo));
                        }
                        dgvMisObjetos.DataSource = articulos;
                        var lista = contexto.Colecciones.First(x => x.Id == idColSeleccionada);
                        nombreColeccion.Text = lista.Nombre;
                    }
                    this.articuloTableAdapter.Fill(this.hoja10DataSet1.Articulo);
                }
            }
        }

        private void dgvMisObjetos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMisObjetos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvMisObjetos.CurrentRow.Selected = true;
                    idObjetoSeleccionado = int.Parse(dgvMisObjetos.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                }
            }
            catch
            {
                idObjetoSeleccionado = 0;
            }
        }

        private void inputBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            using (var contexto = new Hoja10Entities1())
            {
                List<Articulo> filtro = new List<Articulo>();
                var ids = contexto.RelColecArt.ToList().Where(x => x.id_Colecciones == idColSeleccionada);
                foreach (var id in ids)
                {
                    filtro.AddRange(contexto.Articulo.ToList().Where(x => x.Id == id.id_Articulo));
                }
                var resultado = new List<Articulo>();
                if (seleccionDeCampo.SelectedItem != null)
                {
                    switch (seleccionDeCampo.SelectedItem.ToString())
                    {
                        case ("Precio"):
                            resultado = filtro.Where(x => x.Precio == (decimal?)float.Parse(inputBusqueda.Text)).ToList();
                            break;
                        case ("Descripción"):
                            resultado = filtro.Where(x => x.Descripcion.ToLower().Contains(inputBusqueda.Text.ToLower())).ToList();
                            break;
                        case ("Fecha de adquisición"):
                            resultado = filtro.Where(x => x.FechaDeAdquisicion.ToString().Contains(inputBusqueda.Text)).ToList();
                            break;
                        case ("Fecha de salida"):
                            resultado = filtro.Where(x => x.FechaDeSalida.ToString().Contains(inputBusqueda.Text)).ToList();
                            break;
                        default:
                            resultado = filtro.Where(x => x.Nombre.ToLower().Contains(inputBusqueda.Text.ToLower())).ToList();
                            break;
                    }
                    dgvMisObjetos.DataSource = resultado;
                }
                if (inputBusqueda.Text == "")
                {
                    dgvMisObjetos.DataSource = filtro;
                }
            }
        }

        private void exportarExcel_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.Bold = true;

            int iC = 1;
            foreach (DataGridViewColumn column in dgvMisObjetos.Columns)
            {
                sl.SetCellValue(1, iC, column.HeaderText.ToString());
                sl.SetCellStyle(1, iC, style);
                iC++;
            }

            int iR = 2;
            foreach (DataGridViewRow row in dgvMisObjetos.Rows)
            {
                sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                sl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                sl.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                iR++;
            }

            using (var contexto = new Hoja10Entities1())
            {
                var lista = contexto.Colecciones.First(x => x.Id == idColSeleccionada);
                guardarArchivo.InitialDirectory = "Documentos";
                guardarArchivo.Filter = "Libro de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|";
                guardarArchivo.FileName = lista.Nombre + ".xlsx";
                guardarArchivo.RestoreDirectory = true;
                guardarArchivo.Title = "Exportar a Excel";
                string ruta = guardarArchivo.FileName;
                guardarArchivo.OverwritePrompt = true;

                if (guardarArchivo.ShowDialog() == DialogResult.OK)
                {
                    if (guardarArchivo.FileName != "")
                    {
                        string fullPath = Path.GetFullPath(guardarArchivo.FileName);
                        sl.SaveAs(fullPath);
                    }
                }
            }
        }
    }
}
