using System;

namespace Inheritance
{
    public class Animal
    {
        // Members common to all animals
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }

        // Method to display common animal information
        public void DisplayAnimalInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age} years old");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Diet: {Diet}");
        }
    }
}