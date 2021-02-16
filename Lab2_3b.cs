using System;

namespace Lab2_3b
{
    class Program
    {
        static int Sum_el(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; ++i)
                if (i % 2 == 0)
                    sum += a[i];
            return sum;
        }
        static string Dob_el(int[] a, int n) 
        {
            int min = 999, max = 999, max_in = 999, min_in = 998, dob = 1;
            string otvet;
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
            for (int i = min_in + 1; i < max_in; ++i)
                dob *= a[i];
            if (max_in == min_in)
                otvet = "в массивi лише один выд'ємний елемент";
            else if (max_in == 999 && min_in == 998)
                otvet = "в массивi нема вiд'ємних елементiв";
            else
                otvet = "добуток елементiв масиву, розташованих мiж першим й останнiм вiд’ємними елементами: " + dob;
            return otvet;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random realRnd = new Random();
            int sum = 0;
            string dob;
            for (int i = 0; i < n; ++i)
                a[i] = realRnd.Next(-100,100);
            for (int i = 0; i < n; ++i)
                Console.Write(a[i]+"\t");
            sum = Sum_el(a, n);
            dob = Dob_el(a, n);
            Console.WriteLine("\nсуму елементiв масиву з непарними номерами:" + sum);
            Console.WriteLine(dob);
        }
        
    }
}
