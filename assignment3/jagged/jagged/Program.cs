using System;

namespace jaggedArrrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[3][]; //Declaring 2D array with 2 rows

            //Making the above array jagged
            jagged_arr[0] = new int[3]; //first row has 3 columns
            jagged_arr[1] = new int[2]; //second row has 2 columns
            jagged_arr[2] = new int[4]; //third row has 4 columns

            //initializing array
            int count = 1;
            for(int i=0; i<jagged_arr.Length; i++)
            {
                for(int j=0; j<jagged_arr[i].Length; j++)
                {
                    jagged_arr[i][j] = count++;
                }
            }

            //displaying the values of array
            Console.WriteLine("jagged array values are..........");
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.Write(jagged_arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
