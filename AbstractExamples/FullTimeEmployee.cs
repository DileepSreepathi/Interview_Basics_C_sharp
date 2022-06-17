using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp.AbstractExamples
{
    class FullTimeEmployee : BaseEmployee
    {
      

        public int annualSal { get; set; }

        public override string GetAddress()
        {
            return "getAddressChildClass";
        }

        public override int GetMonthlySal()
        {
            return this.annualSal / 12;
        }
    }
}
