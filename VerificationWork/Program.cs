string[] days = { "Sun", "22", "Monday", "Tuersday", "Wednesday", "Thirsday", "Fri", "Saturday" };
Console.WriteLine("изначальный массив: ");
for (int i = 0; i < days.Length; i++)
{
    
    Console.Write($"{days[i]},  ");
}
Console.WriteLine();
Console.WriteLine("итоговый массив: ");
for (int i = 0; i < days.Length; i++)
{

    if (days[i].Length<4)
    {
        Console.Write($"{days[i]}  ");
    }
}
