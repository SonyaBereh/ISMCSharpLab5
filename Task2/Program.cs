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
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            int a4, a6, a7, a8, a9, a10, a13, a15, a21, a28, a64;
            switch(N)
            {  
                case 4:
            a4 = a*a;
            a4 *= a4;
            Console.WriteLine(a4);
                    break;
                case 6:
            int b = a*a;
            int c = b*b;
                    a6 = c*b;
            Console.WriteLine(a6);
                    break;
                case 7:
            b = a*a;
            c = b*b;
            a6 = c*b;
            a7 = a6*a;
            Console.WriteLine(a7);
                    break;
                case 8:
            b = a*a;
            c = b*b;
            a8 = c*c;
            Console.WriteLine(a8);
                    break;
                case 9:
           b = a*a;
           c = b*b;
           int d = c*c;
           a9 = d * a;
            Console.WriteLine(a9);
                    break;
                case 10:
            b = a * a;
            c = b * b;
            d = c * c;
            a10 = d * b;
            Console.WriteLine(a10);
                    break;
                case 13:
            b = a*a;
            c = b*b*b;
            a13 = c*c*a;
            Console.WriteLine(a13);
                    break;
                case 15:
            b = a * a;
            c = b * b;
            d = c * c;
            a15 = d * d * (1 / a);
            Console.WriteLine(a15);
                    break;
                case 21:
           b = a*a;
           c = b*b;
           d = c*c;
           a21 = d*d*c*a;
           Console.WriteLine(a21);
                    break;

                case 28:
            b = a*a;
            c = b*b;
            d = c*b;
            int e = d*a;
            a28 = e*e*e;            
            Console.WriteLine(a28);
            break;

                case 64:
            a64 = a*a;
            a64 *= a64;
            a64 *= a64;
            a64 *= a64;
            a64 *= a64;
            a64 *= a64;
            Console.WriteLine(a64);
                    break;

                default : Console.WriteLine("Error");
                    break;
            }
            




        }
    }
}
