using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IMC_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************|");
            Console.WriteLine("************************************************|");
            Console.WriteLine("                 IMC Calculator                 |");
            Console.WriteLine("************************************************|");
            Console.WriteLine("************************************************|");
            Console.WriteLine();
            Console.WriteLine("Welcome to IMC Calculator. What's your name?:");
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hi " + nome +"! You are a:");
            Console.WriteLine();
            Console.WriteLine("1 - Men");
            Console.WriteLine("2 - Woman");
            UInt32 sexo = Convert.ToUInt32(Console.ReadKey(true). KeyChar.ToString());
            Console.WriteLine();
            Console.WriteLine("How tall are you (in CM)");
            UInt32 height = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("What's your AGE?");
            UInt32 age = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("What's your WEIGHT? (like 85.5)");
            double weight = Convert.ToDouble(Console.ReadLine());

            Thread.Sleep(3000);

            double IMC = weight / (height * height);
            if (sexo == '1')
            {
                Console.WriteLine("Sex: Men");

            }
            else
            {
                Console.WriteLine("Sex: Woman");

            }
            Console.WriteLine("Height: " + height + "cm");
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Age: " + age);
            Console.WriteLine();
            Console.WriteLine("IMC: " + IMC);
            Console.WriteLine();
           if(IMC <18.5)
            {
                Console.WriteLine("Rating: You are thin!");
            }
           else if(IMC == 18.5 || IMC <24.9){
                Console.WriteLine("Rating: Your weight is normal!");
            }
            else if (IMC == 25 || IMC < 29.9)
            {
                Console.WriteLine("Rating: You are overweight!");
            }
            else if (IMC == 30 || IMC < 34.9)
            {
                Console.WriteLine("You have Obesity grade I!");
            }
            else if (IMC == 35 || IMC < 39.9)
            {
                Console.WriteLine("You have Obesity grade II!");
            }
            else if (IMC > 39.9)
            {
                Console.WriteLine("You have Obesity grade III!");
            }






            Console.ReadKey();
        }
    }
}
