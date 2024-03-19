using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Expression:"); 
        int a = Convert.ToInt32(Console.ReadLine());
        string op = Console.ReadLine();
        int b = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (a + b));
                break;
            case "-":
                Console.WriteLine("Result: " + (a - b));
                break;
            case "*":
                Console.WriteLine("Result: " + (a * b));
                break;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    break;
                }
                else
                Console.WriteLine("Result: " + (a / b));
                break;
            default: Console.WriteLine("Invalid Operator");
                break;  
        }
    }
}
