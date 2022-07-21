using System;
namespace Trabalho2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Laço - Matheus");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
