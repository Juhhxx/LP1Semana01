using System;

namespace ManyStrings
{
    class Program
    {
        static void Main()
        {
            double xx = 1.23456;
            int ii = 19;

            // Exercices strings
            string s = "Era uma vez\nUma pessoa\nChamada Afonso\n\t \uA231";
            string chessboardW = "\u2656 \u2658 \u2657 \u2654 \u2655 \u2657 \u2658 \u2656";
            char pondW = '\u2659';
            string chessboardW2 = $"{pondW} {pondW} {pondW} {pondW} {pondW} {pondW} {pondW} {pondW}";
  
            Console.WriteLine(s);
            Console.WriteLine(chessboardW);
            Console.WriteLine(chessboardW2);
            Console.WriteLine("\n");

            // Exercices strings 2
            int two = 2;
            string sc = "Tinha um (" + 1 + ") dedo.";
            string si = $"E dois ({two}) pés.";

            Console.WriteLine(sc);
            Console.WriteLine(si);
            Console.WriteLine("\n");

            // Exercise formating

            string dec = $"{xx:f2}";
            string per = $"{xx:p1}";
            string hex = $"{ii:x}";
            string cur = $"{ii:c}";

            Console.WriteLine(dec);
            Console.WriteLine(per);
            Console.WriteLine(hex);
            Console.WriteLine(cur);

        }
    }
}
