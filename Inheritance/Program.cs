using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var raven = new Bird
            {
                AnimalName = "Raven",
                CanFly = true,
                WingColor = "black",
                SoundProduced = "caw caw",
                Migrate = true,
            };

            var flamingo = new Bird()
            {
                AnimalName =  "Flamingo",
                CanFly = true,
                WingColor = "Pink",
                SoundProduced = "honk",
                Migrate = true,
                CanSwim = true
            };


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var alligator = new Reptile()
            {
                AnimalName = "Alligator",
                HasScales = true,
                HasTail = true,
                Diet = "Whatever it wants.",
                Fangs = 0
            };

            var rattlesnake = new Reptile()
            {
                AnimalName = "Rattlesnake",
                HasScales = true,
                HasTail = true,
                Diet = "Anything smaller than it.",
                Fangs = 2,
                Legs = 0,
                CanSwim = false,
                HasSpine = false
            };

            var theZoo = new Animal[] { raven, flamingo, alligator, rattlesnake };

            foreach (var animal in theZoo)
            {
                Console.WriteLine($"Animal: {animal.AnimalName}");
                Console.WriteLine($"Can Swim: {animal.CanSwim}");
                Console.WriteLine($"Hair Type: {animal.HairType}");
                Console.WriteLine($"Vertebrate: {animal.HasSpine}");
                Console.WriteLine($"I have {animal.Legs} legs.");
                Console.WriteLine();
            }

        }
    }
}
