using Geometry.FigureModels.Figures;

namespace GeometryTests.Figure;
public class CircleTests
{
    [Fact]
    public void CalculateSquare_ValidCircle_ReturnCorrectValue()
    {
        // Arrange
        double radius = 5;
        double expectedSquare = Math.PI * radius * radius;

        // Act
        Circle circle = new(radius);
        double actualSquare = circle.Square;

        // Assert
        Assert.Equal(expectedSquare, actualSquare);
    }

    [Fact]
    public void CalculateSquare_InvalidRadius_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        double radius = -5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

}