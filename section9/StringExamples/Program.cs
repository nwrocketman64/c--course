using System;

namespace StringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string courseName = "Learn C# for Beginners Crash Course";
            string message = "Welcome to ";
            
            string fullMessage = message + courseName;
            Console.WriteLine(fullMessage);
            
            string fullMessage2 = $"{message}{courseName}";
            Console.WriteLine(fullMessage2);
            
            Console.WriteLine("Hello, and {0}the {1}", message, courseName);
            
            for (int i = 0; i < courseName.Length; i++)
            {
                char character = courseName[i];
                Console.Write(character);
            }
            Console.WriteLine();
            
            Console.WriteLine(courseName[0]);
            Console.WriteLine(courseName[7]);
            
            for (int i = 13; i < courseName.Length; i++)
            {
                Console.Write(courseName[i]);
            }
            Console.WriteLine();
            Console.WriteLine(courseName.Length);
            
            int position;
            position = courseName.IndexOf(" c", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(position);
            
            if (position != -1)
            {
                courseName = ReplaceByIndex(courseName, position, " c".Length, "Java");
                Console.WriteLine(courseName);
            }
            
            
        }
        
        private static string ReplaceByIndex(string original, int start,
            int length, string replacement)
        {
            string newString = original.Remove(start, length);
            return newString.Insert(start, replacement);
        }
    }
}
