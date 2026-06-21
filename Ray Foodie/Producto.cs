using System;
using System.Collections.Generic;
using System.Text;


namespace Ray_Foodie
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; } // "Vegan", "Warme", "Kalte", "Heisse", "Desserts"
        public Image Imagen { get; set; }

        // Constructor para crear platos fácilmente
        // Konstruktor zum einfachen Erstellen von Gerichten
        public Producto(string nombre, double precio, string descripcion, string categoria, Image imagen)
        {
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
            Categoria = categoria;
            Imagen = imagen;
        }
    }
}
