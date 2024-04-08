namespace UnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod_1()
    {
        Assert.AreEqual(1, 1);
    }
    [TestMethod]
    public void TestMethod_2()
    {
        Assert.AreEqual(2, 2);
    }
    [TestMethod]
    public void TestMethod_3()
    {
        Assert.AreEqual(3, 0);
    }
}