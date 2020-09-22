using System;
using System.Diagnostics;

namespace swapTwonumWithoutThirdVar
{
    class Program
    {
        void swap(int x, int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swapping...");
            Console.WriteLine("{0} {1}", x, y);
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Program obj = new Program();

            Console.WriteLine("Enter two different numbers for swaping");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping....");
            Console.WriteLine("{0} {1}",num1, num2);
            obj.swap(num1, num2);

            Console.ReadKey();


        }
    }
}
