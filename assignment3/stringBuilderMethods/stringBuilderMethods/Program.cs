using System;
using System.Text; //for StringBuilder...

namespace stringBuilderMethods
{
    // string methods...............................
    class Program
    {
        static void Main(string[] args)
        {
            string j, p;
            j = "java";
            p = "python";
            Console.WriteLine("Using clone():" + j.Clone());
            //compare method
            if (string.Compare(j, p) == 0)
                Console.WriteLine(j + " and " + p + " are equal");
            else
                Console.WriteLine(j + " and " + p + " are not equal");

            Console.WriteLine(j.ToUpper());
            Console.WriteLine(j.ToLower());
            Console.WriteLine(p.Replace('n', 'N'));
            Console.WriteLine(j.Length);
            Console.WriteLine(p.Length);
            Console.ReadKey();


        }
    }
    
    // StringBuilder.........................................
    class program2
    {
        static void concat1(string s1)
        {
            s1 = s1 + "welcome";
        }
        static void concat2(StringBuilder s2)
        {
            s2.Append("Strings");
        }
        static void Main(string[] a)
        {
            string s1 = "c# programming";
            concat1(s1); //s1 will not change
            Console.WriteLine("After s1 concatination :\t" + s1);
            StringBuilder s2 = new StringBuilder("Mutable  ");
            concat2(s2);
            Console.WriteLine("After s2 concatination :\t" + s2);
            s2.Replace("Mutable", "immutable");
            Console.WriteLine("After replacing the string is:\t" + s2);
            Console.ReadKey();
        }
    }
    
    
}
