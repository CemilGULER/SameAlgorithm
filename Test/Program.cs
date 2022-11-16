﻿using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SecondMaxNumber(new int[] { 8,5,8,4,3,5,9 }));
            Console.WriteLine(IsAccordion("BApT6M7JbmCtHBQaT3mp&pm3TaQBHtCmbJ7M6TpAB"));
            Console.WriteLine(IsValidBrackets("{([([{}])])}"));
            Console.WriteLine(IsPerfectNumber(28));

        }

        static int SecondMaxNumber(int [] nums)
        {
            if (nums.Length < 1 || nums.Length > 100)
                throw new Exception("invalid array");
            int i;
            int j;
            int tempValue;

            for (i = (nums.Length - 1); i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        tempValue = nums[j - 1];
                        nums[j - 1] = nums[j];
                        nums[j] = tempValue;
                    }
                }
            }
            return nums[nums.Length-2];

        }
        static bool IsAccordion (string value)
        {
            if (value.Length%2==0)
                throw new Exception("invalid value");
            var valueMiddlePoint = (value.Length-1)/2;
            for (int i = 0; i < valueMiddlePoint; i++)
            {
                if (value[i] != value[value.Length - 1-i])
                    return false;

            }
            return true;

        }
        static bool IsValidBrackets(string value)
        {
            if (value.Length % 2 != 0)
                throw new Exception("invalid value");
            var valueMiddlePoint =value.Length / 2;
            for (int i = 0; i < valueMiddlePoint; i++)
            {                
                if (ValidatePerBraces(value[i], value[value.Length - 1 - i]) == false)
                    return false;               

            }
            return true;

        }
        static bool IsPerfectNumber(int nums)
        {
            var total = 0;
            for (int i = 1; i < nums; i++)
            {
                if (nums % i == 0)
                {
                    total += i;
                }
            }
            if (nums == total)
            {
                return true;
            }
            else
            {
               return false;
            }

        }
        static bool ValidatePerBraces(char a, char b)
        {

            return a == '(' && b == ')' || a == '[' && b == ']' || a == '{' && b == '}';

        }


    }
}
