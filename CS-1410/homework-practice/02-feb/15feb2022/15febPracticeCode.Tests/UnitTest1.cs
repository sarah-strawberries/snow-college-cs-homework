using NUnit.Framework;

namespace _15febPracticeCode.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
        MyPerson p1 = new MyPerson();
        MyPerson.StoreMyPersonsInfo(p1);
        Assert.AreEqual(MyPerson.StoreMyPersonsInfo(p1), true);
    }
}