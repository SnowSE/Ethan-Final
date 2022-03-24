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

}