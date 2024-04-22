namespace Geometry.FigureModels.Figures;

/// <summary>
/// Представляет круг.
/// </summary>
public class Circle : BaseFigure
{
    /// <summary>
    /// Возвращает радиус круга.
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Инициализирует новый экземпляр класса Circle с указанным радиусом.
    /// </summary>
    /// <param name="radius">Размер радиуса.</param>
    /// <exception cref="ArgumentException">Вызывается, когда круга с указанным радиусом не существует.</exception>
    public Circle(double radius)
    {
        if  (radius <= 0)
        {
            throw new ArgumentException("Круг с таким радиусом не существует.", nameof(radius));
        }
        Radius = radius;
    }

    /// <summary>
    /// Вычисляет площадь радиуса.
    /// </summary>
    /// <returns>Площадь радиуса.</returns>
    protected override double CalculateSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}