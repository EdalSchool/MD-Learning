using System;

namespace DataStructure
{
    public class Practice1
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
            int comparations = 0;
            int swaps = 0;
            int disordered = array.Length - 1;
            bool ordered = false;
            int temp = 0;

            while (!ordered)
            {
                ordered = true;
                for (int i = 0; i < disordered; i++)
                {
                    comparations++;
                    if (array[i] > array[i + 1])
                    {
                        swaps++;
                        ordered = false;
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                disordered --;
            }
            Console.WriteLine("Total comparisons: " + comparations);
            Console.WriteLine("Total swaps: " + swaps);
        }
    }
}