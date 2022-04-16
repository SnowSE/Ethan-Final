namespace Logic.lib;

public static class PlayerTurn
{
    public static void Attack(Trainer trainer, Pokemon attackedPokemon)
    {
        int counter = 0;

        if(trainer.SetPokemon.Moves.Count == 0)
        {
            trainer.SetPokemon.Moves = new List<Move>(){new Move()};
        }
        //This will be console dependent
        foreach(var move in trainer.SetPokemon.Moves)
        {
            Console.WriteLine($"{counter}: {move.Name}");
            counter++;
        }
        

        var ChosenMove = trainer.SetPokemon.Moves[GetValue.GetInt("Please choose the move to use", 0, trainer.SetPokemon.Moves.Count, Console.CursorTop)];

        var Modifier = Calculator.CalculateTypeEffectiveness(ChosenMove.MoveType, attackedPokemon.Typing);

        ChosenMove.Attack(trainer.SetPokemon.Typing, attackedPokemon, Modifier);

        Console.Clear();

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

        trainer.Bag[GetValue.GetInt("Please choose the item to use", 0, trainer.Bag.Count-1, Console.CursorTop)].UseItem(trainer.SetPokemon);
    }

    public static void RandomSwitchPokemon(Trainer trainer)
    {
        if(trainer.PartyAlive == false)
        {
            Console.WriteLine($"{trainer.Name} has lost all his pokemon!");
            return;
        }

        foreach(var pokemon in trainer.Party)
        {
            if(pokemon.HP > 0)
            {
                Console.WriteLine($"{trainer.SetPokemon.Name} has fainted! {trainer.Name} sent out {pokemon.Name}");
                Console.ReadLine();
                trainer.SetPokemon = pokemon;
                return;
            }
            
        }
    }

    public static void RandomAttackPokemon(Pokemon pokemon)
    {

    }
}
