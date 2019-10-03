using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Product
    {   
        //an encapsulated property of the class with the name "Name" of the type string
        public string Name { get; private set; }

        //constructor that takes in a name parameter and assigns the Name property using the parameter
        public Product(string name)
        {
            this.Name = name;
        }
    }
}
