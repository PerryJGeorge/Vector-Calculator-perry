using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(1, 2, 3);
            Vector test2 = new Vector(-1, 2, -3);
            Vector test3 = new Vector(7, 4, 0);

            // This should be 0, 4, 0
            Console.WriteLine(Vector.Add(test1, test2));
            Console.WriteLine(test1.GetMagnitude());
            Console.WriteLine(test3.GetDirection());
            Console.WriteLine(Vector.Normalize(test3));
        }
    }
}
