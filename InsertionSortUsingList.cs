using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSortUsingList
{
    public class InsertionSortUsingList
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var resultList = new List<int>();

            for (int arrIndex = 0; arrIndex < nums.Length; arrIndex++)
            {
                var inserted = false;
                var currentElement = nums[arrIndex];

                for (int listIndex = 0; listIndex < resultList.Count; listIndex++)
                {
                    var currentListElement = resultList[listIndex];

                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        resultList.Insert(Math.Max(0, listIndex), currentElement);
                        break;
                    }
                }
                if (!inserted)
                {
                    resultList.Add(currentElement);
                }
            }           

            Console.WriteLine(string.Join(" ", resultList));
    }
    }
}
