using System;
class Exception
{
    static void Main()
    {
        Console.WriteLine("Division By Zero Exception");
        Console.WriteLine("Enter the values of A and B :");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        try
        {
            int c = a / b;
            Console.WriteLine("Result is " + c);
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Division by zero is not possible");
        }
        Console.WriteLine("Index Out of Bounds Exception");
        Console.WriteLine("Enter the size of the array :");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the elements of the array :");
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        try
        {
            Console.WriteLine("Enter the index of the array element you want to access :");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The array element at index " + index + " is " + arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of bounds");
        }
    }
}
