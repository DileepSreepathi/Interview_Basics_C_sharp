using Interview_Basics_C_sharp.AbstractExamples;
using System;

namespace Interview_Basics_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Interview Prepations");

            // 1. DiffArrayTypes res = new DiffArrayTypes();
            // res.arrayTypes();
            //res.usingArrayList();

            // 2 -------------------------------

            //FullTimeEmployee fe= new FullTimeEmployee();
            //ContractEmployee ce = new ContractEmployee();
            //fe.Id = 101;
            //fe.Name = "Dileep";
            //fe.annualSal = 34000;

            ////---------
            //ce.Id = 102;
            //ce.Name = "Sreepathi";
            //ce.TotalHrs = 45;
            //ce.HourlyPay = 30;

            //BaseEmployee.TestMethod();
            //Console.WriteLine("Full Time Employee  " + fe.GetEmployeeDetails() + "  "+ fe.GetMonthlySal() + "  " + fe.GetAddress());
            //Console.WriteLine("Full Time Employee  " + ce.GetEmployeeDetails() + "  " + ce.GetMonthlySal());

            // 4. constructor for the abstract class--------------------------
            //DemoCustomer dc = new DemoCustomer();
            //Console.WriteLine(dc.ID);

            //5.Virtual methods in Abstract class--------------

            //SomeClass sc = new SomeClass();
            //sc.Abstractmethod();

            //OtherClass oc = new OtherClass();
            //oc.Abstractmethod();


            //6>Delegates---------------

            //Delegate is a type sage pointer to function

           
              
            HelloFuntionDelegate del = new HelloFuntionDelegate(Hello);
            del("From the deleteate");

            Producer p = new Producer();
           // Producer p1 = new Customer();  child = new parent ()  // invalid 
            p.Method1();
            Program pp = new Program();
            pp.Method();
            
            
        }

        public string Method()
        {
            try
            {
                //  return "try";
                Console.WriteLine("try block");
            }
            catch {
                //return "catch";
                Console.WriteLine("catch block");
            }
            finally{
                return "finally";  //it is illegal to write the return in the finally blocl because 2 returns will be there in the function 
            }
            return "";
        }
        public static void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
        public delegate void HelloFuntionDelegate(string Message);

        public class Customer
        {
            public virtual void Method1()
            {
                Console.WriteLine("From the Customer class");
            }

            
        }

        public class Producer:Customer
        {
            public override void Method1()
            {
                Console.WriteLine("From the Producer class");
            }
        }
    }
}
