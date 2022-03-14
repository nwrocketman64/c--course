using System;

namespace BuiltinTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte: minium {byte.MinValue}, maximum  {byte.MaxValue}");
            Console.WriteLine($"sbyte: minium {sbyte.MinValue}, maximum  {sbyte.MaxValue}");
            Console.WriteLine($"short: minium {short.MinValue}, maximum  {short.MaxValue}");
            
            var x = 234;
            Console.WriteLine(x.GetType());
            Console.WriteLine($"int: minium {int.MinValue}, maximum  {int.MaxValue}");
            Console.WriteLine($"long: minium {long.MinValue}, maximum  {long.MaxValue}");
            
            Console.WriteLine($"float: minium {float.MinValue}, maximum  {float.MaxValue}");
            Console.WriteLine($"double: minium {double.MinValue}, maximum  {double.MaxValue}");
            
            float f = 123.456789012345678F;
            double d = 123.456789012345678;
            Console.WriteLine($"f is {f:F99}");
            Console.WriteLine($"d is {d:F99}");
            
            var y = 123.4;
            Console.WriteLine(y.GetType());
            
            decimal z = 123.4567890123456789012345678901234567890123456789m;
            Console.WriteLine($"z is {z:F99}");
            Console.WriteLine($"decimal: minium {decimal.MinValue}, maximum  {decimal.MaxValue}");
        }
    }
}
