using System;
using Pokemon.Classes;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Poke charmander = new Poke()
            {
                HP_Base = 39,
                Attack_Base = 52,
                Defence_Base = 43,
                SpecialAttack_Base = 60,
                SpecialDefence_Base = 50,
                Speed_Base = 65,
                //Naam = "Charmander",
                //Type = "Fire",
                //NummerPoke = 004
            };

            Poke bulbasaur = new Poke()
            {
                HP_Base = 45,
                Attack_Base = 49,
                Defence_Base = 49,
                SpecialAttack_Base = 65,
                SpecialDefence_Base = 65,
                Speed_Base = 45,
            };

            // Level-up tester
            Console.WriteLine("Tot welke level wilt u leveren?");
            int levels = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < levels; i++)
            {
                charmander.VerhoogLevel();
            }
            charmander.ToonInfo();


        }
    }
}
