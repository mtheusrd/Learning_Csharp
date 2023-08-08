using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_matematicos_avançados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Potenciação
            double potenciacao = Math.Pow(4, 2);
            Console.WriteLine(potenciacao);
            

            //Raciciação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1 / raiz);
            Console.WriteLine(radiciacao);

            // Máximo e minimo
            double maximo = Math.Max(4, 8);
            Console.WriteLine(maximo);

            double minimo = Math.Min(4, 8);
            Console.WriteLine(maximo);

            // Módulo
            double modulo = Math.Abs(-10);

            // Operações trigonométricas
            double angulo = 30 * (2 * Math.PI) / 360;
            // Seno = sin
            // Cosseno - cos
            // Tangente - tan
            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);


            Console.ReadKey();
        }
    }
}
