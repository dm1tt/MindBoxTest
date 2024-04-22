using Geometry.FigureModels.Figures;

namespace GeometryTests.Figure;
public class CircleTests
{
    [Fact]
    public void CalculateSquare_ValidCircle_ReturnCorrectValue()
    {
        double radius = 5;
        double expectedSquare = Math.PI * radius * radius;

        Circle circle = new(radius);
        double actualSquare = circle.Square;

        Assert.Equal(expectedSquare, actualSquare);
    }

    [Fact]
    public void CalculateSquare_InvalidRadius_ThrowsArgumentOutOfRangeException()
    {
        double radius = -5;

        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}