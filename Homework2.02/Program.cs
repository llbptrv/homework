//задача 10
Console.Write("Введите число: ");
int n= Convert.ToInt32(Console.ReadLine());

if (n>99 && n<1000)
{
    Console.WriteLine($"Вы ввели:{n}\nТретья цифра:{n%10}");
}
else if(n<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if(n>999)
{
    while (n>1000)
        n=n/10;
    Console.WriteLine($"Вы ввели:{n}\nТретья цифра:{n%10}");
}
   