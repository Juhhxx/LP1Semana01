using System;

namespace AskForInput
{
    class Program
    {
        static void Main()
        {
            // Exercice ask for input
            Console.WriteLine("Insira um número inteiro:");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            Console.WriteLine("\n");

        }
    }
}
