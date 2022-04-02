namespace Logic.lib;

public static class ChangePokemon
{
    public static void changePokemon(Trainer trainer)
    {
        int counter = 0;
        //This will be console dependent
        foreach(var pokemon in trainer.Party)
        {
            Console.WriteLine($"{counter}: {pokemon.Name} {pokemon.HP}hp/{pokemon.Max_HP}hp");
            counter++;
        }

        trainer.SetPokemon = trainer.Party[GetInt.Getint("Please choose your pokemon to switch to", 0, trainer.Party.Count)];
    }
}

