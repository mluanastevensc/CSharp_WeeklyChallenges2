using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           return vals.Count() % 2==0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number %2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num %2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null|| !numbers.Any())
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str2.Length < str1.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i =0; i< numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;

        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;
            if(numbers == null)
            {
                return 0;
            }
            for (int i = 0; i< numbers.Length; i++)
            {
               if( numbers[i] % 2 == 0)
                {
                   sum += numbers[i];
                }

            }
            
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            {
                var sums = 0;
                if (numbers == null)
                {
                    return false;
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        sums += numbers[i];
                    }
                }
                if (sums % 2 == 0)
                {
                    return false;
                }
                return true;
            }


        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
        

            long counter = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    counter++;
                }
            }

            return counter;
            
        }
    }
}
