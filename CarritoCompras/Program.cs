using CarritoCompra;
using System.ComponentModel;
using System.Globalization;

namespace CarritoCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese código del producto:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del producto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese precio del producto:");
            double precio = double.Parse( Console.ReadLine());
            Console.WriteLine("Ingrese cantidad del producto:");
            int cantidad = int.Parse(Console.ReadLine());
            Producto producto1 = new Producto(id, nombre, precio, cantidad);
            Producto producto2 = new Producto(2, "Azúcar", 1200.00, 20);
            Producto producto3 = new Producto(3, "Fideos", 990.00, 40);
            Producto producto4 = new Producto(4, "Leche", 1140.00, 15);

            Cliente cliente1 = new Cliente("24753731");
        
            Sistema sistema = new Sistema(cliente1);

            sistema.AgregarProductoAlCatálogo(producto1);
            sistema.AgregarProductoAlCatálogo(producto2);
            sistema.AgregarProductoAlCatálogo(producto3);
            sistema.AgregarProductoAlCatálogo(producto4);

            sistema.listarProductos();
            Carrito carrito = new Carrito(cliente1, 1);

            DetalleCompra detalle1 = new DetalleCompra(producto3, 2);
            DetalleCompra detalle2 = new DetalleCompra(producto1, 3);
            DetalleCompra detalle3 = new DetalleCompra(producto4, 1);
            DetalleCompra detalle4 = new DetalleCompra(producto4, 3);

            carrito.AgregarItem(detalle1);
            carrito.AgregarItem(detalle2);
            carrito.AgregarItem(detalle3);

            carrito.AgregarItem(detalle4);
            carrito.DescontarCantidadProducto(1, 3);

            Console.WriteLine(carrito.ToString());
            Console.ReadLine();
        }
    }
}
