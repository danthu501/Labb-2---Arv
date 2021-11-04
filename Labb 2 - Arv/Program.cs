using System;

namespace Labb_2___Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Monkey Ape = new Monkey("Orginal Apa", "Apa", 28, 2, 22, "Aaaa", 5);
            Ape.MakeSound();

            
            Monkey Ape2 = new Monkey();
            Ape2.MakeSound();
            
            Tiger Randig = new Tiger("Ranidg Tiger", "Tiger", 20,4,20,"A Roar",20, true);
            Randig.MakeSound();

            Penguins P1 = new Penguins();
            P1.PrintInfo();

            Lion L1 = new Lion("Liones", "Lejon", 5, 4, 50, "Roars", 20, true);
            L1.MakeSound();

            Cats Forest = new Cats("fa", "Norsk skogskatt", 15, 4, 20, "Mjau", 15);
            Forest.MakeSound();



           

            

            
          

           

        }
    }
}
