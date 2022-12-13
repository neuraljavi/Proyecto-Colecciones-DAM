using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hoja10.Datos;
using Hoja10.Logica;

namespace proyectoFinalMisCositas
{
    public partial class articuloX : Form
    {
        private int idColSeleccionada = 0;
        private int idObjetoSeleccionado = 0;
        private String ruta = "";

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

        public String getRuta()
        {
            return ruta;
        }

        public void setRuta(String rutaIntroducir)
        {
            ruta = rutaIntroducir;
        }

        public articuloX(int idObjModif, int idColModif)
        {
            try
            {
                Console.WriteLine(idObjModif);
                this.idObjetoSeleccionado = idObjModif;
                this.idColSeleccionada = idColModif;
                InitializeComponent();
                using (var contexto = new Hoja10Entities1())
                {
                    Articulo articuloModificar = contexto.Articulo.First(a => a.Id == idObjetoSeleccionado);
                    inputNombre.Text = articuloModificar.Nombre;
                    inputPrecio.Text = articuloModificar.Precio.ToString();
                    inputFechaSalida.Value = articuloModificar.FechaDeSalida.Value;
                    inputDescripcion.Text = articuloModificar.Descripcion;
                    inputFechaAdquisicion.Value = articuloModificar.FechaDeAdquisicion.Value;
                    picboxArticulo.ImageLocation = "../../Resources/Input/" + articuloModificar.Imagen;
                    ruta = articuloModificar.Imagen;
                    picboxArticulo.Load();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo algún error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
            }

        }

        private void btnVolverAIndex_Click(object sender, EventArgs e)
        {
            var coleccion = new coleccionX(idColSeleccionada);
            coleccion.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add(inputNombre.Text);
            lista.Add(inputDescripcion.Text);
            lista.Add(inputPrecio.Text);
            lista.Add(inputFechaAdquisicion.Text);
            lista.Add(inputFechaSalida.Text);
            lista.Add(ruta);

            if (Validar.noSonNull(lista))
            {
                var dialog = MessageBox.Show("¿Está seguro de que desea modificar este artículo?",
                    "Alert!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (var contexto = new Hoja10Entities1())
                    {
                        Articulo articuloModificar = contexto.Articulo.First(a => a.Id == idObjetoSeleccionado);
                        articuloModificar.Nombre = inputNombre.Text;
                        articuloModificar.Descripcion = inputDescripcion.Text;
                        articuloModificar.Precio = Math.Round((decimal)float.Parse(inputPrecio.Text), 2);
                        articuloModificar.FechaDeAdquisicion = inputFechaAdquisicion.Value;
                        articuloModificar.FechaDeSalida = inputFechaSalida.Value;
                        articuloModificar.Imagen = guardarFoto();
                        contexto.SaveChanges();
                    }
                    var coleccion = new coleccionX(idColSeleccionada);
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

        private String guardarFoto()
        {
            string ruta = getRuta();
            string nombre = ruta.Substring(ruta.LastIndexOf("\\") + 1);
            Image imagen = Image.FromFile(ruta);
            imagen.Save("../../Resources/Input/" + nombre);
            return nombre;
        }
    }
}
