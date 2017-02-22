using System;
using System.Linq;

namespace SortArrayUsingBubbleSort
{
    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool swapped;
            
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    var current = arr[i];
                    var next = arr[i + 1];

                    if (arr[i] > arr[i + 1])
                    {
                        arr[i + 1] = current;
                        arr[i] = next;
                        
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
