using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Принимаются числа только в диапозоне от 0 до 10!");
        while (true)
        {
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
            {
                result = num1 * num2;
                Console.WriteLine($"Ответ = {result}");
                break;
            }
            else
            {
                Console.WriteLine("Недопустимые значения!");
                
            }
            
        }
    }
}
