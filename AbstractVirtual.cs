using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
   public abstract class AbstractVirtual
    {
        public virtual void Abstractmethod()
        {
            Console.WriteLine("Default Implemetation");
        
        }
    }

    public class SomeClass : AbstractVirtual
    { 
        //here using the default implementaion    
    }

    public class OtherClass : AbstractVirtual
    {
        //here using overdie with new implementaion

        public override void Abstractmethod()
        {
            Console.WriteLine("my own implementaiton");
        }
    }
}
