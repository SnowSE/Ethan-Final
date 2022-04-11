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