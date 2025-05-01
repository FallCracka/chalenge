using System;

class Program
{ 
    static void Main(string[] args) 
    { 
        Console.Write("Введите сумму вклада: "); 
        decimal summa = decimal.Parse(Console.ReadLine()); 

        Console.Write("Введите количество месяцев: "); 
        int mes = Int32.Parse(Console.ReadLine()); 

        decimal summaFinal = summa; // начальная сумма для расчетов 
        int i = 0; // инициализация переменной для цикла 

        while (i < mes) 
        { 
            summaFinal += summaFinal * 0.07M; // расчет процентов 
            i++; // инкремент месяца 
        } 

        Console.WriteLine($"За {mes} месяц(ев) сумма вклада составила: {summaFinal}"); 
        Console.ReadKey(); 
    } 
}
