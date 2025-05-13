# Shape Library

A C# library for calculating areas of different shapes. Currently supports circles and triangles.

## Features

- Calculate area of a circle by radius
- Calculate area of a triangle by three sides
- Check if a triangle is right-angled
- Easy to extend with new shapes
- Runtime shape creation without knowing the type at compile-time
- Comprehensive unit tests

## Usage

### Creating and using shapes directly

```csharp
// Create a circle
var circle = new Circle(5);
double circleArea = circle.CalculateArea();

// Create a triangle
var triangle = new Triangle(3, 4, 5);
double triangleArea = triangle.CalculateArea();
bool isRightTriangle = triangle.IsRightTriangle();
```

### Using the factory pattern

```csharp
// Create shapes without knowing their type at compile-time
IShape shape1 = ShapeFactory.CreateCircle(5);
IShape shape2 = ShapeFactory.CreateTriangle(3, 4, 5);

// Calculate areas
double area1 = shape1.CalculateArea();
double area2 = shape2.CalculateArea();
```

### Adding a new shape

To add a new shape:

1. Create a new class that implements `IShape`
2. Implement the `CalculateArea()` method
3. Add a factory method in `ShapeFactory` if needed

Example:

```csharp
public class Rectangle : IShape
{
    private readonly double _width;
    private readonly double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public double CalculateArea()
    {
        return _width * _height;
    }
}
```

## Requirements

- .NET 6.0 or later
- xUnit for running tests

## Testing

Run the tests using:

```bash
dotnet test
``` 