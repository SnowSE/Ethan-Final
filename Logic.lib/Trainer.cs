namespace Logic.lib;

public class Trainer
{
    public Trainer()
    {

        Party.Add(new Pokemon(Type.Fire, "Monferno", 391, 200));
        Party.Add(new Pokemon(Type.Water, "Prinplup", 394, 200));
        Party.Add(new Pokemon(Type.Flying, "Chatot", 441, 200));
        Party.Add(new Pokemon(Type.Fighting, "Hitmonlee", 106, 200));
        Party.Add(new Pokemon(Type.Grass, "Grotle", 388, 200));
        Party.Add(new Pokemon(Type.Rock, "Lycanroc", 745, 200));

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

    public void Turn(Trainer opponet)
    {
        while (this.SetPokemon.HP > 0 && opponet.SetPokemon.HP > 0)
        {
            Console.Clear();
            Console.WriteLine($"The pokemon you have sent out is {SetPokemon.Name} {SetPokemon.HP}/{SetPokemon.Max_HP}");
            Console.CursorTop += 19;
            Console.WriteLine($"Your opponent has sent out {opponet.SetPokemon.Name} {opponet.SetPokemon.HP}/{opponet.SetPokemon.Max_HP}HP");
            Console.CursorTop = 3;
            var num = GetValue.GetInt("Please choose the option you would like...\n0: Attack\n1: Change Pokemon\n2: Use Items\n3: You're done", 0, 3);
            switch (num)
            {
                case 0:
                    PlayerTurn.Attack(this, opponet.SetPokemon);
                    break;
                case 1:
                    PlayerTurn.ChangePokemon(this);
                    break;
                case 2:
                    PlayerTurn.UseItem(this);
                    break;
                case 3:
                    return;
            }
        }
    }


}

