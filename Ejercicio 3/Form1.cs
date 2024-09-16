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
        private Ventas ventas;
        private const int numVendedores = 4;
        private const int numProductos = 5;

        public Form1()
        {
            InitializeComponent();
            ventas = new Ventas(numProductos, numVendedores);
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Aquí asumimos que txtProducto, txtVendedor y txtMonto son TextBox en el formulario
            if (int.TryParse(txtProducto.Text, out int producto) &&
                int.TryParse(txtVendedor.Text, out int vendedor) &&
                double.TryParse(txtMonto.Text, out double monto))
            {
                ventas.RegistrarVenta(producto, vendedor, monto);
                MessageBox.Show("Venta registrada correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos.");
            }
        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            double[,] ventasData = ventas.ObtenerVentas();
            double[] totalesPorProducto = ventas.ObtenerTotalesPorProducto();
            double[] totalesPorVendedor = ventas.ObtenerTotalesPorVendedor();

            // Limpiar el DataGridView antes de llenar con nuevos datos
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Columns.Clear();

            // Agregar columnas para los vendedores
            for (int i = 1; i <= numVendedores; i++)
            {
                dataGridViewResultados.Columns.Add($"Vendedor{i}", $"Vendedor {i}");
            }

            // Agregar columna para los totales por producto
            dataGridViewResultados.Columns.Add("TotalProducto", "Total Producto");

            // Agregar filas para cada producto
            for (int i = 0; i < numProductos; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewResultados);

                for (int j = 0; j < numVendedores; j++)
                {
                    row.Cells[j].Value = ventasData[i, j].ToString("F2");
                }

                row.Cells[numVendedores].Value = totalesPorProducto[i].ToString("F2");
                dataGridViewResultados.Rows.Add(row);
            }

            // Agregar fila para los totales por vendedor
            var totalRow = new DataGridViewRow();
            totalRow.CreateCells(dataGridViewResultados, "Total Vendedor");

            for (int i = 0; i < numVendedores; i++)
            {
                totalRow.Cells[i].Value = totalesPorVendedor[i].ToString("F2");
            }

            totalRow.Cells[numVendedores].Value = ""; // Espacio para total general
            dataGridViewResultados.Rows.Add(totalRow);

            // Agregar fila para el total general
            double totalGeneral = totalesPorProducto.Sum();
            var totalGeneralRow = new DataGridViewRow();
            totalGeneralRow.CreateCells(dataGridViewResultados, "Total General");

            for (int i = 0; i < numVendedores; i++)
            {
                totalGeneralRow.Cells[i].Value = "";
            }

            totalGeneralRow.Cells[numVendedores].Value = totalGeneral.ToString("F2");
            dataGridViewResultados.Rows.Add(totalGeneralRow);
        }
    }
}