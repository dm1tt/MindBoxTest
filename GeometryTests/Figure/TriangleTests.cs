using Geometry.FigureModels.Figures;

namespace GeometryTests.Figure;
public class TriangleTests
{
    [Fact]
    public void CalculateSquare_ValidTriangle_ReturnCorrectValue()
    {
        //Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;
        double expectedSquare = 6;

        //Act
        Triangle triangle = new(firstSide, secondSide, thirdSide);
        double actualSquare = triangle.Square;

        //Assert
        Assert.Equal(expectedSquare, actualSquare);
    }
    [Fact]
    public void CalculateSquare_ValidTriangle_ReturnIncorrectValue()
    {
        //Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;
        double expectedSquare = 150;

        //Act
        Triangle triangle = new(firstSide, secondSide, thirdSide);
        double actualSquare = triangle.Square;

        //Assert
        Assert.NotEqual(expectedSquare, actualSquare);
    }

    [Fact]
    public void CalculateSquare_InvalidTriangle_ThrowsArgumentException()
    {
        //Arrange 
        double firstSide = 1;
        double secondSide = 2;
        double thirdSide = 10;

        //Act + Assert
        Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }

    [Fact]
    public void CheckIsItRightTriangle_RightTriangle_ReturnTrue()
    {
        //Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;

        //Act
        Triangle triangle = new(firstSide, secondSide, thirdSide);
        bool isRightTriangle = triangle.IsItRightTriangle;

        //Assert
        Assert.True(isRightTriangle);
    }

    [Fact]
    public void CheckIsItRightTriangle_NotRightTriangle_ReturnsFalse()
    {
        // Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 6;

        // Act
        Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
        bool isRightTriangle = triangle.IsItRightTriangle;

        // Assert
        Assert.False(isRightTriangle);
    }
}