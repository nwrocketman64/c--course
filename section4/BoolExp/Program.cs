using System;

namespace BoolExp
{
    class Progam
    {
        static void Main(string[] args)
        {
            int apples = 18;
            int oranges = 9;
            decimal applePrice = 12.60m;
            decimal orangePrice = 4.50m;
            
            Console.WriteLine(apples == oranges);
            Console.WriteLine(apples != oranges);
            Console.WriteLine($"{apples} > {oranges} is {apples > oranges}");
            Console.WriteLine($"{apples} < {oranges} is {apples < oranges}");
            Console.WriteLine($"{apples} >= {oranges} is {apples >= oranges}");
            Console.WriteLine($"{apples} <= {oranges} is {apples <= oranges}");
            Console.WriteLine($"{apples} is int is {apples is int}");
            
            bool moreApples;
            bool applesAreDearer;
            
            moreApples = (apples > oranges);
            applesAreDearer = (applePrice > orangePrice);
            Console.WriteLine($"We have more apples: {moreApples}");
            Console.WriteLine($"Apples are dearer: {applesAreDearer}");
            
            bool moreApplesAndDearer = moreApples && applesAreDearer;
            bool moreApplesOrDearer = moreApples || applesAreDearer;
            
            Console.WriteLine($"Reducing apple cost: {moreApplesAndDearer}");
            Console.WriteLine($"Reducing apple cost: {moreApplesOrDearer}");
            
            bool trueValue = true;
            bool falseValue = false;
        }
    }
}
