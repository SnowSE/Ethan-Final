using System;
using Logic.lib;

namespace program;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("This is the start of a pokemon battle simulator. Right now there are only a few things that can be done.\nYou can choose a pokemon of the types Normal, Water and Fire.\nYou only have a single attack and you only have a single potion.\nI need to figure out which pokemon you want first.");

        Console.WriteLine("Type the type you want [W, F, or N work as well]");
        var Player = new Trainer();
        var _potion = new Potion() { strength = Strength.Hyper };
        Player.Bag.Add(_potion);
        switch (Console.ReadLine().ToLower())
        {
            case "w":
            case "water":
                var Squirtle = new WaterPokemon("Squirtle");
                Player.Party.Add(Squirtle);
                break;
            case "f":
            case "fire":
                var Charmander = new FirePokemon("Charmander");
                Player.Party.Add(Charmander);
                break;
            case "n":
            case "normal":
                var Porygon = new NormalPokemon("Porygon");
                Player.Party.Add(Porygon);
                break;
            default:
                Console.WriteLine("Hey, im not adding banana proofing to my code that i will delete. You are just going to get a bidoof. You are normal");
                var Bidoof = new NormalPokemon("Bidoof");
                Player.Party.Add(Bidoof);
                break;
        }
        Console.WriteLine("Type the type of pokemon you want your opponet to have [W, F, or N still work]");
        var Fighter = new Trainer();
        switch (Console.ReadLine().ToLower())
        {
            case "w":
            case "water":
                var Sobble = new WaterPokemon("Sobble");
                Fighter.Party.Add(Sobble);
                break;
            case "f":
            case "fire":
                var Chimchar = new FirePokemon("Chimchar");
                Fighter.Party.Add(Chimchar);
                break;
            case "n":
            case "normal":
                var Porygon2 = new NormalPokemon("Porygon2");
                Fighter.Party.Add(Porygon2);
                break;
            default:
                Console.WriteLine("Hey, im not adding banana proofing to my code that i will delete. They are just going to get a bidoof. They are normal");
                var Bidoof = new NormalPokemon("Bidoof");
                Fighter.Party.Add(Bidoof);
                break;

        }
        while (Player.Party[0].HP > 0 && Fighter.Party[0].HP > 0)
        {
            Console.Clear();
            Console.WriteLine("Now that you have chosen pokemon its time to fight! (or heal).");
            Console.WriteLine("If you would like to attack, type \"Attack\" or \"A\". If you would like to use a Potion type \"Potion\" or \"P\".\nThe goal is to get your opponets pokemons HP to 0. (Default option is attack)");
            Console.CursorTop += 2;
            Console.WriteLine(Player.Party[0].Name + "  " + Player.Party[0].HP + "/" + Player.Party[0].Max_HP + "(You)");
            Console.CursorTop += 3;
            Console.WriteLine(Fighter.Party[0].Name + "  " + Fighter.Party[0].HP + "/" + Fighter.Party[0].Max_HP);
            Console.CursorTop -= 6;
            switch (Console.ReadLine().ToLower())
            {
                case "potion":
                case "p":
                    Player.Bag[0].UseItem(Player.Party[0]);
                    break;
                case "attack":
                case "a":
                default:
                    Player.Party[0].Attack(Fighter.Party[0], 50);
                    break;

            }

            if (Fighter.Party[0].HP > 0)
            {
                Fighter.Party[0].Attack(Player.Party[0], 50);
            }
        }
        Console.Clear();
        Console.CursorTop += 2;
        Console.WriteLine(Player.Party[0].Name + "  " + Player.Party[0].HP + "/" + Player.Party[0].Max_HP + "(You)");
        Console.CursorTop += 3;
        Console.WriteLine(Fighter.Party[0].Name + "  " + Fighter.Party[0].HP + "/" + Fighter.Party[0].Max_HP);

        if (Fighter.Party[0].HP > 0)
        {
            Console.WriteLine("You Lose...");
        }
        else
        {
            Console.WriteLine("You win!");
        }



    }
}