using NUnit.Framework;
using education;
using NUnit.Framework.Legacy;
public class FoxTests
{
    [Test]
    public void Run_NegativeDistance_NotRuning()
    {
        Fox testing1 = new Fox();
        string output = testing1.Run(-10);
        ClassicAssert.AreEqual(output, "fox do not running");
    }
}
