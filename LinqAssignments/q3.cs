using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignments
{
    public class Order
    {
        public string orderId { get; set; }
        public string itemName { get; set; }
        public DateOnly orderDate { get; set; }

        public int quantity { get; set; }

        public Order(string orderId, string itemName, DateOnly orderDate, int quantity)
        {
            this.orderId = orderId;
            this.itemName = itemName;
            this.orderDate = orderDate;
            this.quantity = quantity;
        }
        public void display()
        {
            Console.WriteLine($"Order Id : {orderId} Item Name : {itemName} Order date : {orderDate} Quantity : {quantity}");
        }
    }
    internal class q3
    {
        static void Main()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order("1", "paste", new DateOnly(2022, 1, 22), 100));
            orders.Add(new Order("2", "pin", new DateOnly(2022, 4, 12), 103));
            orders.Add(new Order("3", "car", new DateOnly(2022, 1, 1), 1));
            orders.Add(new Order("4", "pen", new DateOnly(2022, 2, 8), 12));
            orders.Add(new Order("5", "box", new DateOnly(2022, 11, 10), 43));
            orders.Add(new Order("6", "crayon", new DateOnly(2022, 12, 11), 34));
            orders.Add(new Order("7", "basket", new DateOnly(2022, 12, 5), 456));
            orders.Add(new Order("8", "roll", new DateOnly(2022, 1, 1), 234));
            //Query
            var q = from a in orders
                    orderby a.quantity descending
                    orderby a.orderDate descending
                    select a;
            //methord
            var q2 = orders.OrderByDescending(a => a.quantity).ThenByDescending(a => a.orderDate);
            foreach (var i in q)
            {
                i.display();
            }
        }
    }
}