using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Stacks
{
    internal class Program
    {
        static void Main(string[] args)

            // Queue - First in, First out
        {
            Queue<string> FilaDeNomes = new Queue<string>();
            //Adicionando elementos
            FilaDeNomes.Enqueue("Guilherme");
            FilaDeNomes.Enqueue("Maria");
            FilaDeNomes.Enqueue("João");
            FilaDeNomes.Enqueue("Vagner");

            // Removendo elementos (First in / First off - FIFO)
            string nomeremovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeremovido);

            nomeremovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeremovido);

            //Espiando elementos
            Console.WriteLine("----------------------------------");
            string nomeEspiado = FilaDeNomes.Peek();
            Console.WriteLine(nomeEspiado);

            Console.WriteLine("----------------------------------");
            // Stack - First in, Last out

            Stack<string> PilhaDeNomes = new Stack<string>();

            // Adicionando elementos
            PilhaDeNomes.Push("Mariana");
            PilhaDeNomes.Push("Joaquina");
            PilhaDeNomes.Push("José");
            PilhaDeNomes.Push("Alana");

            // Removendo elementos
            string nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);

            Console.ReadKey();




        }
    }
}
