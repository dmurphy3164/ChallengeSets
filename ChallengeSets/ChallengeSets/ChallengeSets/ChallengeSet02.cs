using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (char.IsLetter(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
             var elements = new List<string>(vals);
            if (elements.Count() % 2 == 0)
            { return true; }
            else if (elements.Count() == 0)
                    { return true; }

             else

            { return false; }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) { return true; } else { return false; }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0) { return false; }
            else { return true; }
           
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null)
            {
                var collection = new List<double>(numbers);
                if (collection.Count() != 0)
                {
                    double sumMinMax = collection.Min() + collection.Max();
                    return sumMinMax;
                }
                 else
                { return 0; }
             }
            
            else
            { return 0; }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length >= str2.Length)
            { return str2.Length; } 
            else if (str1.Length < str2.Length)
            { return str1.Length; } 
            else 
            { return str1.Length; }
        }

        public int Sum(int[] numbers)
        {
            if (numbers != null)
            {
                var elements = new List<int>(numbers);
                if (numbers != null)
                    return elements.Sum();
                else
                    return 0;
            }
            else
                return 0;
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers != null)
            {
                var elements = new List<int>(numbers);
                var sumEven = new List<int>();
                foreach (int num in elements)
                {
                    if (num % 2 == 0)
                        sumEven.Add(num);
                }
                return sumEven.Sum();
            }
            else
            { return 0; }
        }   

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null)
            {
                var elements = new List<int>(numbers);
                if (elements.Sum() % 2 == 0)
                { return false; }
                else { return true; }
            }
            else
            { return false; }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
              var countPosOdds = new List<long>();
             for (long i = number; i > 0; i--)
            {if (i % 2 == 0)
                { countPosOdds.Add(i); }  
                        }
            return countPosOdds.Count();
        }     
    }
}
