using System;

namespace EnumClasses
{
    enum WorkingDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("constant Names of enum class ");
            foreach(string s in Enum.GetNames(typeof(WorkingDays)))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("constant values of enum class ");
            foreach (int i in  Enum.GetValues(typeof(WorkingDays)))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
