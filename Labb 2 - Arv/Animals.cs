using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    public class Animals
    {
    
        public string _Name;
        public string _Species;
        public int _Age;
        public int _NumberOfLegs;
        public float _Hight;
        public string _Sound;


        //public Animals(string Name, string Art, int Age, int legs, float Hight, string Sound)
        //{
        //    _Name = Name;
        //    _Art = Art;
        //    _Age = Age;
        //    _NumberOfLegs = legs;
        //    _Hight = Hight;
        //    _Sound = Sound;
        //}
        //public Animals() 
        //{
        //    _Name = "No name";
        //    _Art = "No specie";
        //    _Age = 0;
        //    _NumberOfLegs = 0;
        //    _Hight = 0;
        //    _Sound = "No sound";
        //}


        public void MakeSound()
        {
            Console.WriteLine(_Name +" sounds like "+_Sound);
        }

        public void Move()
        {
            Console.WriteLine("Walk");
        }
        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
        public void PrintInfo()
        {
            Console.WriteLine("Animal Names is {0}. The species is {1}. The age of the animal is {2}, animal has {3} legs, the hieght is {4} its sound is {5} .", _Name, _Species, _Age, _NumberOfLegs, _Hight, _Sound);
        }
    }
}
