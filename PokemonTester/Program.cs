using System;
using Pokemon.Classes;
namespace PokemonTester
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
                Naam = "Charmander",
                Type = "Fire",
                NummerPoke = 004
            };
            charmander.ToonInfo();
            Poke bulbasaur = new Poke()
            {
                HP_Base = 45,
                Attack_Base = 49,
                Defence_Base = 49,
                SpecialAttack_Base = 65,
                SpecialDefence_Base = 65,
                Speed_Base = 45,
            };
            
            Poke apoke = new Poke();
            Console.Write($"Geef mij hp: ");
            apoke.HP_Base = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Geef mij attack: ");
            apoke.Attack_Base = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Geef mij defence: ");
            apoke.Defence_Base = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Geef mij specialAttack: ");
            apoke.SpecialAttack_Base = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Geef mij specialDefence: ");
            apoke.SpecialDefence_Base = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Geef mij speed: ");
            apoke.Speed_Base = Convert.ToInt32(Console.ReadLine());
            apoke.VerhoogLevel(5);
            apoke.ToonInfo();

           // random pokemon generen
            
            Poke newpokemon = Poke.GeneratorPokemon();
            Poke otherNewPokemon =Poke.GeneratorPokemon();
            newpokemon.ToonInfo();
            otherNewPokemon.ToonInfo();

            for (int i = 1; i <=50; i++)
            {
                int uitkomst= Poke.Battle(newpokemon, otherNewPokemon);
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
    }
}
