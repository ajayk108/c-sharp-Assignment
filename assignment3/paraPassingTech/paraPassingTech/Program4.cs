using System;
using System.Resources;


//parameter arrays.....................
namespace paraPassingTech
{
    class Program4
    {
        int addElements(params int[] arr)
        {
            int sum = 0;

            foreach(int i in arr)
            {
                sum = sum + i;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Program4 p4 = new Program4();
            int s;
            s = p4.addElements(10, 30, 40, 50);

            Console.WriteLine("sum of elements: " + s);
            Console.ReadKey();
        }
    }
}