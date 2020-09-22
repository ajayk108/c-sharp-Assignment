using System;

namespace Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            object obj = num; // boxing 
            int i = (int)obj; //unboxing
            Console.WriteLine("Value type of objcet is " + obj);
            Console.WriteLine("Value type of i is " + i);
            Console.ReadKey();

        }
    }
}
