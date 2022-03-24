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
    public void InterestWorks()
    {
        var client = new Client(){IntrestRate = 100M, Debt = 10M};
        client.IncrementIntrest();
        Assert.AreEqual(client.Debt, 20M);
    }

    [Test]
    public void NegativeInterestDOESNtWork()
    {
        var client = new Client(){IntrestRate = -1M, Debt = 10M};
        client.IncrementIntrest();
        Assert.AreEqual(client.Debt, 10M);
    }

    [Test]
    public void InterestOfZeroDoesntWork()
    {
        var client = new Client(){IntrestRate = 0M, Debt = 10M};
        client.IncrementIntrest();
        Assert.AreEqual(client.Debt, 10M);
    }
}