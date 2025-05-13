using Xunit;

namespace ShapeLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 10);
        }

        [Fact]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRight);
        }

        [Fact]
        public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRight);
        }

        [Fact]
        public void Constructor_InvalidTriangle_ThrowsArgumentException()
        {
            // Arrange & Act & Assert
            Assert.Throws<System.ArgumentException>(() => new Triangle(1, 2, 10));
        }

        [Fact]
        public void Constructor_NegativeSide_ThrowsArgumentException()
        {
            // Arrange & Act & Assert
            Assert.Throws<System.ArgumentException>(() => new Triangle(-1, 2, 3));
        }

        [Fact]
        public void Constructor_ZeroSide_ThrowsArgumentException()
        {
            // Arrange & Act & Assert
            Assert.Throws<System.ArgumentException>(() => new Triangle(0, 2, 3));
        }
    }
} 