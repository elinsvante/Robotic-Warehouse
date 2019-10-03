using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //class inherits from the class WarehouseRobot and is not an abstract class itself because it provides a body for an abstract method in the base class
    class DispatchRobot : WarehouseRobot
    {

        //constructor that takes a name and pass the name on to it's base class constructor (Constructor chaining)
        public DispatchRobot(string name) : base(name)
        {
        }

        //overrides the ProcessOrder method in the base class and gives it a body that changes the State property of the order object
        public override void ProcessOrder(Order orderToProcess)
        {
            orderToProcess.State = "Dispatched";
        }
    }
}
