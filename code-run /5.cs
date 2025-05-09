using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            double z = b * b - 4 * a * c;
            
            if (z == 0)
            {
                double x = -b / (2.0 * a);
                Console.WriteLine(x);
            }
            else
            {
                double sqrtD = Math.Sqrt(z);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                Console.WriteLine($"{x1} {x2}");
            }
        }
    }
}
