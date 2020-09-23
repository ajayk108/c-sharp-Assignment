using System;

namespace fibonacciSeries
{
    class Program
    {
        void fibonacci(int x)
        {
            int a = 0, b = 1, c;
            Console.Write(a + "\t" + b);
            for (int i = 2; i < x; i++)
            {
                c = a + b;
                Console.Write("\t" + c);
                a = b;
                b = c;
            }

        }
        static void Main(string[] args)
        {
            int num;
            Program obj = new Program();

            Console.WriteLine("Enter a number to print Fibonacci series");
            num = int.Parse(Console.ReadLine());

            obj.fibonacci(num);
            Console.ReadKey();
        }
    }
}
