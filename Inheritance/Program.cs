using System;
using System.Threading.Channels;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            //DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            //DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE  Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird zapdos = new Bird()
            {
                Name = "Zapdos",
                Age = 1000,
                Legs = 2,

                IsWarmBlooded = true,
                HasFeathers = true,
                Wings = 2,
                Type = "Electric"
            };

            Console.WriteLine($"{zapdos.Name} is an {zapdos.Type} pokemon that is {zapdos.Age} years old and has" +
                $"{zapdos.Legs} legs and {zapdos.Wings}wings.");
            Console.WriteLine($"Is {zapdos.Name} a vertebre,warm blooded and has feathers?" + $",{zapdos.IsWarmBlooded} and {zapdos.HasFeathers}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile Dragon = new Reptile()
            {

                Name = "Smaug",
                Age = 1,
                Legs = 4,

                IsColdBlooded = true,
                HasScales = true,
                Enviorment = "Erebor",
                Defense = "Breathes Fire"
            };

            Console.WriteLine($"{Dragon.Name} is a {Dragon.Age} year old dragon that lives under {Dragon.Enviorment}," + $"{Dragon.Defense} and has {Dragon.Legs}legs");

            Console.WriteLine($"is {Dragon.Name} a vertebre,cold blooded and has scales?" + $", {Dragon.IsColdBlooded} and {Dragon.HasScales}");

            Console.WriteLine();


        }
    }
}

