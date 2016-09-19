using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а: ");
            int a = int.Parse(Console.ReadLine());
            int a4, a6, a7, a8, a9, a10, a13, a15, a21, a28, a64;

            a4 = a * a;
            a4 *= a4;

            a6 = a4;
            a6 = a6 * a6 / a / a;           
            
            a7 = a6 * a;

            a8 = a4;
            a8 *= a8;

            a9 = a8 * a;

            a10 = a9 * a;

            a13 = a10 * a4 / a;

            a15 = a8;
            a15 = a15 * a15 / a;

            a21 = a6;
            a21 = a21 * a21 * a21 / a / a / a;

            a28 = a7;
            a28 = a28 * a28 * a28;

            a64 = a21;
            a64 = a64 * a64;
      
            




        }
    }
}
