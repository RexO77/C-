using System;

// Abstract base class for shapes
public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

// Circle class extending Shape
public class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        // Area of a circle: πr^2
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double Perimeter()
    {
        // Perimeter of a circle: 2πr
        return 2 * Math.PI * Radius;
    }
}

// Triangle class extending Shape
public class Triangle : Shape
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double Area()
    {
        // Using Heron's formula to calculate area
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override double Perimeter()
    {
        // Perimeter of a triangle: sum of all sides
        return SideA + SideB + SideC;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("enter the radius of the circle: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(r);
        Console.WriteLine($"Circle with radius {r} has area: {circle.Area()} and perimeter: {circle.Perimeter()}");

        Console.WriteLine();
        
        Console.WriteLine("enter the 3 sides of the triangle: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Triangle triangle = new Triangle(a, b, c);
        Console.WriteLine($"Triangle with sides {a}, {b}, {c} has area: {triangle.Area()} and perimeter: {triangle.Perimeter()}");
    }
}
