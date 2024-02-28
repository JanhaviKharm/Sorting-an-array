/*
Author: Janhavi Kharmale
Date: 02/28/2024
Comments: This C# Console Application code demonstrates the
    Selection Sort. 
*/

namespace Sorting_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sort_arr = { 3,62,5,16,4,10 };
            Console.WriteLine("Here is the original array that will be used to execute the Selection Sort Algorithm: ");
            for (int i = 0; i < sort_arr.Length; i++)
            {
                Console.Write("  " + sort_arr[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Here is the array after the execution of the Selection Sort Algorithm: ");
            Selection_Sort(sort_arr);
            Console.WriteLine("");
            static void Selection_Sort(int[] ss_arr)
            {
                int min_position;
                int temp;

                for (int i = 0; i < ss_arr.Length; i++)
                {
                    min_position = i;
                    for (int x = i + 1; x < ss_arr.Length; x++)
                    {
                        if (ss_arr[x] < ss_arr[min_position])
                        {
                            min_position = x;
                        }
                    } 

                    if (min_position != i)
                    {
                        temp = ss_arr[i];
                        ss_arr[i] = ss_arr[min_position];
                        ss_arr[min_position] = temp;
                    }
                    Console.Write("  " + ss_arr[i]);
                } 
            } 
        }
    }
}
