using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates1
{
      public class Program
    {
         
        static void Main(string[] args)
        {
            //variables
            int x1, x2, y1, y2;
            Console.WriteLine("welcome");
             
            Console.WriteLine("give the coordinates");

            x1 = Convert.ToInt16(Console.ReadLine());
            //x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            var result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            int sum = x1 + x2 + y1 + y2;
            Console.WriteLine("length: ");
            Console.WriteLine(sum);
        }
    }
}
