using System;

namespace Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Malte";
            person.LastName = "Elwhagen";

            Console.WriteLine($"Namn: {person.FullName}");
        }
    }
}