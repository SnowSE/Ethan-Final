namespace Logic.lib;

public class SpecialMove : Move
{
    public StatusEffect effect {get; set;}

    public int probability {get; set;}

    public override void Attack(Type pokemonType, Pokemon attackedPokemon)
    {
        attackedPokemon.Attacked((int)(Power * Calculator.CalculateTypeEffectiveness(pokemonType, attackedPokemon.Typing)));
    }
}