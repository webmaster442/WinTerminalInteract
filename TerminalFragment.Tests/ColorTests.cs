namespace TerminalFragment.Tests;

[TestFixture]
internal class ColorTests
{
    [TestCase("#fff", 0xff, 0xff, 0xff)]
    [TestCase("#100", 0x11, 0x00, 0x00)]
    [TestCase("#020", 0x00, 0x22, 0x00)]
    [TestCase("#003", 0x00, 0x00, 0x33)]
    [TestCase("#445566", 0x44, 0x55, 0x66)]
    [TestCase("#778899", 0x77, 0x88, 0x99)]
    [TestCase("#AABBCC", 0xAA, 0xBB, 0xCC)]
    [TestCase("#DDEEFF", 0xDD, 0xEE, 0xFF)]
    public void Color_FromString_ReturnsCorrect_RGB(string input, byte r, byte g, byte b)
    {
        Color actual = Color.FromString(input);

        Assert.Multiple(() =>
        {
            Assert.That(actual.R, Is.EqualTo(r));
            Assert.That(actual.G, Is.EqualTo(g));
            Assert.That(actual.B, Is.EqualTo(b));
            Assert.That(actual.A, Is.EqualTo(0xff));
        });
    }

    [TestCase("#DDEEFF99", 0xDD, 0xEE, 0xFF, 0x99)]
    [TestCase("#DDEEFF00", 0xDD, 0xEE, 0xFF, 0x00)]
    [TestCase("#DDEEFF10", 0xDD, 0xEE, 0xFF, 0x10)]
    public void Color_FromString_ReturnsCorrect_RGBA(string input, byte r, byte g, byte b, byte a)
    {
        Color actual = Color.FromString(input);

        Assert.Multiple(() =>
        {
            Assert.That(actual.R, Is.EqualTo(r));
            Assert.That(actual.G, Is.EqualTo(g));
            Assert.That(actual.B, Is.EqualTo(b));
            Assert.That(actual.A, Is.EqualTo(a));
        });
    }

    [TestCase("ffb")]
    [TestCase("#")]
    [TestCase("#ffaa#3")]
    [TestCase("#asd")]
    public void Color_FromString_Throws_WhenBadFormat(string input)
    {
        Assert.Throws<ArgumentException>(() => Color.FromString(input));
    }
}
