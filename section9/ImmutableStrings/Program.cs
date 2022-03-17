using System;
using System.Text;

namespace ImmutableStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = x;
            //Console.WriteLine($"x = {x}, y = {y}");
            //Console.WriteLine($"x is the same as y: {object.ReferenceEquals(x, y)}");
        
            StringBuilder first = new StringBuilder("This is a string");
            StringBuilder second = new StringBuilder("This is a string");
            
            //Console.WriteLine($"first: {first}");
            //Console.WriteLine($"second: {second}");
            //Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");
            
            //first = first.Remove(4, 5);
            //first = first.Insert(4, " is a");
            Console.WriteLine($"first: {first}");
            Console.WriteLine($"second: {second}");
            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");
            Console.WriteLine($"first == second: {first == second}");
            Console.WriteLine($"first .Equals second: {first.Equals(second)}");
            
            Console.WriteLine("Clear first...");
            //first.Length = 0;
            //Console.WriteLine($"first: *{first}*");
            
            //first.Append("Another string");
            first.Clear().Append("Another string");
            Console.WriteLine($"first: *{first}*");
            
            first.Clear().Append("The values are ");
            
            int a = 12;
            int b = 34;
            int c = 56;
            
            //first.AppendFormat("a = {0}, b = {1}, c = {2}", a, b, c);
            first.AppendLine(":");
            first.Append($"a = {a}, b = {b}, c = {c}");
            Console.WriteLine(first);
        }
    }
}
