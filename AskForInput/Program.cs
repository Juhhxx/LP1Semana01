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

            Console.WriteLine("Insira um número real:");
            string input2 = Console.ReadLine();
            float num2 = float.Parse(input2);

            Console.WriteLine("\n");
            float sum = num + num2;
            string result = $"A soma dos dois números é: {sum}";

            Console.WriteLine(result);

        }
    }
}
