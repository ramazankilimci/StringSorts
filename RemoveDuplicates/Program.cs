using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter test cases : ");
            int testCases = Convert.ToInt32(Console.ReadLine());

            while (testCases > 0)
            {
                string str = Console.ReadLine();
                char[] charTest = str.ToCharArray();
                List<char> myList = new List<char>();
                foreach ( char char1 in charTest)
                {
                    if (!myList.Contains(char1))
                    {
                        myList.Add(char1);
                        Console.Write(char1);
                    }
                }
                
                testCases--;
            }

        }
    }
}
