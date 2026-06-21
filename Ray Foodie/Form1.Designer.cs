namespace Ray_Foodie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenuLateral = new Panel();
            button1 = new Button();
            btnKalte = new Button();
            btnDesserts = new Button();
            btnHeisse = new Button();
            btnVegane = new Button();
            label1 = new Label();
            rayFoodie_Name = new Label();
            picLogo = new PictureBox();
            panelCarrito = new Panel();
            btnFacturar = new Button();
            lblTotal = new Label();
            dgvPedido = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            flpContenedorComida = new FlowLayoutPanel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            panelMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.FromArgb(255, 128, 0);
            panelMenuLateral.Controls.Add(button1);
            panelMenuLateral.Controls.Add(btnKalte);
            panelMenuLateral.Controls.Add(btnDesserts);
            panelMenuLateral.Controls.Add(btnHeisse);
            panelMenuLateral.Controls.Add(btnVegane);
            panelMenuLateral.Controls.Add(label1);
            panelMenuLateral.Controls.Add(rayFoodie_Name);
            panelMenuLateral.Controls.Add(picLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(257, 806);
            panelMenuLateral.TabIndex = 0;
            panelMenuLateral.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 193);
            button1.Name = "button1";
            button1.Size = new Size(254, 52);
            button1.TabIndex = 3;
            button1.Text = "Warme Speisen";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // btnKalte
            // 
            btnKalte.FlatAppearance.BorderSize = 0;
            btnKalte.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnKalte.FlatStyle = FlatStyle.Flat;
            btnKalte.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKalte.ForeColor = SystemColors.Control;
            btnKalte.Location = new Point(0, 258);
            btnKalte.Name = "btnKalte";
            btnKalte.Size = new Size(257, 52);
            btnKalte.TabIndex = 3;
            btnKalte.Text = "Kalte Getränke";
            btnKalte.TextAlign = ContentAlignment.MiddleLeft;
            btnKalte.UseVisualStyleBackColor = true;
            btnKalte.UseWaitCursor = true;
            btnKalte.Click += btnKalte_Click;
            // 
            // btnDesserts
            // 
            btnDesserts.FlatAppearance.BorderSize = 0;
            btnDesserts.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnDesserts.FlatStyle = FlatStyle.Flat;
            btnDesserts.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesserts.ForeColor = SystemColors.Control;
            btnDesserts.Location = new Point(0, 396);
            btnDesserts.Name = "btnDesserts";
            btnDesserts.Size = new Size(257, 52);
            btnDesserts.TabIndex = 3;
            btnDesserts.Text = "Kuchen + Desserts";
            btnDesserts.TextAlign = ContentAlignment.MiddleLeft;
            btnDesserts.UseVisualStyleBackColor = true;
            btnDesserts.UseWaitCursor = true;
            btnDesserts.Click += btnDesserts_Click;
            // 
            // btnHeisse
            // 
            btnHeisse.FlatAppearance.BorderSize = 0;
            btnHeisse.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnHeisse.FlatStyle = FlatStyle.Flat;
            btnHeisse.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeisse.ForeColor = SystemColors.Control;
            btnHeisse.Location = new Point(0, 325);
            btnHeisse.Name = "btnHeisse";
            btnHeisse.Size = new Size(254, 52);
            btnHeisse.TabIndex = 3;
            btnHeisse.Text = "Heiße Getränke";
            btnHeisse.TextAlign = ContentAlignment.MiddleLeft;
            btnHeisse.UseVisualStyleBackColor = true;
            btnHeisse.UseWaitCursor = true;
            btnHeisse.Click += btnHeisse_Click;
            // 
            // btnVegane
            // 
            btnVegane.FlatAppearance.BorderSize = 0;
            btnVegane.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVegane.FlatStyle = FlatStyle.Flat;
            btnVegane.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVegane.ForeColor = SystemColors.Control;
            btnVegane.Location = new Point(0, 130);
            btnVegane.Name = "btnVegane";
            btnVegane.Size = new Size(257, 52);
            btnVegane.TabIndex = 3;
            btnVegane.Text = "Vegane Gerichte";
            btnVegane.TextAlign = ContentAlignment.MiddleLeft;
            btnVegane.UseVisualStyleBackColor = true;
            btnVegane.UseWaitCursor = true;
            btnVegane.Click += btnVegane_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(93, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 36);
            label1.TabIndex = 2;
            label1.Text = "Ray";
            label1.UseWaitCursor = true;
            // 
            // rayFoodie_Name
            // 
            rayFoodie_Name.AutoSize = true;
            rayFoodie_Name.Font = new Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rayFoodie_Name.ForeColor = SystemColors.Control;
            rayFoodie_Name.Location = new Point(93, 48);
            rayFoodie_Name.Name = "rayFoodie_Name";
            rayFoodie_Name.Size = new Size(102, 36);
            rayFoodie_Name.TabIndex = 2;
            rayFoodie_Name.Text = "Foodie";
            rayFoodie_Name.UseWaitCursor = true;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(75, 75);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            picLogo.UseWaitCursor = true;
            picLogo.Click += picLogo_Click;
            // 
            // panelCarrito
            // 
            panelCarrito.BackColor = Color.White;
            panelCarrito.Controls.Add(btnFacturar);
            panelCarrito.Controls.Add(lblTotal);
            panelCarrito.Controls.Add(dgvPedido);
            panelCarrito.Dock = DockStyle.Right;
            panelCarrito.Location = new Point(919, 0);
            panelCarrito.Name = "panelCarrito";
            panelCarrito.Size = new Size(695, 806);
            panelCarrito.TabIndex = 1;
            panelCarrito.UseWaitCursor = true;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.CornflowerBlue;
            btnFacturar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturar.ForeColor = SystemColors.ControlLightLight;
            btnFacturar.Location = new Point(398, 736);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(285, 63);
            btnFacturar.TabIndex = 1;
            btnFacturar.Text = "Rechnung Erstellen";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.UseWaitCursor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(255, 128, 0);
            lblTotal.Location = new Point(12, 741);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(268, 54);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total: 0,00 €";
            lblTotal.UseWaitCursor = true;
            // 
            // dgvPedido
            // 
            dgvPedido.AllowUserToAddRows = false;
            dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecio, colSubtotal });
            dgvPedido.Dock = DockStyle.Top;
            dgvPedido.Location = new Point(0, 0);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersWidth = 62;
            dgvPedido.ScrollBars = ScrollBars.Vertical;
            dgvPedido.Size = new Size(695, 661);
            dgvPedido.TabIndex = 0;
            dgvPedido.UseWaitCursor = true;
            dgvPedido.CellDoubleClick += dgvPedido_CellDoubleClick;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Produkt";
            colProducto.MinimumWidth = 8;
            colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Menge";
            colCantidad.MinimumWidth = 8;
            colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Preis (€)";
            colPrecio.MinimumWidth = 8;
            colPrecio.Name = "colPrecio";
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Gesamt (€)";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            // 
            // flpContenedorComida
            // 
            flpContenedorComida.AutoScroll = true;
            flpContenedorComida.BackColor = Color.Gainsboro;
            flpContenedorComida.Dock = DockStyle.Fill;
            flpContenedorComida.Location = new Point(257, 0);
            flpContenedorComida.Name = "flpContenedorComida";
            flpContenedorComida.Size = new Size(662, 806);
            flpContenedorComida.TabIndex = 2;
            flpContenedorComida.UseWaitCursor = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1614, 806);
            Controls.Add(flpContenedorComida);
            Controls.Add(panelCarrito);
            Controls.Add(panelMenuLateral);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ray Foodie - Gestion de Restaurante";
            UseWaitCursor = true;
            panelMenuLateral.ResumeLayout(false);
            panelMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelCarrito.ResumeLayout(false);
            panelCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Label rayFoodie_Name;
        private PictureBox picLogo;
        private Button btnVegane;
        private Button button1;
        private Button btnKalte;
        private Button btnHeisse;
        private Button btnDesserts;
        private Panel panelCarrito;
        private DataGridView dgvPedido;
        private FlowLayoutPanel flpContenedorComida;
        private Button btnFacturar;
        private Label lblTotal;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private Label label1;
    }
}
