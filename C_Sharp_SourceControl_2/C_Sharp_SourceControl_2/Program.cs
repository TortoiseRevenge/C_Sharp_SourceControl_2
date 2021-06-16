using System;
using System.Collections.Generic;
namespace C_Sharp_SourceControl_2
{
    class Program
    {
     
        public static List<int> DivisibleByThree(List<int> num)
        {
            List<int> divByThree = new List<int>;
            foreach (int number in num)
            {
   
                if(number != 0 && number%3 == 0)
                {
                    divByThree.Add(number);
                }
            }
            return divByThree;
         }   
    }
}
