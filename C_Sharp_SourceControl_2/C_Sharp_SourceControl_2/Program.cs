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
                    Console.WriteLine("Displaying Odds");
                    DisplayList(GetOdds(Numbers));
                }
                else if (InputStr == "e")
                {
                    Console.WriteLine("Displaying Evens");
                    DisplayList(GetEvens(Numbers));
                }
                else if (InputStr == "d")
                {

                    DisplayList(Numbers);
                }
                else if (InputStr == "d3")
                {
                    Console.WriteLine("Displaying numbers divisible by three: ");
                    DisplayList(DivisibleByThree(Numbers));

                }
                else if (InputStr == "f")
                {
                    Console.WriteLine("Displaying every fifth number: ");
                    DisplayList(Fifth(Numbers));

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
                if (num % 2 == 1 || num % 2 == -1)
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
        public static List<int> DivisibleByThree(List<int> num)
        { 
            List<int> divByThree = new List<int>();
            foreach (int number in num)
            {
   
                if(number != 0 && number%3 == 0)
                {
                    divByThree.Add(number);
                }
            }
            return divByThree;
         }   
        public static List<int> Fifth(List<int> num) {
            List<int> fives = new List<int>();
            for (int x=4; x<fives.Count; x+=5) {
                    fives.Add(num[x]);
            }
            return fives;
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
          
     
 

