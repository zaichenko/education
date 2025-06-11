/*using NUnit.Framework;
using education;
using NUnit.Framework.Legacy;
public class FoxTests
{
    [TestCase(0)]
    [TestCase(11)]
    [TestCase(-10)]
    public void Run_NegativeTests_NotRunning(int distance)
    {
        Fox testing1 = new Fox();
        string output = testing1.Run(distance);
        ClassicAssert.AreEqual("fox do not running", output);
    }

    [TestCase(4)]
    [TestCase(10)]
    public void Run_PositiveTests_NotRunning(int distance)
    {
        Fox testing1 = new Fox();
        string output = testing1.Run(distance);
        ClassicAssert.AreEqual("fox running " + distance + " km", output);
    }
}

*/