using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = double.Parse(Console.ReadLine());


            double z, q;
            z = (x + (2 + y) / (x * x)) / (y + 1 / (Math.Sqrt(x * x + 10)));
            q = 2.8 * Math.Sin(x) + Math.Abs(y);
            if ((y + 1 / (Math.Sqrt(x * x + 10))) == 0)
            {
            Console.WriteLine("q = "+ q +".");
            }
            else
            Console.WriteLine("z = "+ z +".");
            Console.WriteLine("q = " + q + ".");
        }
    }
}
