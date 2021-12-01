using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates1
{
    public class coordinates2
    {
        static void Main(string[] args)
        {
            string x1 = "x1";
            string x2 = "x1";
            Console.WriteLine(x1 == x2);
            Console.WriteLine(x1.Equals(x2));
            Console.WriteLine(x1.GetHashCode() + "," + x2.GetHashCode());

            string y1 = "x1";
            Console.WriteLine(x1 == y1);
            Console.WriteLine(x1.Equals(y1));
            Console.WriteLine(x1.GetHashCode() + "," + y1.GetHashCode());

            string y2 = "y1";
            Console.WriteLine(x1 == y2);
            Console.WriteLine(x1.Equals(y2));
            Console.WriteLine(x1.GetHashCode() + "," + y2.GetHashCode());
            Console.ReadLine();
        }
    }
}