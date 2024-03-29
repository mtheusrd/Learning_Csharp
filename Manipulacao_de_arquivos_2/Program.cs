﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulacao_de_arquivos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "teste.txt";
            FileStream fs = File.Create(caminho);
            fs.Close();

            StreamWriter sw = new StreamWriter(caminho);
            sw.Write('a');
            sw.Write('-');
            sw.Write("Ola mundo!\r\n");
            

            sw.WriteLine("c- Olá mundo 3");
            sw.WriteLine("d- Olá mundo 4");

            sw.Close();

            StreamReader sr1 = new StreamReader(caminho);

            // Ler caracteres
            char[] buffer = new char[128];
            sr1.Read(buffer, 4, 5);

            sr1.Close();

            // Ler linhas
            StreamReader sr2 = new StreamReader(caminho);
            string linha = sr2.ReadLine();
            linha = sr2.ReadLine();
            sr2.Close();

            // Ler arquivos inteiros
            StreamReader sr3 = new StreamReader(caminho);
            string arquivoInteiro = sr3.ReadToEnd();
           sr3.Close();

        }
    }
}
