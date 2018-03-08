using System;
using System.Collections.Generic;
using System.Linq;

namespace project_euler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = 0;
            var num2 = 0;
            var palindrome = 0;
            for (var i = 100; i < 1000; i++)
            {
                for (var j = 100; j < 1000; j++)
                {
                    if (CheckPalindrome(BuildList(i, j)))
                    {
                        if ((i * j) > palindrome)
                        {
                            palindrome = i * j;
                            num1 = i;
                            num2 = j;
                        }
                    }
                }
            }

            Console.WriteLine($"Largest factors are {num1} and {num2}, {num1 * num2}");
        }
        public static List<int> BuildList(int num1, int num2)
        {
            List<int> factors = new List<int>();
            var number = num1 * num2;
            var x = number.ToString().Length;
            int newNum = 0;
            for (var i = 0; i < x; i++)
            {
                factors.Add(number % 10);
                newNum = number / 10;
                number = newNum;
            }

            return factors;
        }

        public static bool CheckPalindrome(List<int> factors)
        {
            List<int> factorsReverse = new List<int>();
            for (var i = 0; i < factors.Count; i++)
            {
                factorsReverse.Add(factors[factors.Count - i - 1]);
            }

            return factors.SequenceEqual(factorsReverse);
        }
    }
}

