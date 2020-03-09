using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures
{
    class Astronaut
    {
        // public proerty
        public Location Location { get; set; }

        // Name == "Space Person"..... this is the expression and it is detereming what the value of this property is
        //Expression Bodied Property (always readonly)
        public bool SuitedUp => Name != "Space Person";


        //   public string Name { get; } ... because we don't have "set;" it is only setable inside the constructor
        // Read-Only Property
        public string Name { get; }

        // we can set it once but only within the file it is created.
        // public property with a private setter
        public string Job { get; private set; }
        public int OxygenLevel { private get; set; }

        // ctor tab tab - to create my own contructor // the only time you're going to write a constructor is if you want to use something when that class gets instantiated.
        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;

        }
        // what behaviors do we want to add?
        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
        }


    }
}
