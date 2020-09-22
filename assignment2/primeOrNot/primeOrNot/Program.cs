using System;

namespace primeOrNot
{
    class Program
    {
        void prime(int x)
        {
            int m=0, flag=0;
            m = x / 2;
            for(int i=2; i<=m; i++)
            {
                if(x%i == 0)
                {
                    Console.WriteLine("Number is Not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime");
        }
        static void Main(string[] args)
        {
            int num;
            Program obj = new Program();
            
            Console.WriteLine("Enter a number to check whether it is prime or not");
            num = int.Parse(Console.ReadLine());

            obj.prime(num);
            Console.ReadKey();
        }
    }
}
