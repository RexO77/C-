using System;
class Floyds
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows: ");
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
}
