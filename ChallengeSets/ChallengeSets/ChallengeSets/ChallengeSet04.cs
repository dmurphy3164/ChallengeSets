using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers != null)
            {
                var elements = new List<int>(numbers);
                var evens = new List<int>();
                var odds = new List<int>();
                foreach (int elem in elements)
                {
                    if (elem % 2 != 0)
                    { odds.Add(elem); }
                    else if (elem % 2 == 0)
                    { evens.Add(elem); }
                }
                return
                    evens.Sum() - odds.Sum();
                }
            else
                return 0;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {


            var array1 = new int[] { str1.Count(), str2.Count(), str3.Count(), str4.Count() };
            return array1.Min();
            
            
            





        }




                

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
           
                var array1 = new int[] { number1, number2, number3, number4 };
                return array1.Min();
                      
                
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            Business truecode = new Business();
            biz.Name = "TrueCoders";


        }
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 != null || sideLength2 != null || sideLength3 != null)
            {
                
                if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
                { return true; }
                else { return false; }
            }
            else { return false; }
        }

        public bool IsStringANumber(string input)
        {
            if (input != null)
            {
                int res;
                decimal desRes;
                if (int.TryParse(input, out res) == false)
                { return decimal.TryParse(input, out desRes); }

                else
                    return true;
                

            }
            else
            { return false; }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var elem = new List<int>();
            var nullElem = new List<int>();
            foreach (var element in objs)
            {
                if (element != null)
                { elem.Add(1); }
                else
                    nullElem.Add(1);
            }
            if (nullElem.Count() > elem.Count())
            { return true; }
            else
            { return false; }
        
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers != null)
                { var newNums = new List<int>();
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        newNums.Add(num);
                    }

                }
                if (newNums.Count() != 0)
                { return newNums.Average(); }
                else
                { return 0; }
            }
            else
                return 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            { throw new ArgumentOutOfRangeException();  }
            else
            {
                if (number != 0)
                {
                    int ans = 1;
                    while (number != 1)
                    {
                        ans = ans * number;
                        number = number - 1;



                    }
                    return ans;

                }

                else { return 1; }
            }
        }
    }
}
