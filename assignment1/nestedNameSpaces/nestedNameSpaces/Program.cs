using System;
using p = parent.first;
using c = parent.child.second;  

namespace parent
{
    class first
    {
        public void Pos_Neg(int x)
        {
            if (x > 0)
                Console.WriteLine("No is Positive");
            else
                Console.WriteLine("No is Negative");
        }

    }
    namespace child
    {
        class second
        {
            public void evenOdd(int x)
            {
                if (x % 2 == 0)
                    Console.WriteLine("No is Even");
                else
                    Console.WriteLine("NO is Odd");
            }
        }
    }
}
namespace NestedNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            p obj1 = new p();
            obj1.Pos_Neg(5);
            c obj2 = new c();
            obj2.evenOdd(5);

        }
    }
}
