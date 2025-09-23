using System.Xml.Linq;

namespace FunctionAssigment
{
    internal class Program
    {
        // Kysyy nimeä
        static string askName()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();
                else
                    Console.WriteLine("Name cannot be empty.");
            }
        }
        // Kysyy ikää
        static int askAge()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("Please enter a positive integer.");
            }
        }
        // Printaa nimen ja iän
        static void printNameAndAge(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        // Tarkistaa onko täysi-ikäinen
        static bool checkAge(int age)
        {
            //Here we return the result of comparison directly
            return age >= 18;
        }
        // Vertaa nimeä toiseen nimeen
        static void compareName(string name, string compareTo)
        {
            // case-insensitive (suositeltu: equals + stringcomparison)
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");
            }

            // case-sensitive tarkka vertailu
            if (name.Equals(compareTo))
            {
                Console.WriteLine($"Your name is exactly '{compareTo}' (case-sensitive).");
            }
        }

        static void Main(string[] args)
        {
            // selkeä ja luettava "orkestrointi":
            string name = askName();
            int age = askAge();

            printNameAndAge(name, age);
            bool isFullAge = checkAge(age);
            if (isFullAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }

            compareName(name, "Matti");




        }
    }
}
