using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2022, 09, 26);
            DateTime dataHora = new DateTime(2020, 09, 26, 14, 12, 45);

            // Podemos acessar ano, mes, dia e hora, minuto, segundo individualmente.

            Console.WriteLine("Ano: " + dataHora.Year);
            Console.WriteLine("Mês: " + dataHora.Month);
            Console.WriteLine("Dia: " + dataHora.Day);
            Console.WriteLine("Hora: " + dataHora.Hour);
            Console.WriteLine("Minutos: " + dataHora.Minute);
            Console.WriteLine("Segundos: " + dataHora.Second);
            Console.WriteLine("Dia da semana:" + dataHora.DayOfWeek);
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadKey();
            Console.WriteLine("---------------------");
            Console.WriteLine(data.ToString());
            Console.WriteLine(dataHora.ToString());

            //Pegando data e hora atual.
            DateTime dataHoraAtual = DateTime.Now;
            Console.WriteLine(dataHoraAtual.ToString());

            //Convertendo uma string em DateTIme

            DateTime dataConvertida = Convert.ToDateTime("22/11/2030");
            DateTime dataHoraConvertida = Convert.ToDateTime("22/11/2030 14:10:23");
            Console.WriteLine(dataConvertida.ToString());
            Console.WriteLine(dataHoraConvertida.ToString());

            // Formatando a data e hora impressa

            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM/"));


        }
    }
}
