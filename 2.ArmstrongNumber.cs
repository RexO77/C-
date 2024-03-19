using System;
class Armstrong
{
    static void Main()
    {
        Console.WriteLine("Armstrong Number from 1 to 1000 are...");
        for (int i = 1; i <= 1000; i++)
        {
            int num = i;
            int sum = 0;
            while (num > 0)
            {
                int rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            if (sum == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
