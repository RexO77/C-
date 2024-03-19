using System;
class Pascals
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {
            int number = 1;
            Console.Write(new string(' ', rows - i));
            for (int j = 0; j <= i; j++)
            {
                Console.Write(number + " ");
                number = number * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}
