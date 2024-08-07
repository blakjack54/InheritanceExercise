using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of your Bird class
            Bird parrot = new Bird
            {
                Name = "Parrot",
                Age = 2,
                Habitat = "Rainforest",
                Diet = "Fruits and seeds",
                WingSpan = 0.25,
                FeatherColor = "Green",
                CanFly = true,
                BirdSound = "Chirp"
            };

            // Display Bird information
            Console.WriteLine("Bird Information:");
            parrot.DisplayBirdInfo();
            Console.WriteLine();

            // Create an object of your Reptile class
            Reptile snake = new Reptile
            {
                Name = "Snake",
                Age = 4,
                Habitat = "Desert",
                Diet = "Small animals",
                ScaleType = "Smooth",
                IsVenomous = true,
                ReproductionType = "Oviparous",
                ColdBloodedBehavior = "Basks in the sun"
            };

            // Display Reptile information
            Console.WriteLine("Reptile Information:");
            snake.DisplayReptileInfo();
        }
    }
}