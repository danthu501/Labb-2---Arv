using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    public class Penguins : Animals
    {
        public int _SpeedUnderWater;
        public Penguins(string Name, string Species, int Age, int legs, float Hight, string Sound, int SpeedUnderWater)
        {
            _Name = Name;
            _Species = Species;
            _Age = Age;
            _NumberOfLegs = legs;
            _Hight = Hight;
            _Sound = Sound;
            _SpeedUnderWater = SpeedUnderWater;
        }
        public Penguins() : this("No name", "No specie", 0, 4, 20, "No sound", 0)
        {

        }
        public void swim()
        {
            Console.WriteLine("Penguin swims");
        }
    }
}
