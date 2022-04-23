﻿using System;
using Logic.lib;
using System.Text.Json;

namespace program;

public class Program
{
    public static void Main()
    {
        if (Console.WindowHeight < 30)
        {
            Console.Clear();
            Console.WriteLine("Please Expand the window");
            while (Console.WindowHeight < 30)
            {
            }
        }
        Console.Clear();
        Console.WriteLine("This is the a pokemon battle simulator. \nYou can also create pokemon\n(If you've ever played pokemon you'd know that the battles aren't one to one. \nI know, it's not perfect.)\nHave fun nonetheless!");


        var trainer = new Trainer();
        var fighter = new Trainer();

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
            else if (firstChoice == 1)
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