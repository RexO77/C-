using System;
class Stackop
{
    private int top;
    private const int MAX_SIZE = 5;
    private int[] items;
    public Stackop()
    {
        top = -1;
        items = new int[MAX_SIZE];
    }
    public void push(int x)
    {
        if (top == MAX_SIZE - 1)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {
            items[++top] = x;
        }
    }
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            int val = items[top--];
            return val;
        }
    }
    public void display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(" |"+items[i]+"| ");
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Stackop stack = new Stackop();
        while (true)
        {
           Console.Write("Stack Operations\n 1.push\n 2.pop\n 3.display\n 4.exit\n Enter Your Choice :"); 
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the element to be pushed");
                    int element = Convert.ToInt32(Console.ReadLine());
                    stack.push(element);
                    break;
                case 2:
                    int poppedval=stack.Pop();
                    Console.WriteLine($"Popped element: {poppedval}");
                    break;
                case 3:
                    stack.display();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }   

        }
    }
}
