using System;
namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to math test. First exercise, please, enter decision 5 * 8 =  ");
            int x = Convert.ToInt32(Console.ReadLine());
            case1(x);
            Console.ReadKey();
        }
        static void case1(int n)
        {
            if (n == 40)
            {
                Console.Write($" Good answer! Next question, enter decision: {n} / 2 = ");
                int z = Convert.ToInt32(Console.ReadLine());
                case2(z);
                Console.ReadKey();
            }
            else 
            {
                Console.Write($"Is not right answer, enter decision: 40 * 10 = ");
                int p = Convert.ToInt32(Console.ReadLine());
                case2a(p);
                Console.ReadKey();
            }
        }

        static void case2a(int p)
        {
            if (p == 400)
            {
                Console.Write($" Good answer. Your mark is 5 !");
            }
            else 
            {
                Console.Write($"Sorry, it's bad answer, your mark is 2. Next time will be better!");
            }
        }

        static void case2(int z)
        {
            if (z == 20)
            {
                Console.Write($" Good answer! Next question, enter decision: {z} + {z} = ");
                int d = Convert.ToInt32(Console.ReadLine());
                case3(d);
                Console.ReadKey();
            }
            if (z == 19 || z == 21)
            {
                Console.Write($"Is not right answer. Next question, enter decision: 40 * 10 = ");
                int p = Convert.ToInt32(Console.ReadLine());
                case3a(p);
                Console.ReadKey();
            }
            else 
            {
                Console.Write($"Thank you for participation. Your mark is 6!");
            }
        }



        static void case3a(int p)
        {
            if (p == 400)
            {
                Console.Write(" Good answer. Your mark is 7!");
            }
            else 
            {
                Console.Write("Sorry, it's bad answer, your mark is 6.");
            }
        }

        static void case3(int d)
        {
            if (d == 40)
            {
                Console.Write($" Good answer! Next question, enter decision: 48 - 10 / 2 = ");
                int q = Convert.ToInt32(Console.ReadLine());
                case4(q);
                Console.ReadKey();
            }
            else
            {
                Console.Write($"Sorry, it's bad answer, your mark is 8.");
            }
        }

        static void case4(int q)
        {
            if (q == 43)
            {
                Console.Write($" Good answer! Last question, please, enter your name: ");
                string k = Console.ReadLine();
                case5(k);
                Console.ReadKey();
            }
            else
            {
                Console.Write($"Sorry, it's bad answer, your mark is 9.");
            }
        }

        static void case5(string k)
        {
                Console.Write($" Congratilation {k}, your mark is 10 !!!");
        }
    }
}