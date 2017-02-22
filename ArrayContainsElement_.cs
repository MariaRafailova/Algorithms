using System;
using System.Linq;

namespace ArrayContainsElement_
{
    public class ArrayContainsElement_
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var n = int.Parse(Console.ReadLine());
            
            var containsElement = false;            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    containsElement = true;
                    break;
                }                    
            }

            if (containsElement)
            {
                Console.Write("yes");
            } 
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
