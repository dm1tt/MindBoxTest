namespace Geometry.FigureModels;

/// <summary>
/// Представляет абстрактную модель фигуры.
/// </summary>
public abstract class BaseFigure
{
    private double _square;

    /// <summary>
    /// Площадь фигуры.
    /// </summary>
    public double Square
    {
        get
        {
            if (_square == 0)
            {
                _square = CalculateSquare();
            }
            return _square;
        }
    }

    /// <summary>
    /// Вычисление площади фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    protected abstract double CalculateSquare();

    /// <summary>
    /// Возведение переменной типа double в квадрат.
    /// </summary>
    /// <param name="val">Число для возведения в степень.</param>
    /// <returns>Квадрат val.</returns>
    protected static double Power(double val) => val * val;
}