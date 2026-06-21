using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.ComponentModel; // <-- Esto es necesario para ocultar las advertencias -  Das ist notwendig, um die Warnungen zu verbergen
using System.Windows.Forms;

namespace Ray_Foodie
{
    public partial class TarjetaPlatillo : UserControl
    {
        private double precio;
        // Evento personalizado que se disparará al seleccionar el producto
        // Benutzerdefiniertes Ereignis, das ausgelöst wird, wenn das Produkt ausgewählt wird
        public event EventHandler AlSeleccionarProducto;

        public TarjetaPlatillo()
        {
            InitializeComponent();
        }

        // Oculta la propiedad del diseñador de propiedades
        // Blendet die Eigenschaft des Eigenschaftendesigners aus
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                lblPrecio.Text = value.ToString("0.00") + " €";
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Imagen
        {
            get { return picImagen.Image; }
            set { picImagen.Image = value; }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            // Si alguien está escuchando este evento (Form1), lo ejecutamos
            // Wenn jemand dieses Ereignis (Form1) hört, führen wir es aus
            AlSeleccionarProducto?.Invoke(this, EventArgs.Empty);
        }
    }
}
