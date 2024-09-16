using Ejercicio_3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        // Lista para almacenar todas las ventas del mes
        private List<Venta> ventas = new List<Venta>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados
            int vendedor = int.Parse(txtVendedor.Text);
            int producto = int.Parse(txtProducto.Text);
            float valorVenta = float.Parse(txtVenta.Text);

            // Validar que los valores ingresados estén dentro del rango permitido
            if (vendedor >= 1 && vendedor <= 4 && producto >= 1 && producto <= 5)
            {
                // Crear una nueva venta y agregarla a la lista de ventas
                Venta nuevaVenta = new Venta(vendedor, producto, valorVenta);
                ventas.Add(nuevaVenta);

                MessageBox.Show("Venta agregada exitosamente.");
            }
            else
            {
                MessageBox.Show("Error: Vendedor o producto fuera de rango.");
            }

            // Limpiar campos de texto
            txtVendedor.Clear();
            txtProducto.Clear();
            txtVenta.Clear();
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            // Arreglo para resumir las ventas: [producto, vendedor]
            float[,] resumenVentas = new float[5, 4];

            // Sumar las ventas por vendedor y producto
            foreach (Venta venta in ventas)
            {
                resumenVentas[venta.Producto - 1, venta.Vendedor - 1] += venta.ValorVenta;
            }

            // Mostrar el reporte en el ListBox
            lstReporte.Items.Clear();
            lstReporte.Items.Add("Producto/Vendedor   1       2       3       4   | Total Producto");

            for (int producto = 0; producto < 5; producto++)
            {
                float totalProducto = 0;
                string linea = $"Producto {producto + 1}       ";

                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    linea += $"{resumenVentas[producto, vendedor],8:F2} ";
                    totalProducto += resumenVentas[producto, vendedor];
                }

                linea += $"| {totalProducto,8:F2}";
                lstReporte.Items.Add(linea);
            }

            // Totales por vendedor
            lstReporte.Items.Add("----------------------------------------------------------");
            string lineaTotales = "Total Vendedor     ";
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                float totalVendedor = 0;
                for (int producto = 0; producto < 5; producto++)
                {
                    totalVendedor += resumenVentas[producto, vendedor];
                }
                lineaTotales += $"{totalVendedor,8:F2} ";
            }
            lstReporte.Items.Add(lineaTotales);
        }
    }
}