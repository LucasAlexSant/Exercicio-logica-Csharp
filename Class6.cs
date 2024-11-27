using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EscolhadeBebida
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha sua bebida:");
            Console.WriteLine("1- Café");
            Console.WriteLine("2- Chá Verde");
            Console.WriteLine("3- Suco Natural");
            Console.WriteLine("4- Refrigerante de Limão");
            Console.WriteLine("Digite o numero do que deseja pedir:");
            int pedido = Convert.ToInt16(Console.ReadLine());
            switch (pedido)
            {
                case 1:
                    Console.WriteLine("Seu pedido é um Café no valor de 2,00 R$");
                    break;
                case 2:
                    Console.WriteLine("Seu pedido é um Chá Verde no valor de 3,00 R$");
                    break;
                case 3:
                    Console.WriteLine("Seu pedido é um Suco Natural no valor de 8,00 R$");
                    break;
                case 4:
                    Console.WriteLine("Seu pedido é um Refrigerante de Limão no valor de 5,00 R$");
                    break;

            }
        }
    }
}
