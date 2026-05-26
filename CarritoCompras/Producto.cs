using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompras
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }


        public Producto(int id, string nombre, double precio, int stock)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }

        public bool VerificarStock(int cantidad)
        {
            if (Stock >= cantidad)
            {
                return true;
            }
            return false;
        }
    }
}
