using System;
namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t  Matheus Gonçalves\n\t Exercicio 5\n");

            int valor;
            string temp;
            char escolha;
            double centimetro, litros, Kilometro;

            Console.WriteLine("Informe um valor inteiro para converter :");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n Pressione uma das opções dadas : \n P -> converte de Polegadas para Centímetros. \n G->converte de Galões para Litros.\n M->converte de Milas para Kilômetros");

            temp = Console.ReadLine().ToString().ToUpper();
            escolha = Convert.ToChar(temp);

            switch (escolha)
            {
                case 'P':
                    centimetro = valor / 0.3937;                       //1 cm é igual a  0.3037 polegadas
                    Console.WriteLine("\n\n" + valor + " Polegadas são " + centimetro + " centímetros (cm) ");
                    break;
                case 'G':
                    litros = valor * 3.78;                             // 1 galão é igual a 3.78 litros
                    Console.WriteLine("\n\n" + valor + " Galões são " + litros + " litros (l) ");
                    break;
                case 'M':
                    Kilometro = valor * 1.60;                          // 1 Milha é igual a 1.60 Kilometros
                    Console.WriteLine("\n\n" + valor + " Milhas são " + Kilometro + " Kilometros (Km) ");
                    break;
                default:
                    Console.WriteLine("Opção Inválida. Informe uma das opções oferecida:  P , G ou M ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
