// C# program to find the closest
// Palindrome number

//O(n*log(n)) Time complexity
using System;

class GFG {

	// Function to check Palindrome
	public static bool isPalindrome(string s)
	{
		int left = 0;
		int right = s.Length - 1;

		while (left < right) {
			if (s[left] != s[right]) {
				return false;
			}
			left++;
			right--;
		}
		return true;
	}

	// Function return closest Palindrome number
	public static void closestPalindrome(int num)
	{

		// Case1 : largest palindrome number
		// which is smaller to given number
		int RPNum = num - 1;

		while (isPalindrome(RPNum.ToString()) == false) {
			RPNum--;
		}

		// Case 2 : smallest palindrome number
		// which is greater than given number
		int SPNum = num + 1;

		while (isPalindrome(SPNum.ToString()) == false) {
			SPNum++;
		}

		// Check absolute difference
		if (Math.Abs(num - SPNum) < Math.Abs(num - RPNum)) {
			Console.WriteLine(SPNum);
		}
		else
			Console.WriteLine(RPNum);
	}

	// Driver code
	public static void Main(string[] args)
	{
		int n = 121;

		closestPalindrome(n);
	}
}

// This code is contributed by ukasp

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int closestPalindrome = FindClosestPalindrome(number);
        int difference = Math.Abs(number - closestPalindrome);

        Console.WriteLine($"The closest palindrome number is {closestPalindrome}.");
        Console.WriteLine($"The absolute difference is {difference}.");
    }

    static int FindClosestPalindrome(int number)
    {
        if (IsPalindrome(number))
            return number;

        int smallerPalindrome = number - 1;
        int largerPalindrome = number + 1;

        while (true)
        {
            if (IsPalindrome(smallerPalindrome))
                return smallerPalindrome;

            if (IsPalindrome(largerPalindrome))
                return largerPalindrome;

            smallerPalindrome--;
            largerPalindrome++;
        }
    }

    static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int left = 0;
        int right = numberString.Length - 1;

        while (left < right)
        {
            if (numberString[left] != numberString[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}


///best approvach 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int closestPalindrome = FindClosestPalindrome(number);
        int difference = Math.Abs(number - closestPalindrome);

        Console.WriteLine($"The closest palindrome number is {closestPalindrome}.");
        Console.WriteLine($"The absolute difference is {difference}.");
    }

    static int FindClosestPalindrome(int number)
    {
        if (IsPalindrome(number))
            return number;

        int smallerPalindrome = GetSmallerPalindrome(number);
        int largerPalindrome = GetLargerPalindrome(number);

        int smallerDifference = Math.Abs(number - smallerPalindrome);
        int largerDifference = Math.Abs(number - largerPalindrome);

        return smallerDifference < largerDifference ? smallerPalindrome : largerPalindrome;
    }

    static int GetSmallerPalindrome(int number)
    {
        string numberString = number.ToString();
        char[] digits = numberString.ToCharArray();

        int mid = digits.Length / 2;
        bool isOddLength = digits.Length % 2 != 0;

        bool shouldPropagateLeft = false;

        for (int i = mid - 1; i >= 0; i--)
        {
            if (shouldPropagateLeft)
                digits[i] = '9';

            if (digits[i] > digits[digits.Length - 1 - i])
                shouldPropagateLeft = false;

            digits[digits.Length - 1 - i] = digits[i];
        }

        return int.Parse(new string(digits));
    }

    static int GetLargerPalindrome(int number)
    {
        string numberString = number.ToString();
        char[] digits = numberString.ToCharArray();

        int mid = digits.Length / 2;
        bool isOddLength = digits.Length % 2 != 0;

        bool shouldPropagateLeft = false;

        for (int i = mid - 1; i >= 0; i--)
        {
            if (shouldPropagateLeft)
                digits[i] = '0';

            if (digits[i] < digits[digits.Length - 1 - i])
                shouldPropagateLeft = true;

            digits[digits.Length - 1 - i] = digits[i];
        }

        return int.Parse(new string(digits));
    }

    static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int left = 0;
        int right = numberString.Length - 1;

        while (left < right)
        {
            if (numberString[left] != numberString[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}

