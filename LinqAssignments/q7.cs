using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignments
{
    internal class q7
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                list.Add(random.Next(1, 100));
            var q = list.Where(x => x % 2 == 0).Count();
            var q1 = list.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(q);
            foreach (var i in q1)
            {
                Console.Write(i + " ");
            }
        }
    }
}