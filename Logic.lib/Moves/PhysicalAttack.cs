namespace Logic.lib;

public class PhysicalAttack : Move
{
    public StatusEffect effect {get; set;}

    public int probability {get; set;}

    public override void Attack(Type pokemonType, Pokemon attackedPokemon, int Effectivness)
    {
        double modifier = 1;
        if(pokemonType == MoveType)
        {
            modifier = 1.5;
        }
        attackedPokemon.Attacked((int)(Power * Effectivness * modifier));
    }
}