using System;

namespace VariousTypes
{
    class Program
    {
        static void Main()
        {
            int x = -100;
            short x1 = 10;
            long x2 = 1_500_000;
            uint ux = 100;
            ulong ux2 = 2_500_100;

            Console.WriteLine($"Variável tipo int: {x}");
            Console.WriteLine($"Variável tipo short: {x1}");
            Console.WriteLine($"Variável tipo long: {x2}");
            Console.WriteLine($"Variável tipo uint: {ux}");
            Console.WriteLine($"Variável tipo ulong: {ux2}");
        }
    }
}
