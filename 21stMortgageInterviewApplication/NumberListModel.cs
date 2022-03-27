using System;
using System.Collections.Generic;
using System.Linq;

namespace _21stMortgageInterviewApplication
{
    public class NumberListModel
    {
        public List<int> Numbers { get; set; }

        public NumberListModel()
        {
            Numbers = new List<int>();
        }

        public string FromString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            try
            {
                Numbers = input.Split(',').Select(int.Parse).ToList();
            }
            catch (Exception e)
            {
                return "Enter a valid list of numbers separated by commas";
            }

            return null;
        }

        public void AddNumber(int number)
        {
            Numbers.Add(number);
        }

        public void RemoveNumber(int number)
        {
            Numbers.Remove(number);
        }

        public void RemoveAllNumbers()
        {
            Numbers.Clear();
        }

        public int GetNumberCount()
        {
            return Numbers.Count;
        }

        public int GetLargestNumber()
        {
            return Numbers.Max();
        }

        public int GetSmallestNumber()
        {
            return Numbers.Min();
        }

        public int GetSumOfEvenNumbers()
        {
            return Numbers.Where(x => x % 2 == 0).Sum();
        }

        public int GetSumOfOddNumbers()
        {
            return Numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetSumOfAllNumbers()
        {
            return Numbers.Sum();
        }

    }
}
