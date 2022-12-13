namespace proyectoFinalMisCositas
{
    partial class misColecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(misColecciones));
            this.btnVolverAIndex = new System.Windows.Forms.Button();
            this.btnVerColeccion = new System.Windows.Forms.Button();
            this.btnBorrarColeccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataMisColecciones = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoja10DataSet = new Hoja10.Hoja10DataSet();
            this.inputBusqueda = new System.Windows.Forms.TextBox();
            this.seleccionDeCampo = new System.Windows.Forms.ComboBox();
            this.coleccionesTableAdapter = new Hoja10.Hoja10DataSetTableAdapters.ColeccionesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMisColecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoja10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnVolverAIndex.TabIndex = 0;
            this.btnVolverAIndex.Text = "HOME";
            this.btnVolverAIndex.UseVisualStyleBackColor = false;
            this.btnVolverAIndex.Click += new System.EventHandler(this.btnVolverAIndex_Click);
            // 
            // btnVerColeccion
            // 
            this.btnVerColeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.btnVerColeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerColeccion.Font = new System.Drawing.Font("Harry P", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerColeccion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerColeccion.Location = new System.Drawing.Point(382, 504);
            this.btnVerColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerColeccion.Name = "btnVerColeccion";
            this.btnVerColeccion.Size = new System.Drawing.Size(216, 46);
            this.btnVerColeccion.TabIndex = 1;
            this.btnVerColeccion.Text = "Ver Coleccion";
            this.btnVerColeccion.UseVisualStyleBackColor = false;
            this.btnVerColeccion.Click += new System.EventHandler(this.btnVerColeccion_Click);
            // 
            // btnBorrarColeccion
            // 
            this.btnBorrarColeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.btnBorrarColeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarColeccion.Font = new System.Drawing.Font("Harry P", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarColeccion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBorrarColeccion.Location = new System.Drawing.Point(734, 503);
            this.btnBorrarColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarColeccion.Name = "btnBorrarColeccion";
            this.btnBorrarColeccion.Size = new System.Drawing.Size(216, 46);
            this.btnBorrarColeccion.TabIndex = 2;
            this.btnBorrarColeccion.Text = "Borrar Coleccion";
            this.btnBorrarColeccion.UseVisualStyleBackColor = false;
            this.btnBorrarColeccion.Click += new System.EventHandler(this.btnBorrarColeccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(59)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Harry P", 114.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(124, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 152);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mis Colecciones";
            // 
            // dataMisColecciones
            // 
            this.dataMisColecciones.AutoGenerateColumns = false;
            this.dataMisColecciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(182)))), ((int)(((byte)(174)))));
            this.dataMisColecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMisColecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nombreDataGridViewTextBoxColumn,
            this.tipoDeArticuloDataGridViewTextBoxColumn});
            this.dataMisColecciones.DataSource = this.coleccionesBindingSource;
            this.dataMisColecciones.Location = new System.Drawing.Point(212, 277);
            this.dataMisColecciones.Margin = new System.Windows.Forms.Padding(2);
            this.dataMisColecciones.Name = "dataMisColecciones";
            this.dataMisColecciones.RowHeadersWidth = 152;
            this.dataMisColecciones.RowTemplate.Height = 28;
            this.dataMisColecciones.Size = new System.Drawing.Size(554, 207);
            this.dataMisColecciones.TabIndex = 4;
            this.dataMisColecciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMisColecciones_CellClick);
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
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoDeArticuloDataGridViewTextBoxColumn
            // 
            this.tipoDeArticuloDataGridViewTextBoxColumn.DataPropertyName = "TipoDeArticulo";
            this.tipoDeArticuloDataGridViewTextBoxColumn.HeaderText = "TipoDeArticulo";
            this.tipoDeArticuloDataGridViewTextBoxColumn.Name = "tipoDeArticuloDataGridViewTextBoxColumn";
            this.tipoDeArticuloDataGridViewTextBoxColumn.Width = 150;
            // 
            // coleccionesBindingSource
            // 
            this.coleccionesBindingSource.DataMember = "Colecciones";
            this.coleccionesBindingSource.DataSource = this.hoja10DataSet;
            // 
            // hoja10DataSet
            // 
            this.hoja10DataSet.DataSetName = "Hoja10DataSet";
            this.hoja10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputBusqueda
            // 
            this.inputBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBusqueda.Location = new System.Drawing.Point(508, 223);
            this.inputBusqueda.Name = "inputBusqueda";
            this.inputBusqueda.Size = new System.Drawing.Size(258, 31);
            this.inputBusqueda.TabIndex = 5;
            this.inputBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBusqueda_KeyUp);
            // 
            // seleccionDeCampo
            // 
            this.seleccionDeCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionDeCampo.FormattingEnabled = true;
            this.seleccionDeCampo.Items.AddRange(new object[] {
            "Nombre",
            "Tipo de artículo"});
            this.seleccionDeCampo.Location = new System.Drawing.Point(212, 223);
            this.seleccionDeCampo.Name = "seleccionDeCampo";
            this.seleccionDeCampo.Size = new System.Drawing.Size(269, 33);
            this.seleccionDeCampo.TabIndex = 7;
            // 
            // coleccionesTableAdapter
            // 
            this.coleccionesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // misColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.seleccionDeCampo);
            this.Controls.Add(this.inputBusqueda);
            this.Controls.Add(this.dataMisColecciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarColeccion);
            this.Controls.Add(this.btnVerColeccion);
            this.Controls.Add(this.btnVolverAIndex);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "misColecciones";
            this.Text = "Mis Colecciones";
            this.Load += new System.EventHandler(this.misColecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMisColecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoja10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverAIndex;
        private System.Windows.Forms.Button btnVerColeccion;
        private System.Windows.Forms.Button btnBorrarColeccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataMisColecciones;
        private Hoja10.Hoja10DataSet hoja10DataSet;
        private System.Windows.Forms.BindingSource coleccionesBindingSource;
        private Hoja10.Hoja10DataSetTableAdapters.ColeccionesTableAdapter coleccionesTableAdapter;
        private System.Windows.Forms.TextBox inputBusqueda;
        private System.Windows.Forms.ComboBox seleccionDeCampo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeArticuloDataGridViewTextBoxColumn;
    }
}