namespace Geometry.FigureModels;
public abstract class BaseFigure
{
    protected double _square;
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
    protected abstract double CalculateSquare();
}