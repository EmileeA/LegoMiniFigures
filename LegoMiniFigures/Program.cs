using System;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a new instance of the Astronaut class and we ae storing a reference to where that instance lives inside this variable. What part of the Astronaut class? the CONSTRUCTOR
            var astronaut = new Astronaut("Space Person", "Janitor");
            var astronaut2 = new Astronaut("Space Lady", "Janitor");

            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today)
            {
                Friendly = true
            };

            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();


            var fatso = new Ghost("Fatso", new DateTime(1924, 12, 1))
            {
                Friendly = false
            };


            fatso.Spook();
            fatso.Haunt("Whipstaff Manor");
            fatso.Spook();

        }
    }
}

