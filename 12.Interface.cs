using System;

// Define the IResizable interface
public interface IResizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

// Implement the Rectangle class
public class Rectangle : IResizable
{
    private int Width { get; set; }
    private int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void ResizeWidth(int width)
    {
        Width = width;
        Console.WriteLine($"Resized width to {Width}.");
    }

    public void ResizeHeight(int height)
    {
        Height = height;
        Console.WriteLine($"Resized height to {Height}.");
    }
}

class Program
{
    static void Main()
    {
        // Create a Rectangle object
        Rectangle myRectangle = new Rectangle(10, 5);

        // Resize the rectangle
        myRectangle.ResizeWidth(15);
        myRectangle.ResizeHeight(8);
    }
}
