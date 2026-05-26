using CarritoCompras;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompra
{
    internal class Carrito
    {
        public int Id { get; set; }
        public List<DetalleCompra> ListaCompra { get; set;}
        public Cliente Cliente { get; set; }

        public Carrito(Cliente cliente, int id)
        {
            this.Id = id;
            this.Cliente = cliente;
             ListaCompra = new List<DetalleCompra>();
        }

        public bool AgregarItem(DetalleCompra detalle)
        {
            if(detalle == null || detalle.CantidadProducto <= 0)
            {
                return false;
            }

            DetalleCompra productoExistente = ListaCompra.Find(det => det.Producto.Id == detalle.Producto.Id);
    
           
            if (productoExistente != null)
            {
                int cantidadFutura = productoExistente.CantidadProducto + detalle.CantidadProducto;
                bool hayStock = productoExistente.Producto.VerificarStock(cantidadFutura);              

                if(!hayStock)
                {
                    return false;
                }
                productoExistente.CantidadProducto += detalle.CantidadProducto;
                return true;

            } else
            {
                ListaCompra.Add(detalle);
            }
            return true;
        }


        public bool DescontarCantidadProducto(int idProducto, int cantidad)
        {
            DetalleCompra productoExistente = ListaCompra.Find(det => det.Producto.Id == idProducto);

            if (productoExistente == null || cantidad <= 0 || productoExistente.CantidadProducto < cantidad)
            {
                return false;
            }

            if(productoExistente.CantidadProducto == cantidad)
            {
                return ListaCompra.Remove(productoExistente);

            } else 
            {
                productoExistente.CantidadProducto -= cantidad;
            }
            
            return true;
        }

        //public double calcularTotal()
        //{
        //    double total = 0;

        //    for(int i = 0; i < ListaCompra.Count; i++)
        //    {
        //        total += ListaCompra[i].Producto.Precio * ListaCompra[i].CantidadProducto;
        //    }

        //    return total;
        //}

    // Refactorización usando foreach
        public double calcularTotal()
        {
            double total = 0;

            foreach (var item in ListaCompra)
            {
                total += item.Producto.Precio * item.CantidadProducto;
            }
            return total;
        }

        public override string ToString()
        {
            string resultado = "Lista productos en carrito:\n";
            double total = 0;

            foreach (var item in ListaCompra)
            {
                double subtotal = item.Producto.Precio * item.CantidadProducto;
                total += subtotal;

                resultado += $"- Producto: {item.Producto.Nombre}, Cantidad: {item.CantidadProducto}\n" +
                             $"  Precio unidad: {item.Producto.Precio}\n" +
                             $"  Subtotal: {subtotal}\n\n";
            }

            resultado += $"TOTAL: {total}";

            return resultado;
        }
    }
}
