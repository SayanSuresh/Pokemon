using System;
using Pokemon.Classes;
namespace PokemonTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Poke charmander = new Poke()
            //    {
            //        HP_Base = 39,
            //        Attack_Base = 52,
            //        Defence_Base = 43,
            //        SpecialAttack_Base = 60,
            //        SpecialDefence_Base = 50,
            //        Speed_Base = 65,
            //        //Naam = "Charmander",
            //        //Type = "Fire",
            //        //NummerPoke = 004
            //    };

            //    Poke bulbasaur = new Poke()
            //    {
            //        HP_Base = 45,
            //        Attack_Base = 49,
            //        Defence_Base = 49,
            //        SpecialAttack_Base = 65,
            //        SpecialDefence_Base = 65,
            //        Speed_Base = 45,
            //    };

            //    Poke apoke = new Poke();
            //    Console.Write($"Geef mij hp: ");
            //    apoke.HP_Base = Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"Geef mij attack: ");
            //    apoke.Attack_Base = Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"Geef mij defence: ");
            //    apoke.Defence_Base = Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"Geef mij specialAttack: ");
            //    apoke.SpecialAttack_Base = Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"Geef mij specialDefence: ");
            //    apoke.SpecialDefence_Base = Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"Geef mij speed: ");
            //    apoke.Speed_Base = Convert.ToInt32(Console.ReadLine());
            //    apoke.VerhoogLevel(5);
            //    apoke.ToonInfo();

            //    GeneratorPokemon().ToonInfo();

            // random pokemon generen

            //newpokemon.ToonInfo();
            //otherNewPokemon.ToonInfo();
            Poke newpokemon = GeneratorPokemon();
            Poke otherNewPokemon = GeneratorPokemon();

            for (int i = 1; i <=50; i++)
            {
                int uitkomst= Battle(newpokemon, otherNewPokemon);
                if (uitkomst == 1)
                {
                    newpokemon.VerhoogLevel();
                    newpokemon.ToonInfo();
                }
                else if (uitkomst == 2)
                {
                    otherNewPokemon.VerhoogLevel();
                    otherNewPokemon.ToonInfo();
                }
                Console.WriteLine($"de winnaar is nummer{uitkomst}");
                Console.ReadKey();
            }
        }










        // Pokemon-generator
        private static Random r= new Random();
        static Poke GeneratorPokemon()
        {
            Poke temp = new Poke()
            {
                HP_Base = r.Next(1, 101),
                Attack_Base = r.Next(1,101),
                Defence_Base = r.Next(1, 101),
                SpecialAttack_Base = r.Next(1, 101),
                SpecialDefence_Base = r.Next(1, 101),
                Speed_Base = r.Next(1, 101),
            };
            return temp;
        }


        // Pokemon-batlle
        public static int Battle(Poke pikachu, Poke zalm)
        {
            if (pikachu == null && zalm == null)
                return 0;
            if (pikachu == null)
                return 2;
            if (zalm == null)
                return 1;

            if (pikachu.Average > zalm.Average)
                return 1;
            else if (pikachu.Average < zalm.Average)
                return 2;

            return 0;
        }


    }
}
