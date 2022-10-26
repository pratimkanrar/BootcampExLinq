using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignments
{
    internal class q4
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

                    group a by a.orderDate.Month into newG
                    from b in newG
                    orderby b.orderDate descending
                    select b;

            //methord
            var q2 = orders.GroupBy(a => a.orderDate.Month).Select(g => g.OrderByDescending(s => s.orderDate)).SelectMany(group => group);

            foreach (var i in q2)
            {

                i.display();
            }
        }
    }
}