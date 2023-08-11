using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_de_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Indexação
            string nome = "Matheus";
            char letra = nome[3];
            Console.WriteLine(letra);

            // Concatenar string
            string sobrenome = " Luiz Rodrigues";
            string nomecompleto = nome + sobrenome;
            Console.WriteLine(nomecompleto);

            string nomecompleto2 = string.Concat(nome, sobrenome);

            // Substituição de strings
            string endereco = "Rua das Rosas Verdes";
            endereco = endereco.Replace("Verdes", "Vermelhas");
            Console.WriteLine(endereco);

            // Remoção de strings
            string endereco2 = "Rua das Rosas Verdes";
            endereco2 = endereco2.Replace("Verdes", "");
            Console.WriteLine(endereco2);

            string endereco3 = "Rua das Rosas Verdes";
            endereco3 = endereco3.Remove(0, 4);

            // Capitalização de strings
            string nome2 = "Joao da Silva";
            nome2 = nome2.ToUpper();
            Console.WriteLine(nome2);

            nome2 = nome2.ToLower();
            Console.WriteLine();

            // Contém
            string nome3 = "Joao da Silva";
            bool contem = nome3.Contains("Joao");
            Console.WriteLine(contem);
            contem = nome3.Contains("Marcos");
            Console.WriteLine(contem);

            // Localização de textos
            string nome4 = "Joao da Silva";
            int indice = nome4.IndexOf("da");
            Console.WriteLine(indice);

            // Divisão de strings
            string nome5 = "Joao da Silva";
            string[] divisores = { "da" };
            string[] resultadoDaDivisao = nome5.Split(divisores, StringSplitOptions.None);
            foreach(string texto in resultadoDaDivisao)
            {
                 Console.WriteLine(texto);
            }

            // Numero de caracteres
            string nome6 = "Joao da Silva";
            int numerocaracteres = nome6.Length;
            Console.WriteLine(numerocaracteres);

            //Substring
            string nome7 = "Joao da Silva";
            string ultimonome = nome7.Substring(8, 5);
            Console.WriteLine(ultimonome);

            // Formatação composta
            string nome8 = "Joao {0} {1}";
            Console.WriteLine(nome8, "da Silva", "Sauro");
            string nomecompleto6 = String.Format(nome8, "da Silva", "Sauro");









            Console.ReadKey();
        }
    }
}
