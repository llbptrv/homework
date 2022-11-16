//Задача 61: Вывести первые N строк
//треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
Console.Write("Введите максимальное число элементов в треугольнике Паскаля: ");
int a=Convert.ToInt32(Console.ReadLine());
int n=0;
int b=0;

int factorial(int a)
{
    int n=1;
    int x=1;
    for (n=1; n<=a; n++)
    {
        x=x*n;
    }
    return x;
}
for (n=0; n<a; n++)
{
    for(b=0; b<=(a-n); b++)
    {
        Console.Write(" ");
    }

    for(b=0; b<=n; b++)
    {
        Console.Write(" ");
        Console.Write(factorial(n)/(factorial(b)*factorial(n-b)));
        
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.ReadLine();