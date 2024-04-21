using GeometricFiguresTask.Interfaces;

namespace GeometricFiguresTask.Figures;

public class Triangle : ITriangle
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        CheckTriangleExists(sideA, sideB, sideC);

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public bool IsRightTriangle()
        => _sideA == Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2))
        || _sideB == Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2))
        || _sideC == Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2));

    public double GetArea()
    {
        var halfP = (_sideA + _sideB + _sideC) / 2d;
        var square = Math.Sqrt(
            halfP
            * (halfP - _sideA)
            * (halfP - _sideB)
            * (halfP - _sideC)
        );

        return square;
    }

    private void CheckTriangleExists(double sideA, double sideB, double sideC)
    {        
        if (sideA <= 0)
            throw new ArgumentException("Сторона A должна быть больше нуля.", nameof(sideA));

        if (sideB <= 0)
            throw new ArgumentException("Сторона B должна быть больше нуля.", nameof(sideB));

        if (sideC <= 0)
            throw new ArgumentException("Сторона C должна быть больше нуля.", nameof(sideC));

        if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            throw new ArgumentException("Сторона треугольника должна быть меньше суммы других сторон.");
    }
}
