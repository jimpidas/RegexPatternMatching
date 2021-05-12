using System;

namespace RegexPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();
            Console.WriteLine("Enter the first name");
            string FName = Console.ReadLine();
            pattern.isValidFirstName(FName);

            Console.WriteLine("Enter last name");
            string LName = Console.ReadLine();
            pattern.isValidLastName(LName);

            Console.WriteLine("Enter email");
            string Email = Console.ReadLine();
            pattern.isValidLastEmail(Email);
              
        }
    }
}
