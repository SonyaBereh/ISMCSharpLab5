using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double res = Math.Sqrt(50);
            int f = 49;
            for (int i = 1; i < 49; i++)
            {
                res = Math.Sqrt(res + f);
                f--;
            }
            Console.WriteLine("Result: " + res + ".");
        }
    }
}
