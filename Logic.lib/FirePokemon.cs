namespace Logic.lib;

public class FirePokemon : Pokemon
{
    public FirePokemon(string name)
    {
        Typing = Type.Fire;
        Name = name;
    }
    public override void Attack(Pokemon pokemon, int damage)
    {
        switch (pokemon.Typing)
        {
            case Type.Grass:
                pokemon.Attacked(damage * 2);
                break;
            case Type.Fire:
            case Type.Rock:
            case Type.Water:
                pokemon.Attacked(damage / 2);
                break;
            default:
                base.Attack(pokemon, damage);
                break;
        }
    }
}