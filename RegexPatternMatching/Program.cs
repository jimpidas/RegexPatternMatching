using System;

namespace RegexPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();
            Console.WriteLine(pattern.validatePinCode("400088"));
        }
    }
}
