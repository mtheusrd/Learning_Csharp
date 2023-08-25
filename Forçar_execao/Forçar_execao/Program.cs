using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forçar_execao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Escreva um número positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if(numero < 0)
                {
                    // Forçar uma exceção.
                    throw new Exception("O Número " + numero + " é menor que zero!");
                
                }
                else
                {
                    Console.WriteLine("Você digitou o número " + numero);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
            }
        }
    }
}
