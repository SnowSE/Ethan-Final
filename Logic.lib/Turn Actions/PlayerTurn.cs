namespace Logic.lib;

public static class PlayerTurn
{
    public static void Attack(Trainer trainer, Pokemon attackedPokemon)
    {
        int counter = 0;
        //This will be console dependent
        foreach(var move in trainer.SetPokemon.Moves)
        {
            Console.WriteLine($"{counter}: {move.Name}");
            counter++;
        }
        

        var ChosenMove = trainer.SetPokemon.Moves[GetValue.GetInt("Please choose the move to use", 0, trainer.SetPokemon.Moves.Count, Console.CursorTop)];

        var Modifier = Calculator.CalculateTypeEffectiveness(ChosenMove.MoveType, attackedPokemon.Typing);

        ChosenMove.Attack(trainer.SetPokemon.Typing, attackedPokemon, (int)Modifier);

        if(Modifier == 2)
        {
            Console.WriteLine("It's Super Effective!!");
        }
        else if(Modifier == .5)
        {
            Console.WriteLine("It's Not Very Effective");
        }
        else if(Modifier == 0)
        {
            Console.WriteLine("That move doesnt seem to work!");
        }
        else
        {
            Console.WriteLine("The attack hit!");
        }
        Console.ReadLine();

    }

    public static void ChangePokemon(Trainer trainer)
    {
        int counter = 0;
        //This will be console dependent
        foreach(var pokemon in trainer.Party)
        {
            Console.WriteLine($"{counter}: {pokemon.Name} {pokemon.HP}hp/{pokemon.Max_HP}HP");
            counter++;
        }

        trainer.SetPokemon = trainer.Party[GetValue.GetInt("Please choose your pokemon to switch to", 0, trainer.Party.Count, Console.CursorTop)];
    }

    public static void UseItem(Trainer trainer)
    {
        int counter = 0;
        //This will be console dependent
        foreach(var item in trainer.Bag)
        {
            Console.WriteLine($"{counter}: {item.ToString()} {item.Uses}");
            counter++;
        }

        trainer.Bag[GetValue.GetInt("Please choose the item to use", 0, trainer.Bag.Count, Console.CursorTop)].UseItem(trainer.SetPokemon);
    }
}
