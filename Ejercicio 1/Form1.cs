using Ejercicio_1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        private TirarDados tirarDados;

        public Form1()
        {
            InitializeComponent();
            tirarDados = new TirarDados(); // Inicializa la clase TirarDados
        }

        // Este método se ejecuta cuando el usuario hace clic en el botón "Lanzar Dados"
        private void btnLanzarDados_Click(object sender, EventArgs e)
        {
            // Realiza una tirada
            var (dado1, dado2, suma) = tirarDados.Tirar();

            // Actualiza las etiquetas con los resultados
            lblDado1.Text = $"Dado 1: {dado1}";
            lblDado2.Text = $"Dado 2: {dado2}";
            lblSuma.Text = $"Suma: {suma}";

            // Mostrar el conteo acumulado de sumas
            MostrarConteoSumas();
        }

        // Método para mostrar el conteo acumulado de las sumas
        private void MostrarConteoSumas()
        {
            int[] conteoSumas = tirarDados.ObtenerConteoSumas();

            // Limpiar el ListBox antes de mostrar los conteos actualizados
            lstConteoSumas.Items.Clear();
            lstConteoSumas.Items.Add("Suma\tCantidad");

            for (int i = 0; i < conteoSumas.Length; i++)
            {
                int suma = i + 2;
                int cantidad = conteoSumas[i];
                lstConteoSumas.Items.Add($"{suma}\t{cantidad}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}