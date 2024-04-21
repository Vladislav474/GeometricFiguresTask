using GeometricFiguresTask.Figures;

namespace GeometricFiguresTaskTest;

[TestFixture]
public class CircleTest
{
    [Test]
    public void ZeroRadiusTest()
    {
        Assert.Catch<ArgumentException>(() => new Circle(0d));
    }


    [Test]
    public void NegativeRadiusTest()
    {
        Assert.Catch<ArgumentException>(() => new Circle(-1d));
    }


    [Test]
    public void GetAreaTest()
    {
        var radius = 3;
        var circle = new Circle(radius);
        var expectedValue = Math.PI * Math.Pow(radius, 2d);

        var factArea = circle.GetArea();

        Assert.That(factArea, Is.EqualTo(expectedValue));
    }
}
