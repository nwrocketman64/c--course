﻿using System;

namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Americano");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Macchiato");
            Console.WriteLine("6 - Expresso");
            Console.WriteLine("Q - Quit the program");
            
            char userChoice = ' ';
            while (!(userChoice.Equals('q') || userChoice.Equals('Q')))
            {
                  userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                  Console.WriteLine("You chose " + userChoice);
            }
            
            
        }
    }
}
