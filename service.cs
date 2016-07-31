using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCF_Demo
{
    class service : iservice
    {

        public service()
        {
            Console.WriteLine("Service created!");
        }

        public bool Login(string userId, string password)
        {
            if (userId == "mohsin" && password == "123") return true;
            return false;
        }

        public List<Order> getOrders(string city)
        {
            System.Threading.Thread.Sleep(10000);
            List<Order> orders = new List<Order>();
            orders.Add(new Order {OrderId = "OR101", CustomerId = "C1201", OrderCity = "Pune" });
            orders.Add(new Order { OrderId = "OR987", CustomerId = "C5403", OrderCity = "Sagar" });
            orders.Add(new Order { OrderId = "OR161", CustomerId = "C2456", OrderCity = "Bhopal" });
            orders.Add(new Order { OrderId = "OR209", CustomerId = "C1204", OrderCity = "Damoh" });
            orders.Add(new Order { OrderId = "OR109", CustomerId = "C3210", OrderCity = "Sagar" });
            var result = (from o in orders
                          where o.OrderCity == city
                          select orders);
            return orders;
        }
    }
}
