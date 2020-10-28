using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var element = new List<bool>(vals);
            if (element.Contains(false))
            { return true; }
            else
                return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers != null)
            {
                var elements = new List<int>(numbers);
                var oddsOdd = new List<int>();

                foreach (int odd in elements)
                {
                    if (odd % 2 != 0)
                    { oddsOdd.Add(odd); }
                }
                if (oddsOdd.Sum() % 2 != 0)
                { return true; }
                else
                    return false;
            }
             else
            { return false; }

            
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsNum = password.Any(char.IsNumber);
            bool containsUp = password.Any(char.IsUpper);
            bool containsLow = password.Any(char.IsLower);
            if (containsNum == true && containsUp == true && containsLow == true)
            { return true; }
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {

            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            { return 0; }
            else
            return dividend / divisor;

        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }
        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for (var i = 1; i < 100; i += 2)
                odds.Add(i);
            return odds.ToArray();


        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
                
            }



            }
    }
}
