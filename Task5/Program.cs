using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N, 10 < N < 999: ");
            int N = int.Parse(Console.ReadLine());
            if (N > 100 && N < 999)
            {
                int a = N / 100;
                int b = (N / 10) % 10;
                int c = N % 10;
                int X = b * 100 + a * 10 + c;
                Console.Write("X = ");
                Console.WriteLine(X);
            }
            else if (N > 10 && N < 99) 
            {
                int a = (N / 10) % 10;
                int b = N % 10;
                int X = b * 10 + a;
                Console.Write("X = ");
                Console.WriteLine(X);
            }
             else
            Console.WriteLine("Неверно введено число, попробуйте еще раз.");
        }
    }
}
