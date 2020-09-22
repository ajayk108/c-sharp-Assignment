using System;
using System.Diagnostics;
using System.IO;

namespace reverseArray
{
    class Program
    {
        int num;
        int[] arr;
        void getData()
        {
            Console.WriteLine("Enter the sze of an arrya");
            num = int.Parse(Console.ReadLine());
            arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

        }
        void revarray()
        {
            Console.WriteLine("Reversed array elements are..................");
            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();

            obj1.getData();
            obj1.revarray();

        }
    }
}
