namespace LinqAssignments
{
    internal class q1
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
                l.Add(rnd.Next(95, 1005));
            Console.WriteLine("Original array : ");
            foreach (int i in l)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Cubed array which is >100 and <1000 : ");
            //Linq Operations
            var cube = l.Where(n => n < 1000 && n > 100).Select(n => n * n * n);
            foreach (int i in cube)
            {
                Console.Write(i + " ");
            }
        }
    }
}