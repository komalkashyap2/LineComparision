using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates3
{
      class Program
    {
        static void Main(string[] args)
        {
            short len1 = 101;
            short len2 = 103;

            Console.WriteLine("length 1" + len1);
            Console.WriteLine("length 2" + len2);
            Console.WriteLine("value of two length+" + len1.CompareTo(len2));
        }
    }
}
