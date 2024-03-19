using System;
class Substring
{
    static void Main()
    {
        Console.WriteLine("Enter String : ");
        string str = Console.ReadLine();
        int len = str.Length;
        Console.WriteLine("Length of String : " + len);
        for(int i=0; i<len; i++)
        {
            for(int j=1; j<len-i+1; j++)
            {
                string sub = str.Substring(i, j);
                Console.WriteLine(sub);
            }
        }
    }
}
