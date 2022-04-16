using System;
using Logic.lib;
using System.Text.Json;

namespace program;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        Console.WriteLine("This is the start of a pokemon battle simulator. Right now there are only a few things that can be done.\nYou can change your pokemon.\nYou only have a single attack and you only have a single potion.\nYou can now create pokemon that will be serialized into a list.");


        var trainer = new Trainer();
        var fighter = new Trainer();
        trainer.SetPokemon = new Pokemon(Logic.lib.Type.Fire, "Entei", -1, 200, new List<Move>(){new Move("Kill", 200, Logic.lib.Type.Normal)});

        while (true)
        {

            var firstChoice = GetValue.GetInt("[0] Make a pokemon\n[1] View the pokemon\n[2] Fight\n[3] Finish", 0, 3, Console.CursorTop);



            if (firstChoice == 2)
            {
                trainer.Turn(fighter);
            }
            else if (firstChoice == 0)
            {
                Pokedex.AddPokemon();
            }
            else if( firstChoice == 1)
            {
                Pokedex.ViewPokedex();
            }
            else
            {
                Console.WriteLine("Have a nice day!");
                return;
            }


        }
    }
}