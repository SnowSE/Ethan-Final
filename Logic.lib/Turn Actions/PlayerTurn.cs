namespace Logic.lib;

public static class PlayerTurn
{
    public static double Attack(Trainer trainer, Pokemon attackedPokemon)
    {
        int counter = 0;
        //This will be console dependent
        foreach(var move in trainer.SetPokemon.Moves)
        {
            Console.WriteLine($"{counter}: {move.Name}");
            counter++;
        }
        

        var ChosenMove = trainer.SetPokemon.Moves[GetValue.GetInt("Please choose the move to use", 0, trainer.SetPokemon.Moves.Count)];

        var Modifier = Calculator.CalculateTypeEffectiveness(ChosenMove.MoveType, attackedPokemon.Typing);

        ChosenMove.Attack(trainer.SetPokemon.Typing, attackedPokemon, (int)Modifier);

        return Modifier;
    }

    public static void ChangePokemon(Trainer trainer)
    {
        int counter = 0;
        //This will be console dependent
        foreach(var pokemon in trainer.Party)
        {
            Console.WriteLine($"{counter}: {pokemon.Name} {pokemon.HP}hp/{pokemon.Max_HP}hp");
            counter++;
        }

        trainer.SetPokemon = trainer.Party[GetValue.GetInt("Please choose your pokemon to switch to", 0, trainer.Party.Count)];
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

        trainer.Bag[GetValue.GetInt("Please choose the item to use", 0, trainer.Bag.Count)].UseItem(trainer.SetPokemon);
    }
}
