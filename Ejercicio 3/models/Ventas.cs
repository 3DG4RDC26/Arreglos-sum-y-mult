using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.models
{
    public class Venta
    {
        public int Vendedor { get; set; }
        public int Producto { get; set; } 
        public float ValorVenta { get; set; }

        public Venta(int vendedor, int producto, float valorVenta)
        {
            Vendedor = vendedor;
            Producto = producto;
            ValorVenta = valorVenta;
        }
    }
}