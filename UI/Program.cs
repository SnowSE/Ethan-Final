using System;
using Logic.lib;

namespace program;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("This is the start of a pokemon battle simulator. Right now there are only a few things that can be done.\nYou can choose a pokemon of the types Normal, Water and Fire.\nYou only have a single attack and you only have a single potion.\nI need to figure out which pokemon you want first.");

        var trainer = new Trainer();
        var fighter = new Trainer();
        
        while (trainer.SetPokemon.HP > 0 && fighter.SetPokemon.HP > 0)
        {
            Console.WriteLine($"The pokemon you have sent out is {trainer.SetPokemon.Name}");
            var num = GetInt.Getint("Please choose the option you would like...\n0: Attack\n1: Change Pokemon\n2: Use Items\n3: You're done", 0, 3);
            switch (num)
            {
                case 0:
                AttackTurn.Attack(trainer, fighter.SetPokemon);
                break;
                case 1:
                ChangePokemon.changePokemon(trainer);
                break;
                case 2:
                UseItem.useItem(trainer);
                break;
                case 3:
                return;
            }
        }
    }
}