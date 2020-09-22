using System;

//output parameters..................................
namespace paraPassingTech
{
    class Program3
    {
        static void Cube(int x, out int y)
        {
            y = x * x * x;

        }
        static void Main(string[] args)
        {
            int m;
            Program3 p3 = new Program3();

            Cube(10, out m);

            Console.WriteLine("value of m is: " + m);
            Console.ReadKey();

        }
    }
}