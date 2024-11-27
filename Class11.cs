using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EscolhadeBebida2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha sua bebida:");
            Console.WriteLine("1 - Café");
            Console.WriteLine("2 - Chá");
            Console.WriteLine("3 - Suco");
            Console.WriteLine("4 - Refrigerante");
            Console.WriteLine("Digite o número do que deseja pedir:");

            if (int.TryParse(Console.ReadLine(), out int pedido))
            {
                switch (pedido)
                {
                    case 1:
                        Console.WriteLine("Você escolheu Café. Escolha o tipo:");
                        Console.WriteLine("1 - Expresso (R$ 3,00)");
                        Console.WriteLine("2 - Latte (R$ 8,00)");
                        Console.WriteLine("3 - Cappuccino (R$ 7,00)");

                        if (int.TryParse(Console.ReadLine(), out int cafe))
                        {
                            switch (cafe)
                            {
                                case 1:
                                    Console.WriteLine("Você pediu um Café Expresso no valor de R$ 3,00.");
                                    break;
                                case 2:
                                    Console.WriteLine("Você pediu um Latte no valor de R$ 8,00.");
                                    break;
                                case 3:
                                    Console.WriteLine("Você pediu um Cappuccino no valor de R$ 7,00.");
                                    break;
                                default:
                                    Console.WriteLine("Opção de café inválida.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida para o tipo de café.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Seu pedido é um Chá Verde no valor de R$ 3,00.");
                        break;

                    case 3:
                        Console.WriteLine("Seu pedido é um Suco Natural no valor de R$ 8,00.");
                        break;

                    case 4:
                        Console.WriteLine("Seu pedido é um Refrigerante de Limão no valor de R$ 5,00.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
            }
        }
    }
}