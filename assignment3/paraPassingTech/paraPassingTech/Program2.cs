using System;

//Reference parameters / Pass by reference........................
namespace paraPassingTech
{
    class Program2
    {
        string empName;
        void changeref(Program2 x)
        {
            x.empName = "Angela";
            Console.WriteLine("inside method value of empName is: " + x.empName);
        }
        static void Main(string[] args)
        {
            Program2 p2 = new Program2();
            p2.empName = "Elliot";
            Console.WriteLine("value of empName before calling method is: " + p2.empName);
            p2.changeref(p2);
            Console.WriteLine("value of empName after calling method is : " + p2.empName);
            Console.ReadKey();
        }
    }
}