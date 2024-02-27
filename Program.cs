using System;

namespace CalculatorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtration(); break;
                case 3: Divison(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 + value2;
            Console.WriteLine($"O resultado da soma é {result}");
            // Console.WriteLine("O resultado da soma é " + result);
            // Console.WriteLine("O resultado da soma é " + (value1 + value2));
            // Console.WriteLine($"O resultado da soma é {value1 + value2}");
            Menu();
        }

        static void Subtration()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 - value2;
            Console.WriteLine($"O resultado da subtração é {result}");

            Console.ReadKey();
            Menu();
        }

        static void Divison()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 / value2;
            Console.WriteLine($"O resultado da divisão é {result}");
            
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 * value2;
            Console.WriteLine($"O resultado da multiplicação é {result}");
            
            Console.ReadKey();
            Menu();
        }
    }
}