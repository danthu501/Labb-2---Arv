using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    public class Monkey : Animals
    {
        public double _Smartness;

        public Monkey(string Name, string Species, int Age, int legs, float Hight, string Sound, double Smartness)
        {
            _Name = Name;
            _Species = Species;
            _Age = Age;
            _NumberOfLegs = legs;
            _Hight = Hight;
            _Sound = Sound;
            _Smartness = Smartness;
        }
        public Monkey() : this("No name", "No specie", 0, 4, 20, "No sound", 0)
        {
            
        }

        public void Climbing()
        {
            Console.WriteLine("The monkey is Climbing");
        } 
    }

}
