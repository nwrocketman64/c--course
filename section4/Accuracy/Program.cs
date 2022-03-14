using System;

namespace Accuracy
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = 0.1 * 7;
            double result2 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;
            
            Console.WriteLine($"1st result is {result1:R}");
            Console.WriteLine($"2nd result is {result2:R}");
            
            double difference = result1 - result2;
            Console.WriteLine($"The difference is {difference:R}");
            
            decimal result3 = 0.1m * 7m;
            decimal result4 = 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m;
            
            Console.WriteLine($"1st result is {result3}");
            Console.WriteLine($"2nd result is {result4}");
            
            decimal difference2 = result3 - result4;
            Console.WriteLine($"The difference is {difference2}");
        }
    }
}
