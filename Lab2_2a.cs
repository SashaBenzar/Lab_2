using System;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x=-1, b=3, dx=0.05;
            Console.WriteLine("  X\t\t Y");
            while (x <= b)
            {
                if (x < 0.05)
                {
                    Console.WriteLine("|" + Math.Round(x, 2) + "\tЛогарифм з вiд'ємного");
                }
                else
                { 
                    y = Math.Log10(x) / x;
                    Console.WriteLine("|" + Math.Round(x, 2) + "\t\t" + Math.Round(y, 2));
                
                }
                x += dx;
            }
        }
    }
}
