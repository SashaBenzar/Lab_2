using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kvartira;
            do {
                Console.WriteLine("Введiть номер квартири:");
                kvartira = int.Parse(Console.ReadLine());
                switch (kvartira)
                {
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24: Console.WriteLine("квартира знаходиться на 1 поверсi\n"); break;
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29: Console.WriteLine("квартира знаходиться на 2 поверсi\n"); break;
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                    case 34: Console.WriteLine("квартира знаходиться на 3 поверсi\n"); break;
                    case 35:
                    case 36:
                    case 37:
                    case 38:
                    case 39: Console.WriteLine("квартира знаходиться на 4 поверсi\n"); break;
                    case 40:
                    case 41:
                    case 42:
                    case 43:
                    case 44: Console.WriteLine("квартира знаходиться на 5 поверсi\n"); break;
                    case 45:
                    case 46:
                    case 47:
                    case 48:
                    case 49: Console.WriteLine("квартира знаходиться на 6 поверсi\n"); break;
                    case 50:
                    case 51:
                    case 52:
                    case 53:
                    case 54: Console.WriteLine("квартира знаходиться на 7 поверсi\n"); break;
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59: Console.WriteLine("квартира знаходиться на 8 поверсi\n"); break;
                    case 60:
                    case 61:
                    case 62:
                    case 63:
                    case 64: Console.WriteLine("квартира знаходиться на 9 поверсi\n"); break;
                    default:Console.WriteLine("Такого поверху немає\n"); break;
                }
            }while (kvartira!=0);
        }
    }
}
