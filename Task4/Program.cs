using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число N: ");
            int N = int.Parse(Console.ReadLine());
            if (N > 100 && N < 999)
            {
                int a = N / 100;
                int b = (N / 10) % 10;
                int c = N % 10;
                int F = a * 100 + c * 10 + b;
                Console.Write("Полученое при перестановке второй и третьей цифр: ");
                Console.WriteLine(F);
            }
            else
                Console.WriteLine("Неверно введено число, попробуйте еще раз.");
        }
    }
}
