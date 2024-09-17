using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.models
{
    internal class SalarioVend
    {
        private const int PagoFijo = 200;
        private const double Comision = 0.09;

        public int CalcularSalario(int ventasBrutas)
        {
            return (int)(PagoFijo + (ventasBrutas * Comision));
        }
    }
}