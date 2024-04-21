using GeometricFiguresTask.Interfaces;

namespace GeometricFiguresTask.Figures;

public class Circle : IFigure
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус круга должен быть больше нуля.", nameof(radius));

        Radius = radius;
    }

    public double GetArea()
        => Math.PI * Math.Pow(Radius, 2d);
}
