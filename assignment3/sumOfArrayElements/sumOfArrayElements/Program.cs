using System;

namespace sumOfArrayElements
{
    class Program
    {
        int num;
        int[] arr;
        void getData()
        {
            Console.WriteLine("Enter the size of an array");
            num = int.Parse(Console.ReadLine());
            arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        void sumArray()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("The sum of Array elemnts : " + sum);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();

            obj1.getData();
            obj1.sumArray();

        }
    }
}
