using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates two list. The first list is called "robotList" and holds objects of the type WarehouesRobots.
            //The second list is called "orderList" and holds objects of the type Orders.
            List<WarehouseRobot> robotList = new List<WarehouseRobot>();
            List<Order> orderList = new List<Order>();

            //Objects (robots) are initialized and added to the robotList.
            PackingRobot packingRobot = new PackingRobot("PackingRobot");
            robotList.Add(packingRobot);
            DispatchRobot dispatchRobot = new DispatchRobot("DispatchRobot");
            robotList.Add(dispatchRobot);
            DeliveryRobot deliveryRobot = new DeliveryRobot("DeliveryRobot");
            robotList.Add(deliveryRobot);

            //A while loop that runs infinitely until you stop it
            while (true)
            {   
                //The user gets options to choose what to do
                Console.WriteLine("Welcome to the warehouse management. Choose one of the following:");
                Console.WriteLine("1. Add a new order");
                Console.WriteLine("2. Display status of all orders");
                Console.WriteLine("3. Process the last order by each robot");
                Console.WriteLine("4. Exit the program");

                //Declare a variable with the name "key" of the type "var" where the user input is stored
                var key = Console.ReadLine();
                
                //switch is used to compare the key variable with the different cases to choose the right thing to do
                switch (key) {
                    //if user entered 1 on the keybord
                    case "1":
                        //lets the user enter the product to order, store the input in the variable "inputProduct"
                        Console.WriteLine("Type the name of the product to be ordered: ");
                        var inputProduct = Console.ReadLine();
                        //creating a new product object with the user input, a new order with the initialized product object and add it to orderList.
                        Product newProduct = new Product(inputProduct);
                        Order newOrder = new Order(newProduct);
                        orderList.Add(newOrder);
                        break;
                    case "2":
                        //display the ordered products and their order status by looping through the orderList
                        foreach (Order item in orderList)
                        {
                            Console.WriteLine(item.OrderedProduct.Name + ": " + item.State);
                        }
                        break;
                    case "3":
                        //last order added in the orderList is put in the variable "lastOrder"
                        //a loop calls all the robots in the robotList to work on the last order
                        var lastOrder = orderList[orderList.Count - 1];
                        foreach (var robot in robotList)
                        {
                            robot.ProcessOrder(lastOrder);
                        }
                        break;
                    case "4":
                        //exit the program and end the main method
                        return;           
            }
            }
        }
    }
}
