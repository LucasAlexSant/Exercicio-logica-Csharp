using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;

    namespace ConsoleApp2
    {
        internal class CalculadoradeImpostos
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Digite o valor do seu salário");
                float salario = Convert.ToSingle(Console.ReadLine());

                // Definir faixas de imposto
                int faixa;

                if (salario >= 3001)
                {
                    faixa = 3; // Maior que 3000
                }
                else if (salario >= 1501)
                {
                    faixa = 2; // Entre 1501 e 3000
                }
                else
                {
                    faixa = 1; // Menor ou igual a 1500
                }

                // Usar switch-case baseado nas faixas
                switch (faixa)
                {
                    case 3:
                        Console.WriteLine("Você precisa pagar " + (salario * 0.15) + " de impostos.");
                        break;
                    case 2:
                        Console.WriteLine("Você precisa pagar " + (salario * 0.1) + " de impostos.");
                        break;
                    case 1:
                        Console.WriteLine("Você precisa pagar " + (salario * 0.05) + " de impostos.");
                        break;
                    default:
                        Console.WriteLine("Erro.");
                        break;
                }
            }
        }
    }
}
