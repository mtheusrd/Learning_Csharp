using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoProjeto
{
    internal class Program
    {
        struct DadosCadastrais_Struct
        {
            public string Nome;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
            public string NumeroDoDocumento;
        }
        static void Main(string[] args)
        {
            List<DadosCadastrais_Struct> ListaDeCadastros = new List<DadosCadastrais_Struct>();
            string opcao;
            do {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if(opcao == "c")
                {
                    // Cadastrar um novo usuario
                    DadosCadastrais_Struct dadosCadastrais;
                    Console.WriteLine("Digite o nome completo:");
                    dadosCadastrais.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o nome da Rua:");
                    dadosCadastrais.NomeDaRua = Console.ReadLine();

                    Console.WriteLine("Digite o numero da Casa:");
                    dadosCadastrais.NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine("Digite o numero do Documento:");
                    dadosCadastrais.NumeroDoDocumento = Console.ReadLine();
                    ListaDeCadastros.Add(dadosCadastrais);
                    Console.Clear();

                }
                else if(opcao == "s")
                {
                    // Encerra a aplicação
                    Console.WriteLine("Encerrando a aplicação...");
                }
                else
                {
                    // Opção Desconhecida
                    Console.WriteLine("Opção desconhecida!");
                }
            } while (opcao == "s");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();

        }
    }
}
