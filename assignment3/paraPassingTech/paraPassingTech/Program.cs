using System;


//value parameters / pass by value............................
namespace paraPassingTech
{
    class Program1
    {
        int num;
        void changeVal(int x)
        {
            x = x + 100;
            Console.WriteLine("value inside method is: " + x);
        }
        public static void Main(string[] args1)
        {
            Program1 p1 = new Program1();
            p1.num = 400;
            Console.WriteLine("Value of num befor calling method is: " + p1.num);
            p1.changeVal(p1.num);
            Console.WriteLine("Value after calling method is: " + p1.num);
            Console.ReadKey();
        }
    }

}














