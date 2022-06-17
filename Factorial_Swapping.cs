using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
    class Factorial_Swapping
    {

        public void Fact()
        {

            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();
        }

        //swap without using third variable 
        public void swap()
        {
            {
                int first, second;
                first = 100;
                second = 200;
                first = first + second;
                second = first - second;
                first = first - second;
                Console.WriteLine(first.ToString());
                Console.WriteLine(second.ToString());
                Console.ReadLine();
            }
        }
    }
}
