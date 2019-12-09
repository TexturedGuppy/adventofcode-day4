using System;
using System.Collections.Generic;

namespace AdventOfCodeDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit = 256310;
            int upperLimit = 732736;

            List<string> rawListOfPasswords = new List<string>();

            for (int i = lowerLimit ; i <= upperLimit; i++)
            {
                string s = i.ToString();
                int digitsIncreaseCounter = 0;
                bool isIncreasing;
                bool isAdjacent = false;

                for (int j = 0; j < s.Length - 1; j++)
                {
                    int test = Convert.ToInt32(s.Substring(j));
                    if (Convert.ToInt32(s[j]) <= Convert.ToInt32(s[j+1]))
                    {
                        digitsIncreaseCounter++;
                    }
                    for (int k = 0; k < s.Length -1; k++)
                    {
                        if (s[k] == s[k + 1])
                        {
                            isAdjacent = true;
                        }
                    }
                    if (digitsIncreaseCounter == s.Length - 1 && isAdjacent)
                    {
                        rawListOfPasswords.Add(s);
                    }
                }
            }

            foreach (string s in rawListOfPasswords)
            {

            }

            foreach(string s in rawListOfPasswords)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Number of elements: " + rawListOfPasswords.Count);

        }
    }
}
