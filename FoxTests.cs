using NUnit.Framework;
using education;
using NUnit.Framework.Legacy;
public class FoxTests
{
    [Test]
    public void Run_NegativeDistance_NotRuning()
    {
        int distance = -10;
        Fox testing1 = new Fox();
        string output = testing1.Run(distance);
        ClassicAssert.AreEqual("fox do not running", output);
    }
    [Test]
    public void Run_MaxDistance_Runnig()
    {
        int distance = 10;
        Fox testing1 = new Fox();
        string output = testing1 .Run(distance);
        ClassicAssert.AreEqual("fox running " + distance + " km", output);
    }
    [Test]
    public void Run_BigDistance_NotRuning()
    {
        int distance = 100;
        Fox testing1 = new Fox();
        string output = testing1.Run(distance);
        ClassicAssert.AreEqual("fox do not running", output);
    }
    [Test]
    public void Run_ZeroDistance_NotRunnig()
    {
        int distance = 0;
        Fox testing1 = new Fox();
        string output = testing1.Run(distance);
        ClassicAssert.AreEqual("fox do not running", output);
    }
    [Test]

    public void Run_NormalDistance_Running()
    {
        int distance = 4;
        Fox testing1 = new Fox();
        string output = testing1.Run(distance);
        ClassicAssert.AreEqual("fox running " + distance + " km", output);
    }
}
