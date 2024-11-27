using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class NotadoAluno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua nota");
            int nota = Convert.ToInt16(Console.ReadLine());
            switch (nota)
            {
                case >=0 and <=2:
                    Console.WriteLine("Você ganhou F");
                    break;
                case >= 3 and <=4:
                    Console.WriteLine("Você ganhou D");
                    break;
                case >= 5 and <= 6:
                    Console.WriteLine("Você ganhou C");
                    break;
                case >= 7 and <= 8:
                    Console.WriteLine("Você ganhou B");
                    break;
                case >= 9 and <= 10:
                    Console.WriteLine("Você ganhou A");
                    break;

            }
        }
    }
}
