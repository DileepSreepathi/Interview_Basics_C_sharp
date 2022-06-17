using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp.AbstractExamples
{
   abstract class BaseEmployee
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public  string GetEmployeeDetails()
        {
            return this.Id + "  " + this.Name;
        }

        public static void TestMethod()
        {
            Console.WriteLine("No dependency on sub classes ");
        }
        public virtual string GetAddress()
        {
            return "addrss";
        }

        //not implementing this in the base class 
        public abstract int GetMonthlySal();
    }
}
