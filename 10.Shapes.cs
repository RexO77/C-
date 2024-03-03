using System;
class shape
{
    public virtual void draw()
    {
        Console.WriteLine("Drawing a shape");
    }
    public virtual void erase()
    {
        Console.WriteLine("Erasing a shape");
    }
}
class circle : shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a circle");
    }
    public override void erase()
    {
        Console.WriteLine("Erasing a circle");
    }
}
class square : shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a square");
    }
    public override void erase()
    {
        Console.WriteLine("Erasing a square");
    }
}
class triangle : shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
    public override void erase()
    {
        Console.WriteLine("Erasing a triangle");
    }
}
class program
{
    static void Main()
    {
        shape[] shape = new shape[3];
        shape[0] = new circle();
        shape[1] = new square();
        shape[2] = new triangle();
        for (int i = 0; i < 3; i++)
        {
            shape[i].draw();
            shape[i].erase();
        }   
    }
}
