using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.clases
{
    public class NumAsientos
    {
        private bool[] Asientos = new bool[10];

        public int AsignarAsiento(int seccion)
        {
            int iniciar = (seccion == 1) ? 0 : 5;
            int fin = (seccion == 1) ? 4 : 9;

            for (int i = iniciar; i <= fin; i++)
            {
                if (!Asientos[i])
                {
                    Asientos[i] = true;
                    return i + 1;
                }
            }
            return -1;
        }

        public bool IsFull(int seccion)
        {
            int iniciar = (seccion == 1) ? 0 : 5;
            int fin = (seccion == 1) ? 4 : 9;

            for (int i = iniciar; i <= fin; i++)
            {
                if (!Asientos[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}