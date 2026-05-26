using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompras
{
    internal class DetalleCompra
    {
        public Producto Producto { get; set; }
        public int CantidadProducto { get; set; }

        public DetalleCompra(Producto producto, int cantidad)
            {
                this.Producto = producto;
                SetCantidadProducto(cantidad);
            }

        public void SetCantidadProducto(int cantidad)
        {
            if (cantidad > 0)
                CantidadProducto = cantidad;
        }
    }
}
