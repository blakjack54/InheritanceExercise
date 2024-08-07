using System;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // Members specific to reptiles
        public string ScaleType { get; set; }
        public bool IsVenomous { get; set; }
        public string ReproductionType { get; set; }
        public string ColdBloodedBehavior { get; set; }

        // Method to display reptile information
        public void DisplayReptileInfo()
        {
            // Display base class information
            DisplayAnimalInfo();

            // Display specific reptile information
            Console.WriteLine($"Scale Type: {ScaleType}");
            Console.WriteLine($"Is Venomous: {(IsVenomous ? "Yes" : "No")}");
            Console.WriteLine($"Reproduction Type: {ReproductionType}");
            Console.WriteLine($"Cold-Blooded Behavior: {ColdBloodedBehavior}");
        }
    }
}