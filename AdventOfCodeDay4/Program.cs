using System;
using System.Collections.Generic;
using System.Linq;

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
            //var stringQuery = s.GroupBy(x => x).Where(g => g.Count() > 2).Select(y => y.Count()).ToList();
            foreach (string s in rawListOfPasswords)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Number of elements For Part 1: " + rawListOfPasswords.Count);

            List<string> part2ListOfPasswords = new List<string>(rawListOfPasswords);

            foreach (string s in rawListOfPasswords)
            {
                var stringQuery = s.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Count()).ToList();
                
                foreach (var i in stringQuery)
                {
                    if (stringQuery.Count > 1)
                    {
                        if (stringQuery[0] > 2 && stringQuery[1] > 2)
                        {
                            Console.WriteLine("removing: " + s);
                            part2ListOfPasswords.Remove(s);
                        }

                    }
                    else if (stringQuery[0] > 2)
                    {
                        Console.WriteLine("removing: " + s);
                        part2ListOfPasswords.Remove(s);
                    }
                }
                
            }
            foreach (var i in part2ListOfPasswords)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Number of elements For Part 2: " + part2ListOfPasswords.Count);

            //string test = "699999";
            //List<char> charList = new List<char>()
            //{
            //    '4',
            //    '4',
            //    '3',
            //    '5',
            //    '5',
            //    '5'
            //};
            //var query = charList.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
            //var query3 = charList.GroupBy(x => x).Where(g => g.Count() > 2).Select(y => y.Count()).ToList();
            //var query2 = charList.GroupBy(x => x)
            //  .Where(g => g.Count() > 1)
            //  .Select(y => new { Element = y.Key, Counter = y.Count() })
            //  .ToList();
            //foreach (var i in query)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (var i in query2)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (var i in query3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(query3[0]);
            //foreach (char c in charList)
            //{
            //    if (!charList.Add(c))
            //    {

            //    }
            //}
        }
    }
}
