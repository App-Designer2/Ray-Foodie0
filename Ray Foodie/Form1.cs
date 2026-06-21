using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ray_Foodie
{
    public partial class Form1 : Form
    {
        // Lista global que guardará todos los productos del restaurante
        // Globale Liste, die alle Produkte des Restaurants speichert
        private List<Producto> menuProductos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();

            // Llenamos la lista al iniciar el programa
            // Wir füllen die Liste beim Start des Programms
            CargarMenuEjemplo();


            // CONEXIÓN MANUAL DEL EVENTO DE IMPRESIÓN:
            // MANUELLE VERBINDUNG DES DRUCKEREIGNISSES:
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

            // Arrancar el programa con la categoría "Vegan" seleccionada visualmente:
            // Das Programm starten, während die Kategorie „Vegan“ visuell ausgewählt ist
            btnVegane_Click(btnVegane, EventArgs.Empty);
        }

        private void CargarMenuEjemplo()
        {
            // Usamos la barra inclinada normal '/' que funciona perfectamente en .NET moderno
            // Wir verwenden den normalen Schrägstrich '/', der in modernem .NET perfekt funktioniert
            string rutaImages = Path.Combine(Application.StartupPath, "..", "..", "..", "Image") + "/";

            // CATEGORÍA: Warme Speisen (Platos Calientes)
            menuProductos.Add(new Producto("Hamburguesa Clásica", 12.50, "Carne de res de 150g, queso cheddar, lechuga y tomate.", "Warme", Image.FromFile(rutaImages + "hamburguesa.png")));
            menuProductos.Add(new Producto("Pasta Alfredo", 14.20, "Salsa cremosa Alfredo con pollo a la parrilla y parmesano.", "Warme", Image.FromFile(rutaImages + "pasta_alfredo.png")));
            menuProductos.Add(new Producto("Pizza Pepperoni", 11.90, "Masa artesanal, salsa de tomate, mozzarella y abundante pepperoni.", "Warme", Image.FromFile(rutaImages + "pizza_pepperoni.png")));

            // CATEGORÍA: Vegane Gerichte (Platos Veganos)
            menuProductos.Add(new Producto("Ensalada César Vegana", 9.50, "Lechuga romana, crutones, queso vegano y aderezo casero.", "Vegan", Image.FromFile(rutaImages + "ensalada_vegana.png")));
            menuProductos.Add(new Producto("Burger de Lentejas", 13.00, "Medallón de lentejas, aguacate, cebolla caramelizada.", "Vegan", Image.FromFile(rutaImages + "burger_lentejas.png")));

            // CATEGORÍA: Kalte Getränke (Bebidas Frías)
            menuProductos.Add(new Producto("Limonada Natural", 3.50, "Exprimida al momento con un toque de menta fresca.", "Kalte", Image.FromFile(rutaImages + "limonada.png")));
            menuProductos.Add(new Producto("Coca-Cola", 2.80, "Botella de vidrio de 330ml bien fría.", "Kalte", Image.FromFile(rutaImages + "cocacola.png")));

            // CATEGORÍA: Heiße Getränke (Bebidas Calientes)
            menuProductos.Add(new Producto("Café Cappuccino", 3.80, "Espresso con leche vaporizada y espuma perfecta.", "Heisse", Image.FromFile(rutaImages + "cappuccino.png")));

            // CATEGORÍA: Kuchen & Desserts (Postres)
            menuProductos.Add(new Producto("Tarta de Queso", 4.50, "Estilo New York con coulis de frutos rojos.", "Desserts", Image.FromFile(rutaImages + "tarta_queso.png")));
        }



        private void MostrarProductosPorCategoria(string categoria)
        {
            // Limpiamos por completo el panel central para quitar los platos anteriores:
            // Wir reinigen das zentrale Bedienfeld vollständig, um die vorherigen Teller zu entfernen:
            flpContenedorComida.Controls.Clear();

            // Recorremos toda nuestra lista de menú buscando los de la categoría elegida
            // Wir durchstöbern unsere gesamte Speisekarte auf der Suche nach den Gerichten der gewählten Kategorie
            foreach (var prod in menuProductos)
            {
                if (prod.Categoria == categoria)
                {
                    // Instanciamos visualmente la tarjeta de los Platillos:
                    // Wir instanziieren visuell die Karte der Gerichte:
                    TarjetaPlatillo tarjeta = new TarjetaPlatillo();

                    // Le pasamos los datos del producto a las propiedades de la tarjeta:
                    // Wir übertragen die Produktdaten auf die Eigenschaften der Karte:
                    tarjeta.Titulo = prod.Nombre;
                    tarjeta.Descripcion = prod.Descripcion;
                    tarjeta.Precio = prod.Precio;
                    tarjeta.Imagen = prod.Imagen;


                    // Asociamos el Evento Click de la Tarjeta
                    // Wir verbinden das Klick-Ereignis der Karte
                    tarjeta.AlSeleccionarProducto += Tarjeta_AlSeleccionarProducto;

                    // Agregamos la tarjeta al contenedor fluyente del centro
                    // Wir haben die Karte zum fließenden Container in der Mitte hinzugefügt
                    flpContenedorComida.Controls.Add(tarjeta);
                }
            }
        }

        private void Tarjeta_AlSeleccionarProducto(object sender, EventArgs e)
        {
            TarjetaPlatillo tarjetaClickeada = (TarjetaPlatillo)sender;

            string nombreProd = tarjetaClickeada.Titulo;
            double precioProd = tarjetaClickeada.Precio;
            bool existe = false;

            // Buscar si el producto ya está en el DataGridView
            // Überprüfen, ob das Produkt bereits im DataGridView ist
            foreach (DataGridViewRow fila in dgvPedido.Rows)
            {
                if (fila.Cells["colProducto"].Value?.ToString() == nombreProd)
                {
                    // Si ya existe, aumentamos la cantidad en 1
                    // Wenn es schon existiert, erhöhen wir die Menge um 1
                    int cantActual = Convert.ToInt32(fila.Cells["colCantidad"].Value);
                    cantActual++;
                    fila.Cells["colCantidad"].Value = cantActual;

                    // Recalculamos el subtotal de esa fila
                    // Wir berechnen den Zwischensumme dieser Zeile neu
                    fila.Cells["colSubtotal"].Value = (cantActual * precioProd).ToString("0.00");
                    existe = true;
                    break;
                }
            }

            // Si es un producto nuevo, añadimos una fila nueva
            // Wenn es ein neues Produkt ist, fügen wir eine neue Zeile hinzu
            if (!existe)
            {
                dgvPedido.Rows.Add(nombreProd, 1, precioProd.ToString("0.00"), precioProd.ToString("0.00"));
            }

            // Calculamos el total general inmediatamente
            // Wir berechnen sofort die Gesamtsumme
            ActualizarTotalPedido();
        }

        private void ActualizarTotalPedido()
        {
            double total = 0;

            // Sumamos los subtotales de todas las filas
            // Wir addieren die Zwischensummen aller Zeilen
            foreach (DataGridViewRow fila in dgvPedido.Rows)
            {
                if (fila.Cells["colSubtotal"].Value != null)
                {
                    total += Convert.ToDouble(fila.Cells["colSubtotal"].Value);
                }
            }

            // Actualizamos el Label de la pantalla en tiempo real
            // Wir aktualisieren das Label auf dem Bildschirm in Echtzeit
            lblTotal.Text = $"Total: {total:0.00} €";
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic sea en una fila válida
            // Überprüfen, ob der Klick auf einer gültigen Zeile war
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPedido.Rows[e.RowIndex];
                int cantidad = Convert.ToInt32(fila.Cells["colCantidad"].Value);
                double precio = Convert.ToDouble(fila.Cells["colPrecio"].Value);

                if (cantidad > 1)
                {
                    // Restar uno a la cantidad
                    // Eins von der Menge abziehen
                    cantidad--;
                    fila.Cells["colCantidad"].Value = cantidad;
                    fila.Cells["colSubtotal"].Value = (cantidad * precio).ToString("0.00");
                }
                else
                {
                    // Si la cantidad llega a 0, removemos el producto por completo
                    // Wenn die Menge 0 erreicht, entfernen wir das Produkt komplett
                    dgvPedido.Rows.RemoveAt(e.RowIndex);
                }

                // Recalcular el total general
                // Gesamtsumme neu berechnen
                ActualizarTotalPedido();
            }
        }

        private void btnVegane_Click(object sender, EventArgs e)
        {
            ResaltarBotonActivo((Button)sender);
            MostrarProductosPorCategoria("Vegan");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResaltarBotonActivo((Button)sender);
            MostrarProductosPorCategoria("Warme");
        }

        private void btnKalte_Click(object sender, EventArgs e)
        {
            ResaltarBotonActivo((Button)sender);
            MostrarProductosPorCategoria("Kalte");
        }

        private void btnHeisse_Click(object sender, EventArgs e)
        {
            ResaltarBotonActivo((Button)sender);
            MostrarProductosPorCategoria("Heisse");
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            ResaltarBotonActivo((Button)sender);
            MostrarProductosPorCategoria("Desserts");
        }

        // ResaltarBotonActivo
        // AktivenButtonHervorheben
        private void ResaltarBotonActivo(Button botonPresionado)
        {
            // Colores acentos del diseño
            // Akzentfarben des Designs
            Color colorNaranjaOriginal = Color.FromArgb(255, 128, 0); // El color naranja - Die Farbe Orange
            Color colorGrisActivo = Color.FromArgb(64, 64, 64);      // El gris oscuro de la barra/selección - Das dunkle Grau der Leiste/Auswahl
            Color colorTexto = Color.White;

            // Buscamos todos los controles dentro del panel lateral.
            // Wir suchen alle Steuerelemente im Seitenbereich.
            foreach (Control c in panelMenuLateral.Controls)
            {
                // Si el control es un botón y no es el logotipo (PictureBox)
                // Wenn die Steuerung ein Knopf ist und nicht das Logo (PictureBox)
                if (c is Button btn)
                {
                    if (btn == botonPresionado)
                    {
                        // Pintamos de gris el botón seleccionado
                        // Wir streichen den ausgewählten Knopf grau
                        btn.BackColor = colorGrisActivo;
                    }
                    else
                    {
                        // Regresamos los demás botones a naranja
                        // Wir stellen die anderen Knöpfe wieder auf Orange zurück
                        btn.BackColor = colorNaranjaOriginal;
                    }

                    btn.ForeColor = colorTexto;
                }
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            // Validar si hay productos en el carrito antes de imprimir
            // Überprüfen, ob Produkte im Warenkorb sind, bevor gedruckt wird
            if (dgvPedido.Rows.Count == 0)
            {
                MessageBox.Show("Bitte fügen Sie Produkte zur Bestellung hinzu, bevor Sie eine Rechnung erstellen.",
                                "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asegurar la asignación en tiempo de ejecución directa
            // Die Zuweisung zur Laufzeit direkt sichern
            printPreviewDialog1.Document = null; // Reiniciamos el contenedor por seguridad - Wir haben den Container vorsichtshalber neu gestartet
            printPreviewDialog1.Document = printDocument1; // Reasignamos el documento enlazado - Wir haben das verlinkte Dokument neu zugewiesen

            // Mostrar la vista previa en pantalla completa
            // Vorschau im Vollbildmodus anzeigen
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Configuración de fuentes y pincel
            // Schriftarten- und Pinsel-Einstellungen
            Font fontTitulo = new Font("Courier New", 14, FontStyle.Bold);
            Font fontTexto = new Font("Courier New", 10, FontStyle.Regular);
            Font fontNegrita = new Font("Courier New", 10, FontStyle.Bold);
            Font fontMini = new Font("Courier New", 8, FontStyle.Regular);
            Brush brush = Brushes.Black;

            float x = 20; // Margen izquierdo para tickets de 80mm - Linker Rand für 80-mm-Tickets
            float y = 20; // Margen superior - Oberer Rand
            float anchoLinea = 260; // Línea divisoria - Trennlinie

            // Encabezado de la factura
            // Rechnungsüberschrift
            e.Graphics.DrawString("      RAY FOODIE      ", fontTitulo, brush, x, y); y += 25;
            e.Graphics.DrawString(" Sabor que te hace volver ", fontMini, brush, x + 25, y); y += 20;
            e.Graphics.DrawString(new string('-', 35), fontTexto, brush, x, y); y += 15;

            // Información del Ticket
            // Ticketinformationen
            Random rnd = new Random();
            int rechnungNummer = rnd.Next(1000, 9999);
            e.Graphics.DrawString($"Rechnungsnr: #{rechnungNummer}", fontTexto, brush, x, y); y += 15;
            e.Graphics.DrawString($"Datum/Zeit : {DateTime.Now:dd.MM.yyyy HH:mm}", fontTexto, brush, x, y); y += 20;
            e.Graphics.DrawString(new string('-', 35), fontTexto, brush, x, y); y += 15;

            // Encabezados de la Tabla de productos
            // Produkt-Tabelle Überschriften
            e.Graphics.DrawString("Produkt         Mng.   Preis   Total", fontNegrita, brush, x, y); y += 15;
            e.Graphics.DrawString(new string('-', 35), fontTexto, brush, x, y); y += 15;

            // Variables de cálculo de totales
            // Variablen zur Berechnung von Gesamtsummen
            double totalGeneral = 0; // Cambiado de subtotalGeneral a totalGeneral porque representa el pago final real

            // Recorrer los productos del DataGridView para listarlos
            // Die Produkte im DataGridView durchgehen, um sie aufzulisten
            foreach (DataGridViewRow fila in dgvPedido.Rows)
            {
                if (fila.Cells["colProducto"].Value != null)
                {
                    string producto = fila.Cells["colProducto"].Value.ToString();
                    string cantidad = fila.Cells["colCantidad"].Value.ToString();
                    double precioUnidad = Convert.ToDouble(fila.Cells["colPrecio"].Value);
                    double totalFila = Convert.ToDouble(fila.Cells["colSubtotal"].Value);

                    totalGeneral += totalFila;

                    // Recortar nombre si es muy largo para que no rompa el diseño del ticket
                    // Name kürzen, wenn er zu lang ist, damit das Ticket-Design nicht kaputtgeht
                    if (producto.Length > 14) producto = producto.Substring(0, 12) + "..";


                    // Dibujar la fila formateada en columnas simuladas por espacios fijos
                    // Die formatierte Zeile in Spalten zeichnen, die durch feste Leerzeichen simuliert werden
                    e.Graphics.DrawString(producto.PadRight(15), fontTexto, brush, x, y);
                    e.Graphics.DrawString(cantidad.PadLeft(3), fontTexto, brush, x + 120, y);
                    e.Graphics.DrawString(precioUnidad.ToString("0.00").PadLeft(8), fontTexto, brush, x + 150, y);
                    e.Graphics.DrawString(totalFila.ToString("0.00").PadLeft(8), fontTexto, brush, x + 210, y);
                    y += 15;
                }
            }


            // El precio neto es el total dividido entre 1.19
            // Der Nettopreis ist der Gesamtbetrag geteilt durch 1,19
            double nettoGesamt = totalGeneral / 1.19;

            // El IVA es la resta matemática pura del Total menos el Neto
            // Die Mehrwertsteuer ist einfach die mathematische Differenz zwischen dem Gesamtbetrag und dem Nettobetrag
            double mwst = totalGeneral - nettoGesamt;

            e.Graphics.DrawString(new string('-', 35), fontTexto, brush, x, y); y += 15;

            // Mostramos el Neto y el IVA desglosado
            e.Graphics.DrawString($"Netto Gesamt:".PadRight(22) + $"{nettoGesamt:0.00} €", fontTexto, brush, x, y); y += 15;
            e.Graphics.DrawString($"Inkl. 19% MwSt:".PadRight(22) + $"{mwst:0.00} €", fontTexto, brush, x, y); y += 20;

            // Total a Pagar en grande y negrita (Sigue siendo exactamente la suma de los productos)
            // Gesamt zu zahlen in groß und fett
            e.Graphics.DrawString($"GESAMTSUMME:".PadRight(18) + $"{totalGeneral:0.00} €", fontTitulo, brush, x, y); y += 30;

            // Mensaje de Despedida
            // Abschiedsnachricht
            e.Graphics.DrawString(new string('-', 35), fontTexto, brush, x, y); y += 15;
            e.Graphics.DrawString("Vielen Dank für Ihren Besuch!", fontNegrita, brush, x + 15, y); y += 15;
            e.Graphics.DrawString("   Auf Wiedersehen bei Ray Foodie!   ", fontMini, brush, x, y);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            // Hacer la imagen del Logo circular:
            // Das Bild des runden Logos machen:
            GraphicsPath path = new GraphicsPath(); 
            path.AddEllipse(0, 0, picLogo.Width, picLogo.Height); 
            picLogo.Region = new Region(path);
        }
    }
}
