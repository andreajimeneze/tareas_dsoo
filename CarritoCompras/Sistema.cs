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

        public void AgregarProductoAlCatálogo(Producto producto)
        {
            Productos.Add(producto);
        }

        public Producto BuscarProductoPorId(int id)
        {
            return Productos.Find(p => p.Id == id);
        }

        public void listarProductos()
        {
            foreach (var item in Productos)
            {
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Nombre: {item.Nombre}");
                Console.WriteLine($"Precio: {item.Precio}");
                Console.WriteLine($"Stock: {item.Stock}");
               )
            }
        }


    }
    
}
