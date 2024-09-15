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
        private TirarDados resultDados;
        public Form1()
        {
            InitializeComponent();
            resultDados = new TirarDados();
        }

        private void btnTirarDados_Click(object sender, EventArgs e)
        {
            resultDados.Lanzar();
            lblDado1.Text = "Dado 1: " + resultDados.ResultDado1().ToString();
            lblDado2.Text = "Dado 2: " + resultDados.ResultDado2().ToString();
            lblResult.Text = "Suma: " + resultDados.SumaDados().ToString();
        }
    }
}
