using System;

namespace Lab2_5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть стовбцiв:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введiть кiлькiсть рядкiв:");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n,m];
            double  dob = 1;
            Console.WriteLine("Введiть елементи матрицi:");
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    a[i,j] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i) 
            {
                Console.Write("\n");
                for (int j = 0; j < m; ++j)
                    Console.Write(" " + a[i, j] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    dob *= a[i, j];
            if (dob < 0)
            {
                Console.Write("Неможливо взяти середнє геометричне значення всiх елементiв матрицi");
            }
            else
            {
                dob = Math.Sqrt(dob);
                Console.Write("середнє геометричне значення всiх елементiв матрицi:" + Math.Round(dob, 2));
            }
        }
    }
}
