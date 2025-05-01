using System;

class Program
{
    static void Main()
    {
        int size = 10;
        Console.WriteLine();
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }
}
