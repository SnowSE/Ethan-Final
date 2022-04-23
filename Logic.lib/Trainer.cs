namespace Logic.lib;

public class Trainer
{
    public Trainer()
    {

        Party.Add(new Pokemon(Type.Rock, "Lycanroc", 745, 200)
        {
            Moves = new List<Move>()
            {
                new Move("Rock Smash", 30, Type.Rock), 
                new Move("Sucker Punch", 35, Type.Dark),
                new Move("Zen Headbutt", 32, Type.Psychic), 
                new Move("Close Combat", 50, Type.Fighting)
            }
        });
        Party.Add(new Pokemon(Type.Fire, "Infernape", 392, 200)
        {
            Moves = new List<Move>()
            {
                new Move("Mach Punch", 40, Type.Fighting), 
                new Move("Flamethrower", 45, Type.Fire),
                new Move("Acrobatics", 27, Type.Flying), 
                new Move("Shadow CLaw", 35, Type.Ghost)
            }
        });
        Party.Add(new Pokemon(Type.Water, "Empoleon", 395, 200)
        {
            Moves = new List<Move>()
            {
                new Move("Flash Cannon", 40, Type.Steel), 
                new Move("Water Pulse", 30, Type.Water),
                new Move("Ice Beam", 45, Type.Ice), 
                new Move("Brick Break", 37, Type.Fighting)
            }
        });
        Party.Add(new Pokemon(Type.Dragon, "Garchomp", 445, 200)
        {
            Moves = new List<Move>()
            {
                new Move("Outrage", 40, Type.Dragon), 
                new Move("Earth Power", 40, Type.Ground),
                new Move("Poison Jab", 40, Type.Poison), 
                new Move("Shadow Claw", 35, Type.Ghost)
            }
        });
        Party.Add(new Pokemon(Type.Fairy, "Jigglypuff", 39, 200)
        {
            Moves = new List<Move>()
            {
                new Move("Play Rough", 45, Type.Fairy), 
                new Move("Hyper Voice", 45, Type.Normal),
                new Move("Ice Punch", 37, Type.Ice), 
                new Move("Thuderbolt", 45, Type.Electric)
            }
        });
        Party.Add(new Pokemon(Type.Grass, "Torterra", 3889, 200)
        {
            Moves = new List<Move>()
            {
                new Move("Wood Hammer", 60, Type.Grass), 
                new Move("Bulldoze", 30, Type.Ground),
                new Move("Rock Slide", 37, Type.Rock), 
                new Move("Rock Smash", 20, Type.Fighting)
            }
        });

        SetPokemon = Party[Calculator.RandomPokemon()];

        Bag.Add(new Potion(10) { strength = Strength.Hyper});

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
            foreach(var pokemon in Party)
            {
                if(pokemon.HP <= 0)
                {
                    FaintedPokemon++;
                }
            }
            if(FaintedPokemon == Party.Count)
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
            Console.CursorTop += 19;
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
            AutoTurn(opponet, this.SetPokemon);
        }
    }

    public static void AutoTurn(Trainer trainer, Pokemon opponentPokemon)
    {
        if(trainer.SetPokemon.HP <= 0)
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

