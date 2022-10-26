using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignments
{
    internal class q2
    {
        public class player
        {
            public string name { get; set; }
            public string country { get; set; }

            public player()
            {
                this.name = "None";
                this.country = "None";
            }
            public player(string name, string country)
            {
                this.name = name;
                this.country = country;
            }
            public void DisplayName()
            {
                Console.Write(this.name + " ");
            }
        }
        static void Main(string[] args)
        {
            List<player> l = new List<player>();
            l.Add(new player("akshaj", "india"));
            l.Add(new player("arun", "morrocco"));
            l.Add(new player("karan", "india"));
            l.Add(new player("manu", "india"));
            l.Add(new player("james", "usa"));
            l.Add(new player("lade", "morrocco"));
            l.Add(new player("tammy", "bulgaria"));
            l.Add(new player("bert", "tunisia"));
            l.Add(new player("james2", "india"));
            l.Add(new player("lad2e", "italy"));
            l.Add(new player("tammy2", "japan"));
            l.Add(new player("bert2", "morrocco"));
            var l1 = l.Take(l.Count / 2);
            var l2 = l.Skip(l.Count / 2);
            //USING METHODS
            var pairs = l1.SelectMany(a => l2.Select(b => new { a, b }));
            var pair2 = pairs.Where(i => i.a.country != i.b.country);
            foreach (var i in pair2)
            {
                Console.WriteLine(i.a.name + " From " + i.a.country + " vs " + i.b.name + " From " + i.b.country);
            }
            // USING QUERY
            var l3 = from a in l1
                     from b in l2
                     where a.country != b.country
                     select new[] { a, b };

            Console.WriteLine("\n\n\n\n");
            foreach (var i in l3)
            {

                Console.Write(i[0].name + " From " + i[0].country + " VS " + i[1].name + " From " + i[1].country);

                Console.WriteLine();
            }
        }
    }
}