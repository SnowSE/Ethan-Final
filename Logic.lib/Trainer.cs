namespace Logic.lib;

public class Trainer
{
    public Trainer()
    {
        Party.Add(Pokedex.FindPokemon(745));
        Party.Add(Pokedex.FindPokemon(392));
        Party.Add(Pokedex.FindPokemon(395));
        Party.Add(Pokedex.FindPokemon(445));
        Party.Add(Pokedex.FindPokemon(39));
        Party.Add(Pokedex.FindPokemon(389));
        
        SetPokemon = Party[Calculator.RandomPokemon()];

        Bag.Add(new Potion(10) { strength = Strength.Hyper });

    }

    private Pokemon setPokemon;
    public Pokemon SetPokemon
    {
        get
        {
            try
            {
                if (setPokemon == null)
                {
                    throw new Exception("No set Pokemon");
                }
                return setPokemon;
            }
            catch
            {
                setPokemon = new Pokemon() { HP = 0 };
                return setPokemon;
            }
        }

        set
        {
            setPokemon = value;
        }
    }

    public List<Pokemon> Party = new List<Pokemon>();
    public List<BaseItem> Bag = new List<BaseItem>();

    public bool PartyAlive
    {
        get
        {
            int FaintedPokemon = 0;
            foreach (var pokemon in Party)
            {
                if (pokemon.HP <= 0)
                {
                    FaintedPokemon++;
                }
            }
            if (FaintedPokemon == Party.Count)
            {
                return false;
            }
            return true;
        }
    }

    public string Name = "Youngster Joey";
    public void Turn(Trainer opponet)
    {
        int Damage;
        while (this.PartyAlive == true && opponet.PartyAlive == true)
        {
            Console.Clear();
            Console.CursorTop = 1;
            Console.WriteLine($"The pokemon you have sent out is {SetPokemon.Name} {SetPokemon.HP}/{SetPokemon.Max_HP}");
            Console.CursorTop = 25;
            Console.WriteLine($"Your opponent has sent out {opponet.SetPokemon.Name} {opponet.SetPokemon.HP}/{opponet.SetPokemon.Max_HP}HP");
            Console.CursorTop = 3;
            var num = GetValue.GetInt("Please choose the option you would like...\n0: Attack\n1: Change Pokemon\n2: Use Items\n3: You're done", 0, 3, Console.CursorTop);
            switch (num)
            {
                case 0:
                    Attack(this, opponet.SetPokemon, out Damage);
                    Console.WriteLine($"You dealt {Damage} damagae to {opponet.SetPokemon.Name}");
                    break;
                case 1:
                    ChangePokemon(this);
                    break;
                case 2:
                    UseItem(this);
                    break;
                case 3:
                    Console.Clear();
                    return;                    
            }
            Console.WriteLine("Youngster Joey's Turn");
            AutoTurn(opponet, this.SetPokemon);
            Console.ReadLine();
        }
    }

    public static void AutoTurn(Trainer trainer, Pokemon opponentPokemon)
    {
        if (trainer.SetPokemon.HP <= 0)
        {
            RandomSwitchPokemon(trainer);
            return;
        }
        RandomAttackPokemon(trainer.SetPokemon, opponentPokemon);
    }

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
            Console.WriteLine($"{counter}: {item.ToString()} - {item.Uses}");
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
                trainer.SetPokemon = pokemon;
                return;
            }

        }
    }

    public static void RandomAttackPokemon(Pokemon pokemon, Pokemon opponentPokemon)
    {
        int Damage;

        var random = new Random();
        var MoveChoice = random.Next(0, pokemon.Moves.Count - 1);

        var ChosenMove = pokemon.Moves[MoveChoice];

        var Modifier = Calculator.CalculateTypeEffectiveness(ChosenMove.MoveType, opponentPokemon.Typing);

        ChosenMove.Attack(pokemon.Typing, opponentPokemon, Modifier, out Damage);

        Console.WriteLine($"Youngster Joey's {pokemon.Name} used {ChosenMove.Name} and dealt {Damage} damage to your {opponentPokemon.Name}");
    }

    public void SwitchPartyMember()
    {

    }


}

