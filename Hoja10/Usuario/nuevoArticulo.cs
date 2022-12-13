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
    public partial class nuevoArticulo : Form
    {
        private int idSeleccionadoCol;
        private String ruta = "";

        public int getIdSeleccionado()
        {
            return idSeleccionadoCol;
        }

        public void setIdSeleccionado(int idSeleccionadoIntroducir)
        {
            idSeleccionadoCol = idSeleccionadoIntroducir;
        }

        public nuevoArticulo(int idSeleccionado)
        {
            this.idSeleccionadoCol = idSeleccionado;
            InitializeComponent();
        }

        private void btnVolverAIndex_Click(object sender, EventArgs e)
        {
            var coleccion = new coleccionX(idSeleccionadoCol);
            coleccion.Show();
            this.Hide();
        }
        
        public String getRuta()
        {
            return ruta;
        }

        public void setRuta(String rutaIntroducir)
        {
            ruta = rutaIntroducir;
        }

        private void btnAnadirColeccion_Click_1(object sender, EventArgs e)
        {
            Articulo articuloAgregar = new Articulo();
            List<string> lista = new List<string>();
            lista.Add(inputNombre.Text);
            lista.Add(inputDescripcion.Text);
            lista.Add(inputPrecio.Text);
            lista.Add(fechaAdquisicion.Text);
            lista.Add(fechaSalida.Text);
            lista.Add(ruta);

            if (Validar.noSonNull(lista))
            {
                articuloAgregar.Nombre = inputNombre.Text;
                articuloAgregar.Descripcion = inputDescripcion.Text;
                articuloAgregar.Precio = (decimal?)float.Parse(inputPrecio.Text);
                articuloAgregar.FechaDeAdquisicion = fechaAdquisicion.Value;
                articuloAgregar.FechaDeSalida = fechaSalida.Value;
                articuloAgregar.Imagen = guardarFoto();
                var dialog = MessageBox.Show("¿Está seguro de que desa añadir este artículo?" +
                    "\nNombre: " + articuloAgregar.Nombre +
                    "\nPrecio: " + articuloAgregar.Precio +
                    "\nFecha de adquisición: " + articuloAgregar.FechaDeAdquisicion.ToString() +
                    "\nFecha de salida" + articuloAgregar.FechaDeSalida.ToString() +
                    "\nDescripción" + articuloAgregar.Descripcion,
                    "Alert!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    using (var contexto = new Hoja10Entities1())
                    {
                        contexto.Articulo.Add(articuloAgregar);
                        contexto.SaveChanges();
                        int idArticuloRel = contexto.Articulo.Max(x => x.Id);
                        RelColecArt nuevaRelacion = new RelColecArt();
                        nuevaRelacion.id_Articulo = idArticuloRel;
                        nuevaRelacion.id_Colecciones = idSeleccionadoCol;
                        contexto.RelColecArt.Add(nuevaRelacion);
                        contexto.SaveChanges();
                    }

                    inputNombre.Text = "";
                    inputPrecio.Text = "";
                    inputDescripcion.Text = "";
                    fechaAdquisicion.Value = DateTime.Now;
                    fechaSalida.Value = fechaSalida.MinDate;

                    var coleccion = new coleccionX(idSeleccionadoCol);
                    coleccion.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Por favor, no deje ningún campo sin rellenar",
                    "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private String guardarFoto()
        {
            string ruta = getRuta();
            string nombre = ruta.Substring(ruta.LastIndexOf("\\") + 1);
            Image imagen = Image.FromFile(ruta);
            imagen.Save("../../Resources/Input/" + nombre);
            return nombre;
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            dialogoBuscarImagen = new OpenFileDialog();

            dialogoBuscarImagen.InitialDirectory = "Imágenes";
            dialogoBuscarImagen.Filter = "Archivos de imágenes (*.jpg)|*.jpg|Archivos de imágenes (*.png)|*.png|Archivos de imágenes (*.gif)|*.gif";
            dialogoBuscarImagen.RestoreDirectory = true;

            if (dialogoBuscarImagen.ShowDialog() == DialogResult.OK)
            {
                ruta = dialogoBuscarImagen.FileName;
                picboxArticulo.ImageLocation = ruta;
            }
        }
    }
}
