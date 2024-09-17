using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.models
{
    public class TirarDados
    {
        private int[] conteoSumas = new int[11]; // Array para contar las sumas (de 2 a 12)

        // Método para simular una tirada de dos dados
        public (int dado1, int dado2, int suma) Tirar()
        {
            Random rand = new Random();
            int dado1 = rand.Next(1, 7); // Lanza el primer dado (1 a 6)
            int dado2 = rand.Next(1, 7); // Lanza el segundo dado (1 a 6)
            int suma = dado1 + dado2;    // Calcula la suma

            conteoSumas[suma - 2]++; // Incrementa el conteo para la suma correspondiente
            return (dado1, dado2, suma); // Devuelve los valores de los dados y la suma
        }

        public int[] ObtenerConteoSumas()
        {
            return conteoSumas;
        }
    }
}