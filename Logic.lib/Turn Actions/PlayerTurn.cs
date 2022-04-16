namespace Logic.lib;

public static class PlayerTurn
{
    public static void Attack(Trainer trainer, Pokemon attackedPokemon, out int Damage)
    {
        Damage = 0;

        int counter = 0;

        if (trainer.SetPokemon.Moves.Count == 0)
        {
            trainer.SetPokemon.Moves = new List<Move>() { new Move() };
        }
        //This will be console dependent
        foreach (var move in trainer.SetPokemon.Moves)
        {
            Console.WriteLine($"{counter}: {move.Name}");
            counter++;
        }


        var ChosenMove = trainer.SetPokemon.Moves[GetValue.GetInt("Please choose the move to use", 0, trainer.SetPokemon.Moves.Count, Console.CursorTop)];

        var Modifier = Calculator.CalculateTypeEffectiveness(ChosenMove.MoveType, attackedPokemon.Typing);

        ChosenMove.Attack(trainer.SetPokemon.Typing, attackedPokemon, Modifier, out Damage);


    }

    public static void Attack(Trainer trainer, Pokemon attackedPokemon)
    {
        int counter = 0;

        if (trainer.SetPokemon.Moves.Count == 0)
        {
            trainer.SetPokemon.Moves = new List<Move>() { new Move() };
        }
        //This will be console dependent
        foreach (var move in trainer.SetPokemon.Moves)
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
        foreach (var pokemon in trainer.Party)
        {
            Console.WriteLine($"{counter}: {pokemon.Name} {pokemon.HP}hp/{pokemon.Max_HP}HP");
            counter++;
        }
        
        var choice = trainer.Party[GetValue.GetInt("Please choose your pokemon to switch to", 0, trainer.Party.Count, Console.CursorTop)];

        trainer.SetPokemon = choice;

        Console.WriteLine($"You have switched your pokemon to {choice.Name}");
    }

    public static void UseItem(Trainer trainer)
    {
        int counter = 0;
        //This will be console dependent
        foreach (var item in trainer.Bag)
        {
            Console.WriteLine($"{counter}: {item.ToString()} {item.Uses}");
            counter++;
        }

        trainer.Bag[GetValue.GetInt("Please choose the item to use", 0, trainer.Bag.Count - 1, Console.CursorTop)].UseItem(trainer.SetPokemon);
    }

    public static void RandomSwitchPokemon(Trainer trainer)
    {
        if (trainer.PartyAlive == false)
        {
            Console.WriteLine($"{trainer.Name} has lost all his pokemon!");
            return;
        }

        foreach (var pokemon in trainer.Party)
        {
            if (pokemon.HP > 0)
            {
                Console.WriteLine($"{trainer.SetPokemon.Name} has fainted! {trainer.Name} sent out {pokemon.Name}");
                Console.ReadLine();
                trainer.SetPokemon = pokemon;
                return;
            }

        }
    }

    public static void RandomAttackPokemon(Pokemon pokemon, Pokemon opponentPokemon )
    {
        int Damage;

        var random = new Random();
        var MoveChoice = random.Next(0, pokemon.Moves.Count - 1);

        var ChosenMove = pokemon.Moves[MoveChoice];

        var Modifier = Calculator.CalculateTypeEffectiveness(ChosenMove.MoveType, opponentPokemon.Typing);

        ChosenMove.Attack(pokemon.Typing, opponentPokemon, Modifier, out Damage);

        Console.WriteLine($"Youngster Joey's {pokemon.Name} dealt {Damage} damage to your {opponentPokemon.Name}");

        Console.Clear();
    }
}
