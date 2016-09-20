using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());

            int a, b, c;
            a = N / 100;
            b = (N / 10) % 10;
            c = N % 10;
            Console.WriteLine("Кол-во сотен: " + a + ".");
            Console.WriteLine("Кол-во десятков: " + b + ".");
            Console.WriteLine("Кол-во едениц: " + c + ".");
            int rez1 = a + b + c;
            int rez2 = a * b * c;
            Console.WriteLine("Сумма цифер равна: " + rez1 + ".");
            Console.WriteLine("Произведение цифер равно: " + rez2 + ".");


        }
    }
}
