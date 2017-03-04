using System;
using System.Linq;

namespace Batteries
{
    public class Program
    {
        public static void Main()
        {
            var capacities = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var usageHours = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var hours = int.Parse(Console.ReadLine());

            double used = 0;
            double result = 0;
            double percent = 0;
            
            for (int i = 0; i < capacities.Length; i++)
            {
                used = usageHours[i] * hours;
                result = capacities[i] - used;
                percent = 100 - ((used*100.0)/ capacities[i]);
                int index = i + 1;
                if (result>0)
                {
                    Console.WriteLine($"Battery {index}: {result:F2} mAh ({percent:F2})%");
                }
                else
                {
                    var lasted = Math.Ceiling(capacities[i] / usageHours[i]);
                    Console.WriteLine($"Battery {index}: dead (lasted {lasted} hours)");                    
                }           
               
            }
        }
    }
}
