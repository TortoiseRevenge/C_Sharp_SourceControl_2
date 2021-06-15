using System;
using System.Collections.Generic;

namespace C_Sharp_SourceControl_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Displays an inputed list of number in a comma seperated list (on 1 line)
        public static void DisplayList(List<int> nums)
        {
            string result = "Numbers are: ";
            foreach(int num in nums)
            {
                result += num + ", ";
            }
            Console.WriteLine(result.Substring(0, result.Length - 2));
        }

        // Returns a list of numbers containing only the odd numbers in the original list
        public static List<int> GetOdds(List<int> nums)
        {
            List<int> result = new List<int>();
            foreach(int num in nums)
            {
                if (num % 2 == 1)
                {
                    result.Add(num);
                }
            }
            return result;
        }

        // Returns a list of numbers containing only the even numbers in the original list
        public static List<int> GetEvens(List<int> nums)
        {
            List<int> result = new List<int>();
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }
            return result;
        }
    }
}
