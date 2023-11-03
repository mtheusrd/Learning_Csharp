using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Como_tratar_uma_excecao
{
    internal class Joao
    {
        public void ImprimeNome()
        {
            Console.WriteLine("Joao");
        }
    }
    internal class Program
    {
        static Joao joao;

        static void Main(string[] args)
        {
            try // obrigatorio
            {
                Console.WriteLine("Digite o Numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                int resultado = numerador / denominador;

                Console.WriteLine("O Resultado é: " + resultado);
                joao.ImprimeNome();


            }
            catch (DivideByZeroException e) // obrigatorio. pode existir varios.
            {
                Console.WriteLine("EXCEÇÃO DE DIVISÃO POR ZERO: " + e.Message);
            }
            catch (NullReferenceException e) // obrigatorio. pode existir varios.
            {
                Console.WriteLine("EXCEÇÃO DE OBJETO NULO: " + e.Message);
            }
            finally // opcional, sempre executado.
            {
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }

        }
    }
}
