using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Coding_Exercise
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Mapping of distinct words and their counts
            Dictionary<string, uint> wordsDictionary = new Dictionary<string, uint>();

            // Words that do not begin with digit. Apostrophe and dash will be counted as part of the word.
            Regex regex = new Regex(@"\w(?<!\d)[\w'-]*", RegexOptions.IgnoreCase);

            foreach (Match item in regex.Matches(input))
            {
                // Increase counter if the word already exists
                if (wordsDictionary.ContainsKey(item.Value))
                {
                    wordsDictionary[item.Value]++;
                }
                // Add otherwise
                else
                {
                    wordsDictionary.Add(item.Value, 1);
                }
            }

            // Show result
            foreach (var item in wordsDictionary.Keys)
            {
                Console.WriteLine(item + " - " + wordsDictionary[item]);
            }
        }
    }
}
