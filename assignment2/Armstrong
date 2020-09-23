using System;

namespace ArmstrongOrNot
{
    class Program
    {
        void arm(int x)
        {
            int a, arm = 0, temp;
            temp = x;
            for (; x > 0;)
            {
                a = x % 10;
                arm = arm + (a * a * a);
                x = x / 10;
            }
            if (temp == arm)
                Console.WriteLine("Number is Armstrong");
            else
                Console.WriteLine("Number is Not Armstrog");
        }
        static void Main(string[] args)
        {
            int num;
            Program obj = new Program();

            Console.WriteLine("Enter a three digit number to check whether number is Armstrog or Not");
            num = int.Parse(Console.ReadLine());

            obj.arm(num);
            Console.ReadKey();
        }
    }

}
