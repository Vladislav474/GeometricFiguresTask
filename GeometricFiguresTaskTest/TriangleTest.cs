using GeometricFiguresTask.Figures;

namespace GeometricFiguresTaskTest;

public class TriangleTest
{
    [TestCase(-1, 1, 1)]
    [TestCase(1, -1, 1)]
    [TestCase(1, 1, -1)]
    [TestCase(0, 0, 0)]
    public void InitTriangleWithErrorTest(double a, double b, double c)
    {
        Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Test]
    public void GetAreaTest()
    {
        double a = 3d, b = 4d, c = 5d;
        double excpectedArea = 6d;
        var triangle = new Triangle(a, b, c);

        var factSquare = triangle.GetArea();
        Assert.That(factSquare, Is.EqualTo(excpectedArea));
    }

    [Test]
    public void InitNotTriangleTest()
    {
        Assert.Catch<ArgumentException>(() => new Triangle(1, 2, 5));
    }

    [TestCase(3, 4, 3, ExpectedResult = false)]
    [TestCase(3, 4, 5 + 2e-7, ExpectedResult = false)]
    [TestCase(3, 4, 5, ExpectedResult = true)]
    public bool NotRightTriangle(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        return triangle.IsRightTriangle();
    }
}
