using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
    class MoveZerosToEnd
    {
        static void moveZerosToEnd(int[] arr, int n)
        {
            // Count of non-zero elements 
            int count = 0;
            int temp;

            // Traverse the array. If arr[i] is 
            // non-zero, then swap the element at 
            // index 'count' with the element at 
            // index 'i' 
            for (int i = 0; i < n; i++)
            {
                if ((arr[i] != 0))
                {
                    temp = arr[count];
                    arr[count] = arr[i];
                    arr[i] = temp;
                    count = count + 1;
                }
            }
        }
    }
}
