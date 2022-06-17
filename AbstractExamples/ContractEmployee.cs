using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp.AbstractExamples
{
    class ContractEmployee : BaseEmployee
    {
      

        public int HourlyPay { get; set; }

        public int TotalHrs { get; set; }

        public override int GetMonthlySal()
        {
            return this.TotalHrs * this.HourlyPay;
        }
    }
}
