using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
    class RemoveDuplicatesInString_otherPrograms
    {
        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }


        //find the sub strings 

        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }

        //find the sum of digits 
        internal static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }

        //remove duplicate in an array 

        public static class ArrayDuplicates
        {
            //Dictionary solution
            public static bool ContainsDuplicates(params int[] x)
            {
                Dictionary<int, int> d = new Dictionary<int, int>();
                foreach (int i in x)
                {
                    if (d.ContainsKey(i))
                        return true;
                    else
                        d.Add(i, 1);
                }
                return false;
            }
        }

        //sum of integers in an array to the target array

        public static bool TwoIntegersSumToTarget(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (i != k)
                    {
                        int sum = arr[i] + arr[k];
                        if (sum == target)
                            return true;
                    }
                }
            }
            return false;
        }

        ///Complexity: O(n)  
        public static char FirstNonRepeatedCharInString2(string str)
        {
            Dictionary<char, int> l1 = new Dictionary<char, int>();
            int temp = 0;
            foreach (char c in str.ToCharArray())
            {
                if (l1.Keys.Contains(c))
                {
                    temp = l1[c];
                    l1[c] = temp + 1;
                    continue;
                }
                l1.Add(c, 1);
            }
            if (l1.Values.Contains(1))
            {
                return l1.First(x => x.Value == 1).Key;
            }
            return ' ';
        }

        ///Complexity: O(n^2)  

        public static char FirstNonRepeatedCharInString(string str)
        {
            int i, j;
            bool isRepeted = false;
            char[] chars = str.ToCharArray();
            for (i = 0; i < chars.Length; i++)
            {
                isRepeted = false;
                for (j = 0; j < chars.Length; j++)
                {
                    if ((i != j) && (chars[i] == chars[j]))
                    {
                        isRepeted = true;
                        break;
                    }
                }
                if (isRepeted == false)
                {
                    return chars[i];
                }
            }
            return ' ';
        }

        //How do you check if a string contains only digits? in c#
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }


        //revers a string using the loop without inbuilt functions
        internal static void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
    }
}
