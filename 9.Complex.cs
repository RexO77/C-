using System;
class Complex
{
    private double Real;
    private double Imaginary;

    public Complex(double real, double imaginary)
    {
        this.Real = real;
        this.Imaginary = imaginary;
    }
    public static Complex operator +(Complex c1, Complex c2)
    {
        double realpart = c1.Real + c2.Real;
        double imaginarypart = c1.Imaginary + c2.Imaginary;
        return new Complex(realpart, imaginarypart);
    }
    public void display()
    {
        Console.WriteLine($"Result : {Real}+{Imaginary}i");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter real part :");
        double real = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter imaginary part :");
        double imaginary = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Real part of second number :");
        double real2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Imaginary part of second number :");
        double imaginary2 = double.Parse(Console.ReadLine());
        Complex c1 = new Complex(real, imaginary);
        Complex c2 = new Complex(real2, imaginary2);
        Complex c3 = c1 + c2;
        c3.display();
    }
}
