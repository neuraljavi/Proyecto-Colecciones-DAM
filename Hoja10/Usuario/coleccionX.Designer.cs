namespace proyectoFinalMisCositas
{
    partial class coleccionX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coleccionX));
            this.dgvMisObjetos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeAdquisicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoja10DataSet1 = new Hoja10.Hoja10DataSet1();
            this.articuloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoja10DataSet2 = new Hoja10.Hoja10DataSet2();
            this.nombreColeccion = new System.Windows.Forms.Label();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnBorrarArticulo = new System.Windows.Forms.Button();
            this.btnVolverAIndex = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.inputBusqueda = new System.Windows.Forms.TextBox();
            this.seleccionDeCampo = new System.Windows.Forms.ComboBox();
            this.articuloTableAdapter = new Hoja10.Hoja10DataSet1TableAdapters.ArticuloTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.articuloTableAdapter1 = new Hoja10.Hoja10DataSet2TableAdapters.ArticuloTableAdapter();
            this.exportarExcel = new System.Windows.Forms.Button();
            this.guardarArchivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoja10DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoja10DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMisObjetos
            // 
            this.dgvMisObjetos.AutoGenerateColumns = false;
            this.dgvMisObjetos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(182)))), ((int)(((byte)(174)))));
            this.dgvMisObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisObjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaDeAdquisicionDataGridViewTextBoxColumn,
            this.fechaDeSalidaDataGridViewTextBoxColumn,
            this.Imagen});
            this.dgvMisObjetos.DataSource = this.articuloBindingSource;
            this.dgvMisObjetos.Location = new System.Drawing.Point(26, 297);
            this.dgvMisObjetos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMisObjetos.Name = "dgvMisObjetos";
            this.dgvMisObjetos.RowHeadersWidth = 62;
            this.dgvMisObjetos.RowTemplate.Height = 28;
            this.dgvMisObjetos.Size = new System.Drawing.Size(929, 181);
            this.dgvMisObjetos.TabIndex = 9;
            this.dgvMisObjetos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisObjetos_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 90;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 275;
            // 
            // fechaDeAdquisicionDataGridViewTextBoxColumn
            // 
            this.fechaDeAdquisicionDataGridViewTextBoxColumn.DataPropertyName = "FechaDeAdquisicion";
            this.fechaDeAdquisicionDataGridViewTextBoxColumn.HeaderText = "FechaDeAdquisicion";
            this.fechaDeAdquisicionDataGridViewTextBoxColumn.Name = "fechaDeAdquisicionDataGridViewTextBoxColumn";
            // 
            // fechaDeSalidaDataGridViewTextBoxColumn
            // 
            this.fechaDeSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaDeSalida";
            this.fechaDeSalidaDataGridViewTextBoxColumn.HeaderText = "FechaDeSalida";
            this.fechaDeSalidaDataGridViewTextBoxColumn.Name = "fechaDeSalidaDataGridViewTextBoxColumn";
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "Imagen";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.hoja10DataSet1;
            // 
            // hoja10DataSet1
            // 
            this.hoja10DataSet1.DataSetName = "Hoja10DataSet1";
            this.hoja10DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloBindingSource1
            // 
            this.articuloBindingSource1.DataMember = "Articulo";
            this.articuloBindingSource1.DataSource = this.hoja10DataSet2;
            // 
            // hoja10DataSet2
            // 
            this.hoja10DataSet2.DataSetName = "Hoja10DataSet2";
            this.hoja10DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreColeccion
            // 
            this.nombreColeccion.AutoSize = true;
            this.nombreColeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(59)))), ((int)(((byte)(96)))));
            this.nombreColeccion.Font = new System.Drawing.Font("Harry P", 114.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreColeccion.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreColeccion.Location = new System.Drawing.Point(172, 29);
            this.nombreColeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreColeccion.Name = "nombreColeccion";
            this.nombreColeccion.Size = new System.Drawing.Size(669, 152);
            this.nombreColeccion.TabIndex = 8;
            this.nombreColeccion.Text = "Mis Articulos";
            this.nombreColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.btnModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Harry P", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificarArticulo.Location = new System.Drawing.Point(502, 504);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(216, 46);
            this.btnModificarArticulo.TabIndex = 7;
            this.btnModificarArticulo.Text = "MODIFICAR";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnBorrarArticulo
            // 
            this.btnBorrarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.btnBorrarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarArticulo.Font = new System.Drawing.Font("Harry P", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarArticulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBorrarArticulo.Location = new System.Drawing.Point(739, 504);
            this.btnBorrarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarArticulo.Name = "btnBorrarArticulo";
            this.btnBorrarArticulo.Size = new System.Drawing.Size(216, 46);
            this.btnBorrarArticulo.TabIndex = 6;
            this.btnBorrarArticulo.Text = "ELIMINAR";
            this.btnBorrarArticulo.UseVisualStyleBackColor = false;
            this.btnBorrarArticulo.Click += new System.EventHandler(this.btnBorrarArticulo_Click);
            // 
            // btnVolverAIndex
            // 
            this.btnVolverAIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.btnVolverAIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAIndex.Font = new System.Drawing.Font("Harry P", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAIndex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolverAIndex.Location = new System.Drawing.Point(26, 504);
            this.btnVolverAIndex.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverAIndex.Name = "btnVolverAIndex";
            this.btnVolverAIndex.Size = new System.Drawing.Size(216, 46);
            this.btnVolverAIndex.TabIndex = 5;
            this.btnVolverAIndex.Text = "Mis Colecciones";
            this.btnVolverAIndex.UseVisualStyleBackColor = false;
            this.btnVolverAIndex.Click += new System.EventHandler(this.btnVolverAIndex_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Harry P", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(263, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "CREAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBusqueda
            // 
            this.inputBusqueda.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBusqueda.Location = new System.Drawing.Point(530, 209);
            this.inputBusqueda.Multiline = true;
            this.inputBusqueda.Name = "inputBusqueda";
            this.inputBusqueda.Size = new System.Drawing.Size(308, 74);
            this.inputBusqueda.TabIndex = 11;
            this.inputBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBusqueda_KeyUp);
            // 
            // seleccionDeCampo
            // 
            this.seleccionDeCampo.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionDeCampo.FormattingEnabled = true;
            this.seleccionDeCampo.Items.AddRange(new object[] {
            "Nombre",
            "Precio",
            "Descripción",
            "Fecha de adquisición",
            "Fecha de salida"});
            this.seleccionDeCampo.Location = new System.Drawing.Point(174, 227);
            this.seleccionDeCampo.Name = "seleccionDeCampo";
            this.seleccionDeCampo.Size = new System.Drawing.Size(268, 31);
            this.seleccionDeCampo.TabIndex = 12;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // articuloTableAdapter1
            // 
            this.articuloTableAdapter1.ClearBeforeFill = true;
            // 
            // exportarExcel
            // 
            this.exportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.exportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportarExcel.Font = new System.Drawing.Font("Harry P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarExcel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exportarExcel.Location = new System.Drawing.Point(26, 216);
            this.exportarExcel.Name = "exportarExcel";
            this.exportarExcel.Size = new System.Drawing.Size(105, 52);
            this.exportarExcel.TabIndex = 14;
            this.exportarExcel.Text = "EXPORTAR\r\nA EXCEL";
            this.exportarExcel.UseVisualStyleBackColor = false;
            this.exportarExcel.Click += new System.EventHandler(this.exportarExcel_Click);
            // 
            // coleccionX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.exportarExcel);
            this.Controls.Add(this.seleccionDeCampo);
            this.Controls.Add(this.inputBusqueda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMisObjetos);
            this.Controls.Add(this.nombreColeccion);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnBorrarArticulo);
            this.Controls.Add(this.btnVolverAIndex);
            this.Controls.Add(this.pictureBox1);
            this.Name = "coleccionX";
            this.Text = "Colección";
            this.Load += new System.EventHandler(this.coleccionX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoja10DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoja10DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMisObjetos;
        private System.Windows.Forms.Label nombreColeccion;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnBorrarArticulo;
        private System.Windows.Forms.Button btnVolverAIndex;
        private System.Windows.Forms.Button button1;
        private Hoja10.Hoja10DataSet1 hoja10DataSet1;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private Hoja10.Hoja10DataSet1TableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.TextBox inputBusqueda;
        private System.Windows.Forms.ComboBox seleccionDeCampo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Hoja10.Hoja10DataSet2 hoja10DataSet2;
        private System.Windows.Forms.BindingSource articuloBindingSource1;
        private Hoja10.Hoja10DataSet2TableAdapters.ArticuloTableAdapter articuloTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeAdquisicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.Button exportarExcel;
        private System.Windows.Forms.SaveFileDialog guardarArchivo;
    }
}