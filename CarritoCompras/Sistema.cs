using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompras
{
    internal class Sistema
    {
        public int UltimoProducto { get; set; }
        private CarritoCompras Carrito { get; set; }
        public List<Producto> Productos { get; set; }

        public Sistema(Cliente cliente) {
       
            Productos = new List<Producto>();
        }


    }
    
}
