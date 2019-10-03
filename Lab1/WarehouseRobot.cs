using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //abstract class because it have an abstract method 
    abstract class WarehouseRobot
    {
        //an encapsulated property of the class with the name "Name" of the type string
        public string Name { get; private set; }

        //constructor that takes in a name parameter and assigns the Name property using the parameter
        public WarehouseRobot(string name)
        {
            this.Name = name;
        }

        //abstract method so a body don't need to be implemented (because we don't want to implement a general WarehouseRobot)
        public abstract void ProcessOrder(Order orderToProcess);
    }
}
