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

        var firstChoice = GetValue.GetInt("Do you want to make a pokemon and add it to a file on the computer? [0], View the pokemon [1], Or would you like to fight [2]", 0, 2);

        if (firstChoice == 2)
        {
            while (trainer.SetPokemon.HP > 0 && fighter.SetPokemon.HP > 0)
            {
                Console.WriteLine($"The pokemon you have sent out is {trainer.SetPokemon.Name}");
                var num = GetValue.GetInt("Please choose the option you would like...\n0: Attack\n1: Change Pokemon\n2: Use Items\n3: You're done", 0, 3);
                switch (num)
                {
                    case 0:
                        PlayerTurn.Attack(trainer, fighter.SetPokemon);
                        break;
                    case 1:
                        PlayerTurn.ChangePokemon(trainer);
                        break;
                    case 2:
                        PlayerTurn.UseItem(trainer);
                        break;
                    case 3:
                        return;
                }
            }
        }
        else if(firstChoice == 0)
        {
            var Pokemons = Commands.PokemonDeserialize();

            var pokemon = PokemonFactory.Create();

            Pokemons.Add(pokemon);

            Commands.PokemonSerialize(Pokemons);
        }
        else
        {
            var Pokemons = Commands.PokemonDeserialize();

            foreach(var pokemon in Pokemons)
            {
                Console.WriteLine($"{pokemon.PokedexNum}: {pokemon.Name}, {pokemon.HP}Hp, Type = {pokemon.Typing}");
            }
        }
    }
}