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
}