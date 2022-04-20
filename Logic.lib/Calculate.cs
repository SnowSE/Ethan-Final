namespace Logic.lib;

public static class Calculator
{
    public static double CalculateTypeEffectiveness(Type attackingType, Type defendingType)
    {
        if (attackingType == Type.Fire)
        {
            switch (defendingType)
            {
                case Type.Grass:
                case Type.Bug:
                case Type.Ice:
                case Type.Steel:
                    return 2;
                case Type.Fire:
                case Type.Rock:
                case Type.Water:
                case Type.Dragon:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Water)
        {
            switch (defendingType)
            {
                case Type.Fire:
                case Type.Rock:
                case Type.Ground:
                    return 2;
                case Type.Water:
                case Type.Grass:
                case Type.Dragon:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Normal)
        {
            switch (defendingType)
            {
                case Type.Rock:
                case Type.Steel:
                    return .5;
                case Type.Ghost:
                    return 0;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Steel)
        {
            switch (defendingType)
            {
                case Type.Fairy:
                case Type.Ice:
                case Type.Rock:
                    return 1;
                case Type.Electric:
                case Type.Fire:
                case Type.Steel:
                case Type.Water:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Grass)
        {
            switch (defendingType)
            {
                case Type.Rock:
                case Type.Ground:
                case Type.Water:
                    return 2;
                case Type.Bug:
                case Type.Dragon:
                case Type.Fire:
                case Type.Flying:
                case Type.Grass:
                case Type.Poison:
                case Type.Steel:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Bug)
        {
            switch (defendingType)
            {
                case Type.Grass:
                case Type.Dark:
                case Type.Psychic:
                    return 2;
                case Type.Fairy:
                case Type.Fighting:
                case Type.Fire:
                case Type.Flying:
                case Type.Ghost:
                case Type.Poison:
                case Type.Steel:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Electric)
        {
            switch (defendingType)
            {
                case Type.Flying:
                case Type.Water:
                    return 2;
                case Type.Dragon:
                case Type.Electric:
                case Type.Grass:
                    return .5;
                case Type.Ground:
                    return 0;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Psychic)
        {
            switch (defendingType)
            {
                case Type.Fighting:
                case Type.Poison:
                    return 2;
                case Type.Psychic:
                case Type.Steel:
                    return .5;
                case Type.Dark:
                    return 0;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Dragon)
        {
            switch (defendingType)
            {
                case Type.Dragon:
                    return 2;
                case Type.Steel:
                    return .5;
                case Type.Fairy:
                    return 0;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Fairy)
        {
            switch (defendingType)
            {
                case Type.Dragon:
                case Type.Dark:
                case Type.Fighting:
                    return 2;
                case Type.Fire:
                case Type.Poison:
                case Type.Steel:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Ground)
        {
            switch (defendingType)
            {
                case Type.Electric:
                case Type.Fire:
                case Type.Poison:
                case Type.Rock:
                case Type.Steel:
                    return 2;
                case Type.Grass:
                case Type.Bug:
                    return .5;
                case Type.Flying:
                    return 0;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Ice)
        {
            switch (defendingType)
            {
                case Type.Dragon:
                case Type.Flying:
                case Type.Grass:
                case Type.Ground:
                    return 2;
                case Type.Water:
                case Type.Ice:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Poison)
        {
            switch (defendingType)
            {
                case Type.Bug:
                case Type.Grass:
                    return 2;
                case Type.Poison:
                case Type.Ground:
                case Type.Rock:
                case Type.Ghost:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Dark)
        {
            switch (defendingType)
            {
                case Type.Psychic:
                case Type.Ghost:
                    return 2;
                case Type.Dark:
                case Type.Fairy:
                case Type.Fighting:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Rock)
        {
            switch (defendingType)
            {
                case Type.Bug:
                case Type.Fire:
                case Type.Flying:
                case Type.Ice:
                    return 2;
                case Type.Ground:
                case Type.Fighting:
                case Type.Steel:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Flying)
        {
            switch (defendingType)
            {
                case Type.Bug:
                case Type.Fighting:
                case Type.Grass:
                    return 2;
                case Type.Electric:
                case Type.Rock:
                case Type.Steel:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Ghost)
        {
            switch (defendingType)
            {
                case Type.Ghost:
                case Type.Psychic:
                    return 2;
                case Type.Dark:
                    return .5;
                case Type.Normal:
                    return 0;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Fighting)
        {
            switch (defendingType)
            {
                case Type.Normal:
                case Type.Dark:
                case Type.Ice:
                case Type.Rock:
                case Type.Steel:
                    return 2;
                case Type.Bug:
                case Type.Fairy:
                case Type.Flying:
                case Type.Poison:
                case Type.Psychic:
                    return .5;
                case Type.Ghost:
                    return 0;
                default:
                    return 1;
            }
        }
        return 1;
    }

    public static int RandomPokemon()
    {
        Random random = new Random();
        return random.Next(0, 5);
    }
}