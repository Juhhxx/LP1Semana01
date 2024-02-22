using System;
using System.Text;

namespace VariousTypes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Exercício Integers

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

            // Exercício Chars

            char fist = '\u270A';
            char arrow = '\u2934';
            char c = '\u0063';
            char star = '\u2605';
            char hamSick = '\u262D';
            char square = '\u25A1';

            Console.WriteLine("Boletin de Voto\n");
            Console.WriteLine($"{square} PS {fist}");
            Console.WriteLine($"{square} PSD {arrow}");
            Console.WriteLine($"{square} BE {star}");
            Console.WriteLine($"{square} PCP {hamSick}");
            Console.WriteLine($"{square} CHEGA {c}");

        }
    }
}
