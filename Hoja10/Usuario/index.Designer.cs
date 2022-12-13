
namespace proyectoFinalMisCositas
{
    partial class index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.btnCrearColeccion = new System.Windows.Forms.Button();
            this.btnMisColecciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearColeccion
            // 
            this.btnCrearColeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearColeccion.Font = new System.Drawing.Font("Harry P", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearColeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(59)))), ((int)(((byte)(96)))));
            this.btnCrearColeccion.Location = new System.Drawing.Point(102, 278);
            this.btnCrearColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearColeccion.Name = "btnCrearColeccion";
            this.btnCrearColeccion.Size = new System.Drawing.Size(367, 200);
            this.btnCrearColeccion.TabIndex = 0;
            this.btnCrearColeccion.Text = "Nueva Coleccion";
            this.btnCrearColeccion.UseVisualStyleBackColor = true;
            this.btnCrearColeccion.Click += new System.EventHandler(this.btnCrearColeccion_Click);
            // 
            // btnMisColecciones
            // 
            this.btnMisColecciones.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btnMisColecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.btnMisColecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisColecciones.Font = new System.Drawing.Font("Harry P", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisColecciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMisColecciones.Location = new System.Drawing.Point(541, 278);
            this.btnMisColecciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnMisColecciones.Name = "btnMisColecciones";
            this.btnMisColecciones.Size = new System.Drawing.Size(367, 200);
            this.btnMisColecciones.TabIndex = 1;
            this.btnMisColecciones.Text = "Mis Colecciones";
            this.btnMisColecciones.UseVisualStyleBackColor = false;
            this.btnMisColecciones.Click += new System.EventHandler(this.btnMisColecciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(59)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Harry P", 114.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(189, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.label1.Size = new System.Drawing.Size(651, 172);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mis Cositas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMisColecciones);
            this.Controls.Add(this.btnCrearColeccion);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "index";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearColeccion;
        private System.Windows.Forms.Button btnMisColecciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

