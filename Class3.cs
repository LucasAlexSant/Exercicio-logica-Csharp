using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ClassificacaodeIdade
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            switch (idade)
            {
                case <= 12:
                    Console.WriteLine("Você é criança");
                    break;
                case >= 13 and <= 17:
                    Console.WriteLine("Você é adolescente");
                    break;
                case >= 18 and <= 59:
                    Console.WriteLine("Você é adulto");
                    break;
                case >= 60 :
                    Console.WriteLine("Você é idoso");
                    break;
            }
        }

    }
}
