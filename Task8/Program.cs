using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Х");
            double x = double.Parse(Console.ReadLine());
            double f = 1.0;           
            double a = 2.0;
            bool MinusOrPlus = false;
            double res = 1.0;
            for (int i = 1; i < 10; i++)
            {
                if (MinusOrPlus == false)
                {
                    res = res - ((a / (a + 1.0)) * Math.Pow(x, f));
                    MinusOrPlus = true;
                }
                else
                {
                    res = res + ((a / (a + 1.0)) * Math.Pow(x, f));
                    MinusOrPlus = false;
                }
                f++;                       
                a++;
            }

            Console.WriteLine(res);
        }
    }
}
