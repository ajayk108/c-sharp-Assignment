using System;
using System.ComponentModel;

namespace userInput
{
    class Program
    {
        static void add(int x, int y)
        {
            Console.WriteLine("Addition ={0}", (x + y));
        }
        static void sub(int x, int y)
        {
            Console.WriteLine("Subtraction ={0}", (x - y));
        }
        static void mul(int x, int y)
        {
            Console.WriteLine("Multiplication ={0}", (x * y));
        }
        static void div(int x, int y)
        {
            Console.WriteLine("Division ={0}", (x / y));
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers: ");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            add(a, b);
            sub(a, b);
            mul(a, b);
            div(a, b);
           



        }
    }
}
