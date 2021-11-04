using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    public class Cats : Animals
    {
        public int _SpeedOnLand;
        public Cats(string Name, string Species, int Age, int legs, float Hight, string Sound, int SpeedOnLand)
        {

            _Name = Name;
            _Species = Species;
            _Age = Age;
            _NumberOfLegs = legs;
            _Hight = Hight;
            _Sound = Sound;
            _SpeedOnLand = SpeedOnLand;
        }
        public Cats() : this("No name", "No specie", 0, 4, 20, "No sound", 0)
        {

        }
        public void Hunt()
        {
            Console.WriteLine("The cat takes a prey and eats it. ");
        }

    }
    public class Tiger : Cats
    {
        public bool _LivingInDjungel;

        public Tiger(string Name, string Species, int Age, int legs, float Hight, string Sound, int SpeedOnLand, bool Djungel)
        {
            _Name = Name;
            _Species = Species;
            _Age = Age;
            _NumberOfLegs = legs;
            _Hight = Hight;
            _Sound = Sound;
            _SpeedOnLand = SpeedOnLand;
            _LivingInDjungel = Djungel;
        }
        public void sleep()
        {
            Console.WriteLine("The Tiger is sleeping.");
        }


    }
    public class Lion : Cats
    {
        public bool _LivingOnSavannah;

        public Lion(string Name, string Species, int Age, int legs, float Hight, string Sound, int SpeedOnLand, bool Savannah)
        {
            _Name = Name;
            _Species = Species;
            _Age = Age;
            _NumberOfLegs = legs;
            _Hight = Hight;
            _Sound = Sound;
            _SpeedOnLand = SpeedOnLand;
            _LivingOnSavannah = Savannah;
        }
        public void Drink()
        {
            Console.WriteLine("The Lion is drinking water.");
        }

    }
}
