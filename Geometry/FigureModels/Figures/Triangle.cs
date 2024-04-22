namespace Geometry.FigureModels.Figures;

/// <summary>
/// Представляет треугольную фигуру.
/// </summary>
public class Triangle : BaseFigure
{
    private readonly bool _isItRightTriangle;

    /// <summary>
    /// Возвращает длину первой стороны треугольника.
    /// </summary>
    public double FirstSide { get; }

    /// <summary>
    /// Возвращает длину второй стороны треугольника.
    /// </summary>
    public double SecondSide { get; }

    /// <summary>
    /// Возвращает длину третей стороны треугольника.
    /// </summary>
    public double ThirdSide { get; }

    /// <summary>
    /// Возвращает bool значение, указывающее является ли треугольник прямоугольным.
    /// </summary>
    public bool IsItRightTriangle => _isItRightTriangle;

    /// <summary>
    /// Инициализирует новый экземпляр класса Triangle с указанными длинами сторон.
    /// </summary>
    /// <param name="firstSide">Длина первой стороны треугольника.</param>
    /// <param name="secondSide">Длина второй стороны треугольника.</param>
    /// <param name="thirdSide">Длина третей стороны треугольника.</param>
    /// <exception cref="ArgumentException">Вызывается, когда треугольник с указанными сторонами не существует.</exception>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (!IsTriangleValid(firstSide, secondSide, thirdSide))
        {
            throw new ArgumentException("Треугольник с такими сторонами не существует.");
        }

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
        _isItRightTriangle = CheckIsItRightTriangle();
    }

    /// <summary>
    /// Вычисляет площадь треугольника.
    /// </summary>
    /// <returns>Площать треугольника.</returns>
    protected override double CalculateSquare()
    {
        var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
    }

    /// <summary>
    /// Проверяет является ли треугольника прямоугольным.
    /// </summary>
    /// <returns>true - треугольник прямоугольный, false - нет</returns>
    private bool CheckIsItRightTriangle()
    {
        var sides = new double[] { FirstSide, SecondSide, ThirdSide };
        Array.Sort(sides);
        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    /// <summary>
    /// Проверяет являются ли стороны треугольника валидными.
    /// </summary>
    /// <param name="side1">Первая сторона.</param>
    /// <param name="side2">Вторая сторона.</param>
    /// <param name="side3">Третья сторона.</param>
    /// <returns>true - треугольник валидный, false - нет.</returns>
    private static bool IsTriangleValid(double side1, double side2, double side3)
    {
        return (side1 + side2 > side3)
            && (side1 + side3 > side2)
            && (side2 + side3 > side1)
            && side1 > 0
            && side2 > 0
            && side3 > 0;
    }
}