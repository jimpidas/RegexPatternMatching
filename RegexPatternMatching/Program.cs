using System;

namespace RegexPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();
            Console.WriteLine("Enter the first name");
            string Name = Console.ReadLine();
            // Console.WriteLine(pattern.isValidFirstName(Name));
            pattern.isValidFirstName(Name);
        }
    }
}
