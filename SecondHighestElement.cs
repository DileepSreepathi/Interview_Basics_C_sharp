using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
    class SecondHighestElement
    {
        public void method()
        {

            int[] myArray = new int[] { 0, 1, 2, 3, 13, 8, 5 };
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }

            System.Console.WriteLine(second);
        }

        //third largest integer
        internal static void FindthirdLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2 && i != max1)
                {
                    max3 = max2;
                    max2 = i;
                }
                else if (i > max3 && i != max2 && i != max1)
                {
                    max3 = i;
                }
            }
            Console.WriteLine(max3); ;
        }
    }
}
