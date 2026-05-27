namespace SistemaGestionProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();

            // Productos no perecibles
            productos.Add(new Producto("Arroz", 1500, "No Perecible"));
            productos.Add(new Producto("Fideos", 1200, "No Perecible"));
            productos.Add(new Producto("Aceite", 3500, "No Perecible"));

            // Productos perecibles
            productos.Add(new Perecederos("Leche", 1000, "Perecible")
            {
                DiasACaducar = 1
            });

            productos.Add(new Perecederos("Yogurt", 800, "Perecible")
            {
                DiasACaducar = 2
            });

            productos.Add(new Perecederos("Queso", 2500, "Perecible")
            {
                DiasACaducar = 3
            });

            foreach (var item in productos)
            {
               Console.WriteLine( item.MostrarDatos());
            }


            // calcular el precio del arroz (5 unidades)
            Producto arroz = productos.Find(p => p.Nombre == "Arroz");
            double precioArroz = arroz.CalcularPrecioTotal(5);
            Console.WriteLine("El precio de 5 kilos de arroz es de: $" + precioArroz);

            // calcular el precio del yogurt (6 unidades)
            Producto yogurt = productos.Find(p => p.Nombre == "Yogurt");
            double precioYogurt = yogurt.CalcularPrecioTotal(6);
            Console.WriteLine("El precio de 6 yogures es de: $" + precioYogurt);

            // Refactor: crear método reutilizable
            static void MostrarPrecioProducto(List<Producto> productos, string nombre, int cantidad)
            {
                Producto producto = productos.Find(p => p.Nombre == nombre);
                if (producto != null)
                {
                    double total = producto.CalcularPrecioTotal(cantidad);
                    Console.WriteLine($"El precio de {cantidad} unidades del producto {nombre} es de: ${total}");
                } else
                {
                    Console.WriteLine("Producto inexistente, no puede calcular precio");
                }
            }
            // Mostrar productos existentes
            MostrarPrecioProducto(productos, "Fideos", 3);
            MostrarPrecioProducto(productos, "Leche", 6);
            // Intentar calcular producto inexistente
            MostrarPrecioProducto(productos, "Hamburguesas", 2);
        }
    }
}
