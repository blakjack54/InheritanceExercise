using System;

namespace Inheritance
{
    public class Bird : Animal
    {
        // Members specific to birds
        public double WingSpan { get; set; }
        public string FeatherColor { get; set; }
        public bool CanFly { get; set; }
        public string BirdSound { get; set; }

        // Method to display bird information
        public void DisplayBirdInfo()
        {
            // Display base class information
            DisplayAnimalInfo();

            // Display specific bird information
            Console.WriteLine($"Wingspan: {WingSpan} meters");
            Console.WriteLine($"Feather Color: {FeatherColor}");
            Console.WriteLine($"Can Fly: {(CanFly ? "Yes" : "No")}");
            Console.WriteLine($"Bird Sound: {BirdSound}");
        }
    }
}