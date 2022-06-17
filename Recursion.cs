using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
    class Recursion
    {

        //sum of digits 
        public int sum(int num)
        {
            if (num != 0)
            {
                return (num % 10 + sum(num / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}
