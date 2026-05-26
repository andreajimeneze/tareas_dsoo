using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompras
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }

        public Cliente(string dni)
        {
            this.Dni = dni;
        }
    }
}
