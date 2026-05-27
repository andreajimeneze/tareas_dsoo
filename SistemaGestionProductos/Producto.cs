using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionProductos
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Tipo { get; set; }

        public Producto(string nombre, double precio, string tipo)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Tipo = tipo;
        }

        public string MostrarDatos()
        {
            return "Producto: " + Nombre + ", Precio: " + Precio + ", Tipo: " + Tipo;
        }

        public virtual double CalcularPrecioTotal(int cantidad)
        {
            return Precio * cantidad;
        }
    }
}
