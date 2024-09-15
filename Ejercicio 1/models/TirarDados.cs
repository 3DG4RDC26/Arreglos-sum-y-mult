using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.models
{
    internal class TirarDados
    {
        private int[,] resultDados;
        public TirarDados()
        {
            resultDados = new int[2, 1];
        }
        public void Lanzar()
        {
            Random rand = new Random();
            resultDados[0, 0] = rand.Next(1, 7);
            resultDados[1, 0] = rand.Next(1, 7);
        }
        public int ResultDado1()
        {
            return resultDados[0, 0];
        }
        public int ResultDado2()
        {
            return resultDados[1, 0];
        }
        public int SumaDados()
        {
            return resultDados[0, 0] + resultDados[1, 0];
        }
    }
}
