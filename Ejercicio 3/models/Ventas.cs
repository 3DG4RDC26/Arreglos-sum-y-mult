using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.models
{
    internal class Ventas
    {
        private double[,] ventas; // Arreglo para ventas, filas: productos, columnas: vendedores

        public Ventas(int numProductos, int numVendedores)
        {
            ventas = new double[numProductos, numVendedores];
        }

        public void RegistrarVenta(int producto, int vendedor, double monto)
        {
            if (producto >= 1 && producto <= ventas.GetLength(0) && vendedor >= 1 && vendedor <= ventas.GetLength(1))
            {
                ventas[producto - 1, vendedor - 1] += monto;
            }
        }

        public double[,] ObtenerVentas()
        {
            return ventas;
        }

        public double[] ObtenerTotalesPorProducto()
        {
            int numProductos = ventas.GetLength(0);
            int numVendedores = ventas.GetLength(1);
            double[] totalesPorProducto = new double[numProductos];

            for (int i = 0; i < numProductos; i++)
            {
                double total = 0;
                for (int j = 0; j < numVendedores; j++)
                {
                    total += ventas[i, j];
                }
                totalesPorProducto[i] = total;
            }

            return totalesPorProducto;
        }

        public double[] ObtenerTotalesPorVendedor()
        {
            int numProductos = ventas.GetLength(0);
            int numVendedores = ventas.GetLength(1);
            double[] totalesPorVendedor = new double[numVendedores];

            for (int j = 0; j < numVendedores; j++)
            {
                double total = 0;
                for (int i = 0; i < numProductos; i++)
                {
                    total += ventas[i, j];
                }
                totalesPorVendedor[j] = total;
            }

            return totalesPorVendedor;
        }
    }
}