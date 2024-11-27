using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DiasdaSemana
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de um a sete");
            int numero = Convert.ToInt16(Console.ReadLine());
            if (numero < 8)
            {
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;

                    case 2:
                        Console.WriteLine("Segunda-Feira");
                        break;
                    case 3:
                        Console.WriteLine("Terça-Feira");
                        break;
                    case 4:
                        Console.WriteLine("Quarta-Feira");
                        break;
                    case 5:
                        Console.WriteLine("Quinta-feira");
                        break;
                    case 6:
                        Console.WriteLine("Sexta-Feira");
                        break;
                    case 7:
                        Console.WriteLine("Sabado");
                        break;
                    
                        
                        }
            }
            else
            {
                Console.WriteLine("Dia da semana não encontrado");
            }
            {

            }


                }

            }
        }
    

