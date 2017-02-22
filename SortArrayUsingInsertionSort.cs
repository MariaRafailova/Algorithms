using System;
using System.Linq;

namespace SortArrayUsingInsertionSort
{
    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int firstUnsorted = 0; firstUnsorted < arr.Length - 1;
            firstUnsorted++)
            {
                var i = firstUnsorted + 1;
                while (i > 0)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }                    
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
