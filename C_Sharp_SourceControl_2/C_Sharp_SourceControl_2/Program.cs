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

        public static int DivisibleByThree(List<int> num)
        {
            Console.WriteLine("Numbers Divisible by Three: ");
            foreach (int number in num)
            {
   
                if(number != 0 && number%3 == 0)
                {
                    return number;
                }
            }
          
        }
    }
}
