using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    class DadBodTorso : TorsoBase
    {
        public bool IsHairy { get; set; }
        public override bool ChiseledAbs
        {
            get { return false; }
            set { }
        }


        public void ChangeTemperature(string weather)
        {
            if (weather == "cold")
            {
                Console.WriteLine("Dad bod turns down the thermostat.");
            }
            else
            {
                Console.WriteLine("Dad bod turns up the thermostat");
            }
        }

        public override void Flex()
        {
            Console.WriteLine($"The dad bod flexes his {(IsHairy ? "Hairy" : "Smooth")} "
                              + "beer belly while using his {HandType} hands to point at "
                              + "his flabby arms.");
        }

    }
}