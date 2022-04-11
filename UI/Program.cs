using System;
using Logic.lib;
using System.Text.Json;

namespace program;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("This is the start of a pokemon battle simulator. Right now there are only a few things that can be done.\nYou can change your pokemon.\nYou only have a single attack and you only have a single potion.\nYou can now create pokemon that will be serialized into a list.");


        var trainer = new Trainer();
        var fighter = new Trainer();

        while (true)
        {

            var firstChoice = GetValue.GetInt("[0] Make a pokemon\n[1] View the pokemon\n[2] Fight\n[3] Finish", 0, 3);



            if (firstChoice == 2)
            {
                
            }
            else if (firstChoice == 0)
            {
                var Pokemons = Commands.PokemonDeserialize();

                var pokemon = PokemonFactory.Create();

                Pokemons.Add(pokemon);

                Commands.PokemonSerialize(Pokemons);
            }
            else if( firstChoice == 1)
            {
                var Pokemons = Commands.PokemonDeserialize();

                foreach (var pokemon in Pokemons)
                {
                    Console.WriteLine($"{pokemon.PokedexNum}: {pokemon.Name}, {pokemon.HP}Hp, Type = {pokemon.Typing}");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Have a nice day!");
                return;
            }
        }
    }
}