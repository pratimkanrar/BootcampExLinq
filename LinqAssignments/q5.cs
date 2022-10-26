using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignments
{
    internal class q5
    {
        class Item
        {
            public string itemName { get; set; }
            public double price { get; set; }
            public Item(string itemName, double price)
            {
                this.itemName = itemName;
                this.price = price;
            }
        }
        public static void Main()
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
            List<Item> items = new List<Item>();
            items.Add(new Item("paste", 10));
            items.Add(new Item("pin", 1));
            items.Add(new Item("car", 100000));
            items.Add(new Item("pen", 5));
            items.Add(new Item("box", 55));
            items.Add(new Item("crayon", 12));
            items.Add(new Item("basket", 75));
            items.Add(new Item("roll", 9));
            var q = from o in orders
                    join i in items on o.itemName equals i.itemName

                    select new
                    {
                        OrderId = o.orderId,
                        itemName = o.itemName,
                        orderDate = o.orderDate,
                        totalPrice = o.quantity * i.price
                    };
            var q2 = from o in q
                     group o by o.orderDate.Month into newG
                     from b in newG
                     orderby b.orderDate descending
                     select b;

            Console.WriteLine($"OrderId  itemName orderDate totalPrice");
            foreach (var i in q)
            {
                Console.WriteLine($"{i.OrderId}  {i.itemName} {i.orderDate} {i.totalPrice}");
            }
        }
    }
}