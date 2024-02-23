using System;

namespace DecimalHexa
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira 4 números inteiros:");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            string num4 = Console.ReadLine();

            int n1 = int.Parse(num1);
            int n2 = int.Parse(num2);
            int n3 = int.Parse(num3);
            int n4 = int.Parse(num4);

            Console.WriteLine($"{n1,6}  {n1,6:X}");
            Console.WriteLine($"{n2,6}  {n2,6:X}");
            Console.WriteLine($"{n3,6}  {n3,6:X}");
            Console.WriteLine($"{n4,6}  {n4,6:X}");

        }
    }
}
