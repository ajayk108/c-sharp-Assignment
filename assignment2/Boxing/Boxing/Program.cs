using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            object obj = num;   //boxing 
            num = 100;          //value of num to be changed
            Console.WriteLine("Value type of num is " + num);
            Console.ReadKey();
            
        }
    }
}
