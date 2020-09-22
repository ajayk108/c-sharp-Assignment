using System;

namespace commandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Arguments passed by the programmer :{0}", args.Length);
                foreach (string obj1 in args)
                {
                    Console.WriteLine(obj1);
                }
            }
            else
            {
                Console.WriteLine("No Command line arguments found");
            }
        }
    }
}
