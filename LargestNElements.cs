using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNElements
{
    public class LargestNElements
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            nums.Sort();
            nums.Reverse();

           var result = nums.Take(n);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
