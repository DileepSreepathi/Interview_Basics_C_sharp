public class MissingNumber
{
    public static void Main()
    {
        int[] arr = {0, 1, 2, 4, 5 };
        bool[] temp= new bool[arr.Length+1];

        System.Console.WriteLine(temp);
        for (int i = 0; i < arr.Length; i++)
        {
            int index = arr[i];
            temp[i] = true;
        }
        int resultElement = -1;
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] == false)
            {
                resultElement = i;
                break;
            }
        }
        Console.WriteLine(resultElement);
        //0, 1, 3, 4, 5
        int n = arr.Length;
        //sum if n natural numbers
        int sumN = (n * (n + 1)) / 2;

        System.Console.WriteLine(sumN);
        int arrSum = arr.Sum();
        Console.WriteLine(arrSum);
        // Time : O(N) , spce O(1)
        int missingNo = sumN - arrSum;
        Console.WriteLine(missingNo);
    }
}
