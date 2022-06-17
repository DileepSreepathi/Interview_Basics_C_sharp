using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
    public abstract class CustomerAbstract
    {
        private Guid id;

        public Guid ID {
            get {
                return this.id;
            }
        }
        public CustomerAbstract()
        {
            this.id = Guid.NewGuid();
        }

    }

    public class DemoCustomer : CustomerAbstract
    {
        
    }
}
