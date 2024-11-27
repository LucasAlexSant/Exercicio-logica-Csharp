using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class OperacoesAritmeticas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = Convert .ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int numero2 = Convert .ToInt16(Console.ReadLine());
            Console.WriteLine("Digite um operador (+, -, * ou /)");
            char operador = Convert .ToChar(Console.ReadLine());
            switch (operador)
            {
                case '+':
                    Console.WriteLine("O resultado da soma entre os números informados é de" + (numero1 + numero2));
                    break;
                case '-':
                    Console.WriteLine("O resultado da subtração entre os números informados é de" + (numero1 - numero2));
                    break;
                case '*':
                    Console.WriteLine("O resultado da multiplicação entre os números informados é de" + (numero1 * numero2));
                    break;
                case '/':
                    Console.WriteLine("O resultado da divisão entre os números informados é de" + (numero1 / numero2));
                    break;
                        Console.WriteLine(" Não é possivel realizar essa operação.");
                    break;
                    
            }
        }
    }
}
