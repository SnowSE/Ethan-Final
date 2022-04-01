namespace Logic.lib;

public class Trainer
{
    public string Name { get; }

    private Pokemon setPokemon;
    public Pokemon SetPokemon
    {
        get
        {
            try
            {
                if(setPokemon == null)
                {
                    throw new Exception("No set Pokemon");
                }
                return setPokemon;
            }
            catch 
            {
                setPokemon = new Pokemon(){HP = 0};
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

