using System;
using System.Collections.Generic;
using System.Linq;

namespace DecodeRadioFrequencies
{
    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(" .".ToCharArray())
                .Select(int.Parse)
                .ToList();
            
            var result1 = new List<char>();
            var result2 = new List<char>();
           
            for (int i = 0; i < input.Count; i++)
            {
                if (i%2 == 0 && input[i] != 0)
                {
                    result1.Add((char)input[i]);                    
                }

                if (i%2 !=0 && input[i] != 0)
                {                    
                    result2.Add((char)input[i]);                    
                }
            }

            result2.Reverse();
            
            Console.Write(string.Join("", result1));
            Console.WriteLine(string.Join("", result2));
        }
    }
}
