using System;
using System.Collections.Generic;

namespace C_Sharp_SourceControl_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool continueOn = true;
            List<int> Numbers = new List<int>();

            while (continueOn == true)
            {
                string IntInput = Console.ReadLine();
                try
                {
                    int InputNum = int.Parse(IntInput);
                    Numbers.Add(InputNum);
                }
                catch(Exception e)
                {
                    continueOn = false;
                }
                
                
            }
        }
        private static int IntInput
        {
            get => IntInput; set => IntInput = value;
        }
    }
}
          
     
 

