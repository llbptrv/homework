//задача 10
Console.Write("Введите трехзначное число: ");
int n= Convert.ToInt32(Console.ReadLine());
if (n/100!=0 && n<1000)
    Console.WriteLine($"Вы ввели:{n}\nВторая цифра:{(n/10)%10}");
else if(n/100==0 || n/100>9)
    Console.WriteLine("Вы ввели не трехзначное число, научитесь читать!");