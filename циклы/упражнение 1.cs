using System;

class Program
{
    static void Main()
    {
        decimal procent = 0.07m;
        
        Console.WriteLine("Процентная ставка банка равна 7%/мес.");
        
        Console.Write("Введите сумму вклада: ");
        
        decimal summ = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Введите количество месяцев: ");
        
        decimal month = Convert.ToDecimal(Console.ReadLine());
        
        decimal res = summ;
        
        for (int i = 0; i < month; i++)
        {
            res += res * procent;
        }
        Console.WriteLine($"Итоговая сумма равна: {res:F2}");
    }
}
