using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = (7 + 3) * 4;
            Console.WriteLine(answer);
            
            double radius = 12;
            double area = Math.PI * radius * radius;
            
            int x = 3;
            int y = x++;
            Console.WriteLine($"Using x++, x is {x} and y is {y}");
            
            x = 3;
            y = ++x;
            Console.WriteLine($"Using ++x, x is {x} and y is {y}");
            
            double a = 12 * 3 / 4;
            double b = (12 * 3) / 4;
            double c = 12 * (3 / 4);
            Console.WriteLine($"{a}, {b}, {c}");
            Console.WriteLine();
            
            double d = 1 + 3 * 15 / 2;
            double e = 1 + 3 * 15 / 2.0;
            double f = 12.0 / (3.0 / 4.0);
            Console.WriteLine($"{d}, {e}, {f}");
            Console.WriteLine();
            
            int k = 12 + 3 * 4;
            int l = (12 + 3) * 4;
            int z = 12 + (3 * 4);
            Console.WriteLine($"{k}, {l}, {z}");
            
            int q = 12;
            int r = 5;
            
            if(q % r == 0)
            {
                Console.WriteLine($"{r} divide exactly into {q}");
            }
            else
            {
                Console.WriteLine($"{r} does not divide exactly into {q}");
            }
        }
    }
}
