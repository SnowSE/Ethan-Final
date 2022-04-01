using NUnit.Framework;
using Logic.lib;

namespace Tests.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    
    public void TestAttack()
    {
        var Tepig = new Pokemon(){HP = 100};
        Tepig.Attacked(50);
        Assert.AreEqual(Tepig.HP, 50);
    }

    [Test]
    
    public void TestNegativeAttack()
    {
        var Tepig = new Pokemon(){HP = 100};
        Tepig.Attacked(-50);
        Assert.AreEqual(Tepig.HP, 100);
    }

    [Test]
    
    public void TestZeroAttack()
    {
        var Tepig = new Pokemon(){HP = 100};
        Tepig.Attacked(0);
        Assert.AreEqual(Tepig.HP, 100);
    }

    [Test]

    public void HealPokemon()
    {
        var Tepig = new Pokemon(){HP = 100};
        Tepig.Heal(50);
        Assert.AreEqual(Tepig.HP, 150);
    }

    [Test]

    public void NegativeHealPokemon()
    {
        var Tepig = new Pokemon(){HP = 100};
        Tepig.Heal(-50);
        Assert.AreEqual(Tepig.HP, 100);
    }

    [Test]

    public void ZeroHealPokemon()
    {
        var Tepig = new Pokemon(){HP = 100};
        Tepig.Heal(0);
        Assert.AreEqual(Tepig.HP, 100);
    }

    [Test]

    public void HealOverMax()
    {
        var Tepig = new Pokemon(){HP = 200, Max_HP = 200};
        Tepig.Heal(50);
        Assert.AreEqual(Tepig.HP, 200);
    }

    [Test]

    public void UsingAPotion()
    {
        var _Item = new Potion(){strength = Strength.Basic};
        var Tepig = new Pokemon(){HP = 50};
        _Item.UseItem(Tepig);
        Assert.AreEqual(Tepig.HP, 70);
    }

    [Test]

    public void UsingASuperPotion()
    {
        var _Item = new Potion(){strength = Strength.Super};
        var Tepig = new Pokemon(){HP = 50};
        _Item.UseItem(Tepig);
        Assert.AreEqual(Tepig.HP, 100);
    }

    [Test]

    public void UsingAHyperPotion()
    {
        var _Item = new Potion(){strength = Strength.Hyper};
        var Tepig = new Pokemon(){HP = 50, Max_HP = 300};
        _Item.UseItem(Tepig);
        Assert.AreEqual(Tepig.HP, 250);
    }

    [Test]

    public void UsingAMaxPotion()
    {
        var _Item = new Potion(){strength = Strength.Max};
        var Tepig = new Pokemon(){HP = 50, Max_HP = 700};
        _Item.UseItem(Tepig);
        Assert.AreEqual(Tepig.HP, 700);
    }

    [Test]

    public void CantUseUsedPotion()
    {
         var _Item = new Potion(){strength = Strength.Used};
        var Tepig = new Pokemon(){HP = 50, Max_HP = 100};
        _Item.UseItem(Tepig);
        Assert.AreEqual(Tepig.HP, 50);
    }

    [Test]

    public void RevampNoMovesInMoveListAndAttack()
    {
        
    }
    
    [Test]

    public void RevampAttackWithNormalMove()
    {

    }

    [Test]

    public void RevampAttackWithFireMove()
    {
        
    }

    [Test]

    public void RevampAttackWithWaterMove()
    {
        
    }

    

    [Test]

    public void TrainerSetPokemon()
    {

    }
}