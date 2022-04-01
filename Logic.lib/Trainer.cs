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

        Bag.Add(new Potion() { strength = Strength.Hyper, Uses = 10 });
        
    }
    public string Name { get; }

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



}

