namespace Geometry.FigureModels;
public abstract class BaseFigure
{
    private readonly double _square;
    public double Square => _square;
    public BaseFigure()
    {
        _square = CalculateSquare();
    }
    protected abstract double CalculateSquare();
}