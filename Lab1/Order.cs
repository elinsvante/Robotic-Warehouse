using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Order
    {
        //two properties of the class - one named "OrderedProduct" with the type Product and one named "State" with the type string
        public Product OrderedProduct { get; set; }
        public string State { get; set; }

        //constructor assignts the OrderProduct property to the parameter with type Product and sets the State property to "Ordered" 
        public Order(Product product)
        {
            OrderedProduct = product;
            State = "Ordered";
        }
    }
}
