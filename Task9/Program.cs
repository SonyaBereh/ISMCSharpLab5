using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            double S = 1.5;
            double way = 0.5;
            double e = 3.0, t = 3.0;
            
            for (int i = 0; i < N; i++)
            {
                S = S + 1 / e;
                e++;
            }

            for (int i = 0; i < N/2; i++)
            {    
                way = way + 1 / t - 1/(t+1);
                t+=2;
            }
            Console.WriteLine("Муж пройдет " + S + " км.");
            Console.WriteLine("Муж будет за " + way + " км от дома.");
        }
    }
}
