using System;
using System.Collections.Generic;
using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ZoeHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var dtorso = new DadBodTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };

            var atorso = new AstronautTorso()
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };


            atorso.Breathe();
            dtorso.Breathe();
            atorso.HandType = HandType.Baby;
            dtorso.ChiseledAbs = false;
            // creates a new instance of the Astronaut class and we ae storing a reference to where that instance lives inside this variable. What part of the Astronaut class? the CONSTRUCTOR
            var astronaut = new Astronaut("Space Person", "Janitor", head, atorso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Janitor", head, dtorso, legs);

            astronaut2.DoYourJob(100);

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


            var torsos = new List<TorsoBase> { dtorso, atorso, new DadBodTorso() };

            foreach (var torso in torsos)
            {
                torso.Breathe();
                torso.Flex();
            }
        }
    }
}