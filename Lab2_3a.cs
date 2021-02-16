using System;

namespace Lab2_3a
{
    public class Program
    {
        static public int Sum_el(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; ++i)
                if (i % 2 == 0)
                    sum += a[i];
            return sum;
        }
        static public int Dob_el(int[] a, int n)
        {
            int min = 999, max = 999, max_in = 999, min_in = 998, dob = 1;
            for (int i = 0; i < n; ++i)
                if (a[i] < 0)
                    max = a[i];
            for (int i = n - 1; i >= 0; --i)
                if (a[i] < 0)
                    min = a[i];
            for (int i = 0; i < n; ++i)
            {
                if (a[i] == min)
                    min_in = i;
                if (a[i] == max)
                    max_in = i;
            }
            if (max_in == min_in)
                dob = -999;
            else if (max_in == 999 && min_in == 998)
                dob = 999;
            else
                for (int i = min_in + 1; i < max_in; ++i)
                    dob *= a[i];
            return dob;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int sum = 0, dob=1;
            for (int i = 0; i < n; ++i)
            a[i] = int.Parse(Console.ReadLine());
            sum = Sum_el(a, n);
            dob = Dob_el(a, n);
            Console.WriteLine("\nсуму елементiв масиву з непарними номерами:" + sum);
            if (dob==-999)
                Console.WriteLine("в массивi лише один выд'ємний елемент");
            else if (dob==999)
                Console.WriteLine("в массивi нема вiд'ємних елементiв");
            else
                Console.WriteLine("добуток елементiв масиву, розташованих мiж першим й останнiм вiд’ємними елементами: " + dob);
        }

    }
}
