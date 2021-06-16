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
                    Console.WriteLine("Success");                  
                }
                catch (Exception e)
                {
                    continueOn = false;
                    Console.WriteLine("Moving to commands");
                }
            }

            bool continueOnTwo = true;
            while (continueOnTwo == true)
            {
                string InputStr = Console.ReadLine();
                if (InputStr == "o")
                {
                    Console.WriteLine("Success 1");
                }
                else if (InputStr == "d")
                {
                    Console.WriteLine("Success 2");
                }
                else if (InputStr == "e")
                {
                    foreach (int i in Numbers)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Failed");
                    continueOnTwo = false;
                }
            }
        }
        private static int IntInput
        {
            get => IntInput; set => IntInput = value;
        }
    }
}
          
     
 

