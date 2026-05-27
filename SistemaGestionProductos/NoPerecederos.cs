using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionProductos
{
    internal class NoPerecederos : Producto
    {
        public string Categoria { get; set; }
    

    public NoPerecederos(string nombre, double precio, string tipo, string categoria ) : base(nombre, precio, tipo)
        {
            this.Categoria = categoria;
        }

        public double CalcularPrecioTotal(int cantidad)
        {
            return Precio* cantidad;
        }

    }
}
