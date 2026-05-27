using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionProductos
{
    internal class Perecederos : Producto
    {
        public int DiasACaducar { get; set; }
        public Perecederos(string nombre, double precio, string tipo) : base(nombre, precio, tipo)
        {
        }

        //Si le queda 1 día para caducar, se reducirá 4 veces el precio final. 
        //Si le quedan 2 días para caducar, se reducirá 3 veces el precio final.
        //Si le quedan 3 días para caducar, se reducirá a la mitad de su precio final.
        public override double CalcularPrecioTotal(int cantidad)
        {
            double precioTotal = 0;

            if(DiasACaducar > 1)
            {
                precioTotal = (Precio * cantidad) / 4;
            } else if(DiasACaducar == 2)
            {
                precioTotal = (Precio * cantidad) / 3;
            } else if(DiasACaducar == 3)
            {
                precioTotal = (Precio * cantidad) / 2;
            } else
            {
                precioTotal = Precio * cantidad;
            }
            return precioTotal;
        }
    }
}
