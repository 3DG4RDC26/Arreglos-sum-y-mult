using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        private int[] rangosSalarios = new int[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularSalario(int ventasBrutas)
        {
            int salario = (int)(200 + 0.09 * ventasBrutas);

            if (salario >= 1000)
            {
                rangosSalarios[8]++;
            }
            else if (salario >= 900)
            {
                rangosSalarios[7]++;
            }
            else if (salario >= 800)
            {
                rangosSalarios[6]++;
            }
            else if (salario >= 700)
            {
                rangosSalarios[5]++;
            }
            else if (salario >= 600)
            {
                rangosSalarios[4]++;
            }
            else if (salario >= 500)
            {
                rangosSalarios[3]++;
            }
            else if (salario >= 400)
            {
                rangosSalarios[2]++;
            }
            else if (salario >= 300)
            {
                rangosSalarios[1]++;
            }
            else
            {
                rangosSalarios[0]++;
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            int ventasBrutas;
            if (int.TryParse(txtVentas.Text, out ventasBrutas))
            {
                CalcularSalario(ventasBrutas);
                MessageBox.Show("Venta registrada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }

            txtVentas.Clear();
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            lstReporte.Items.Clear();
            lstReporte.Items.Add("Rangos de salarios:");
            lstReporte.Items.Add($"$200-$299:   {rangosSalarios[0]} vendedores");
            lstReporte.Items.Add($"$300-$399:   {rangosSalarios[1]} vendedores");
            lstReporte.Items.Add($"$400-$499:   {rangosSalarios[2]} vendedores");
            lstReporte.Items.Add($"$500-$599:   {rangosSalarios[3]} vendedores");
            lstReporte.Items.Add($"$600-$699:   {rangosSalarios[4]} vendedores");
            lstReporte.Items.Add($"$700-$799:   {rangosSalarios[5]} vendedores");
            lstReporte.Items.Add($"$800-$899:   {rangosSalarios[6]} vendedores");
            lstReporte.Items.Add($"$900-$999:   {rangosSalarios[7]} vendedores");
            lstReporte.Items.Add($"$1000 o más: {rangosSalarios[8]} vendedores");
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {

        }
    }
}