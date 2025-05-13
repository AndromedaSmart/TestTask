using Xunit;

namespace ShapeLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle(5);
            double expectedArea = System.Math.PI * 25;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 10);
        }

        [Fact]
        public void Constructor_NegativeRadius_ThrowsArgumentException()
        {
            // Arrange & Act & Assert
            Assert.Throws<System.ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void Constructor_ZeroRadius_ThrowsArgumentException()
        {
            // Arrange & Act & Assert
            Assert.Throws<System.ArgumentException>(() => new Circle(0));
        }
    }
} 