using System;
using System.Collections.Generic;
using System.Linq;

namespace weeklyChallenges06
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
                return false;
            foreach (string item in words)
            {
                if (ignoreCase == true && item.ToLower() == word)
                    return true;
            }
            if (words.Contains(word))
                return true;
            return false;
            
            
        }



        public bool IsPrimeNumber(int num)
        {
            int n, i;
            n = num / 2;
            for (i = 2; i <= n ; i++)
            {
                if (num % i == 0)
                    return false;
            }
            if (num <= 1)
                return false;
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {


            for (int i = str.Length-1; i >= 0 ; i--)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        count++;
                    if (count > 1)
                        break;
                }
                if (count ==1)
                    return i;
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int newCount;
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                newCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        newCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (newCount > counter)
                {
                    counter = newCount;
                }
            }
            return counter;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            
            if (elements == null || n<1)
                return new double[0];
            return elements.Where((x, i) => (i + 1) % n == 0).ToArray();
            
            
        }
    }
}


