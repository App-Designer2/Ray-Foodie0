namespace Ray_Foodie
{
    partial class TarjetaPlatillo
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarjetaPlatillo));
            picImagen = new PictureBox();
            lblTitulo = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // picImagen
            // 
            picImagen.Image = (Image)resources.GetObject("picImagen.Image");
            picImagen.Location = new Point(8, 3);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(110, 114);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            picImagen.Click += Control_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(134, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(240, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Nombre del Platillo";
            lblTitulo.Click += Control_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.ForeColor = Color.DimGray;
            lblDescripcion.Location = new Point(134, 45);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(240, 25);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción corta del plato....";
            lblDescripcion.Click += Control_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.FromArgb(255, 128, 0);
            lblPrecio.Location = new Point(134, 79);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(78, 30);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "0,00 €";
            lblPrecio.Click += Control_Click;
            // 
            // TarjetaPlatillo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Controls.Add(picImagen);
            Name = "TarjetaPlatillo";
            Size = new Size(745, 120);
            Click += Control_Click;
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagen;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblPrecio;
    }
}
