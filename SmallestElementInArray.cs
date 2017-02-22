using System;
using System.Linq;


namespace SmallestElementInArray
{
    public class SmallestElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var minNum = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
