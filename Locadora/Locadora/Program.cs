using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para sair da locadora: ");
            char opcao = Console.ReadKey(true).KeyChar;
            if( opcao == 'A' || opcao == 'a')
            {
                // Alugar um filme
                Console.WriteLine("Pressione 1 para alugar TOP GUN");
                Console.WriteLine("Pressione 2 para alugar A BELA E A FERA");
                Console.WriteLine("Pressione 3 para alugar O HOMEM ARANHA");
                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                switch (opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Você alugou TOP GUN");
                        break;

                    case 2:
                        Console.WriteLine("Você alugou A BELA E A FERA");
                        break;


                    case 3:
                        Console.WriteLine("Você alugou O HOMEM ARANHA");
                        break;

                    default:
                        Console.WriteLine("Opção desconhecida...");
                        break;

                    Console.WriteLine("Pressione qualquer tecla para sair!");
                    Console.ReadKey();


                }
            }
            else if(opcao == 'S' || opcao == 's')
            {
                // Sair da Locadora
                Console.WriteLine("Muito obrigado. Volte sempre!");
            }
            else
            {
                //Opção desconhecida
                Console.WriteLine("Opção desconhecida...");
            }

        }
    }
}
