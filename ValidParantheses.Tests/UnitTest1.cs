namespace ValidParantheses.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void SingleParentheses()
    {
        string s = "()";
        bool result = _test.IsValid(s);
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void TripleParentheses()
    {
        string s = "()[]{}";
        bool result = _test.IsValid(s);
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void FalseParentheses()
    {
        string s = "(]";
        bool result = _test.IsValid(s);
        Assert.IsFalse(result);
    }
}