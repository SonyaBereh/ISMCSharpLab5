﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            if (N < 100 && N % 4 == 0)
                Console.WriteLine("Год с таким номером высокосный.");
            else if (N > 100 && N%100==0 && N%400 == 0)
                Console.WriteLine("Год с таким номером высокосный.");
            else if (N > 100 && N%100 != 0 && N%4 == 0)
                Console.WriteLine("Год с таким номером высокосный.");
            else
                Console.WriteLine("Год с таким номером не высокосный.");
        }
    }
}
