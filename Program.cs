using System;

namespace CalculadoraSimplesAPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----CALCULADORA-----");
            Console.WriteLine(" ");

            Console.WriteLine("Digite a operação desejada: ");
            Console.WriteLine(" ");
            Console.WriteLine("1 SOMA // 2 SUBTRAÇÃO // 3 MULTIPLIÇÃO // 4 DIVISÃO");
            Console.WriteLine(" ");
            int op;
            Console.WriteLine(" ");
            op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza o Primeiro Valor:  ");
            int number1;
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Introduza o Segundo Valor:  ");
            int number2;
            number2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Resultado: " + (number1 + number2));
                    Console.WriteLine(" ");
                    break;

                case 2:
                    Console.WriteLine("Resultado: " + (number1 - number2));
                    Console.WriteLine(" ");
                    break;

                case 3:
                    Console.WriteLine("Resultado: " + (number1 * number2));
                    Console.WriteLine(" ");
                    break;

                case 4:
                    Console.WriteLine("Resultado: " + (number1 / number2));
                    Console.WriteLine(" ");
                    break;

                default:
                    Console.WriteLine("Pressione Qualquer Tecla Para Sair...");
                    break;

            }

        }
    }
}
