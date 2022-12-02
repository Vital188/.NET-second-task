using System;
namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n: ");
            int x = Convert.ToInt32(Console.ReadLine());
            // int x = 6;
            case1(x);
            Console.ReadKey();
        }
        static void case1(int n)
        {
            if (n > 5)
            {
                Console.Write($"Case 1: {n} ");
                case1(n / 2);
                case2(n + 3);
            }
            else 
            {
                Console.Write($"{n} is not right number, case 1");
            }
        }

        static void case2(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                case2(n - 1);
            }
        }

        static void case3(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                case3(n - 1);
            }
        }

        static void case4(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                case4(n - 1);
            }
        }

        static void case5(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                case5(n - 1);
            }
        }
    }
}