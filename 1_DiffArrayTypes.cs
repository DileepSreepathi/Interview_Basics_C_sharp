using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
    //Can you store the different types in the C# array : yes it is possible to store 
    class DiffArrayTypes
    {
        public string Name { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return this.Name + "   " +this.id;
        }
        public void arrayTypes()
        {
            object[] input = new object[3];
            input[0] = 3;
            input[1] = "string";
            DiffArrayTypes diff = new DiffArrayTypes();
            diff.id = 99;
            diff.Name = "Dileep";
            input[2] = diff;

            foreach (var i in input)
            {
                Console.WriteLine(i);
            }
            
        }

        public void usingArrayList()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("string");
            DiffArrayTypes diff = new DiffArrayTypes();
            diff.id = 99;
            diff.Name = "Dileep";
            array.Add(diff);
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }

        }
        
        

    }
}
