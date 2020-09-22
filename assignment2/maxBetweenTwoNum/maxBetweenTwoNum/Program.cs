using System;

namespace maxBetweenTwoNum
{
    class Program
    {
        void maxInTwo(int x, int y)
        {
            if(x > y)
                Console.WriteLine("{0} is greater", x);
            else
                Console.WriteLine("{0} is greater", y);
            
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Program obj = new Program();

            Console.WriteLine("Enter two different numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            obj.maxInTwo(num1,num2);
            Console.ReadKey();

        }
    }
}
