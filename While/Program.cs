using System;
namespace While_Matheus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t  Matheus Gonçalves\n\tExercicio 3\n");
            char ch;
            int i = 10;
            do
            {
                Console.Write(i);
                Console.Write(" ");
                ch = (char)i;
                Console.WriteLine(ch);
                i++;
            } while (i <= 255);
            Console.ReadKey();
        }
    }
}

