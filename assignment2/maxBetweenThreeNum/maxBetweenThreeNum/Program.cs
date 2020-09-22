using System;

namespace maxBetweenThreeNum
{
    class Program
    {
        void maxInTwo(int x, int y, int z)
        {
            if(x >y)
            {
                if(x >z)
                {
                    Console.WriteLine("{0} is greater", x);
                }
                else
                {
                    Console.WriteLine("{0} is greater", z);
                }
            }
            else
            {
                if(y > z)
                {
                    Console.WriteLine("{0} is greater", y);
                }
                else
                {
                    Console.WriteLine("{0} is greater", z);
                }
            }

        }
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Program obj = new Program();

            Console.WriteLine("Enter Three different numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            obj.maxInTwo(num1, num2, num3);
            Console.ReadKey();

        }
    }
}
