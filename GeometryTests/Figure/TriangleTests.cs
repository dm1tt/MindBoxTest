using Geometry.FigureModels.Figures;

namespace GeometryTests.Figure;
public class TriangleTests
{
    [Fact]
    public void CalculateSquare_ValidTriangle_ReturnCorrectValue()
    {
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;
        double expectedSquare = 6;

        Triangle triangle = new(firstSide, secondSide, thirdSide);
        double actualSquare = triangle.Square;

        Assert.Equal(expectedSquare, actualSquare);
    }
    [Fact]
    public void CalculateSquare_ValidTriangle_ReturnIncorrectValue()
    {
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;
        double expectedSquare = 150;

        Triangle triangle = new(firstSide, secondSide, thirdSide);
        double actualSquare = triangle.Square;

        Assert.NotEqual(expectedSquare, actualSquare);
    }

    [Fact]
    public void CalculateSquare_InvalidTriangle_ThrowsArgumentException()
    {
        double firstSide = 1;
        double secondSide = 2;
        double thirdSide = 10;

        Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }

    [Fact]
    public void CheckIsItRightTriangle_RightTriangle_ReturnTrue()
    {
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;

        Triangle triangle = new(firstSide, secondSide, thirdSide);
        bool isRectangular = triangle.IsRectangular;

        Assert.True(isRectangular);
    }

    [Fact]
    public void CheckIsItRightTriangle_NotRightTriangle_ReturnsFalse()
    {
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 6;

        Triangle triangle = new(firstSide, secondSide, thirdSide);
        bool isRectangular = triangle.IsRectangular;

        Assert.False(isRectangular);
    }
}