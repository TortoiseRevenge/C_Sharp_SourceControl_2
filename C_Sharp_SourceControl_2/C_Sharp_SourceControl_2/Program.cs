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
        public void Fifth(List<int> num) {
            List<int> fives = new List<int>();
            for (int x=4; x<fives.Count; x+=5) {
                    fives.Add(num[x]);
            }
            Console.WriteLine(fives);
        }
    }
}
