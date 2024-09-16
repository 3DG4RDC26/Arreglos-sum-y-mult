using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.clases
{
    public class Pasajero
    {
        public string Nombre { get; set; }
        public int SeleccionarNum { get; set; }
        public string Seccion { get; set; }

        public Pasajero(string nombre, int seleccionarNum, string seccion)
        {
            Nombre = nombre;
            SeleccionarNum = seleccionarNum;
            Seccion = seccion;
        }
    }
}