using Ejercicio_2.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        private NumAsientos avion;

        public Form1()
        {
            InitializeComponent();
            avion = new NumAsientos();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int section = rdoSmoking.Checked ? 1 : 2;
            int seleccionarNum = avion.AsignarAsiento(section);

            if (seleccionarNum == -1)
            {
                string OtraSeccion = (section == 1) ? "No Fumar" : "Fumar";
                if (MessageBox.Show($"La sección está llena. ¿Te gustaría ser asignado a la sección de {OtraSeccion}?",
                    "Sección llena", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    section = (section == 1) ? 2 : 1;
                    seleccionarNum = avion.AsignarAsiento(section);
                }
            }

            if (seleccionarNum != -1)
            {
                string NombreSeccion = (section == 1) ? "Fumar" : "No Fumar";
                lblBoardingPass.Text = $"Asiento asignado: {seleccionarNum}\nSección: {NombreSeccion}";
            }
            else
            {
                lblBoardingPass.Text = "El próximo vuelo sale en 3 horas.";
            }
        }
    }
}