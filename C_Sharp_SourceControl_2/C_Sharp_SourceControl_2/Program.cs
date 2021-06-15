using System;
using System.Collections.Generic;
namespace C_Sharp_SourceControl_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void displaySum(List<int> nums)
        {
            int sum = 0;
            foreach (int x in nums)
            {
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
