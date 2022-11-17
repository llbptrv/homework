//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>0 && b>0)
{   
    int ResultNumbers(int a, int b)
    {
        if (a==b)
            return b;
        return ResultNumbers(a, b-1)+b;
    }      
    Console.WriteLine(ResultNumbers(a, b));
}

else if(a<=0 || b<=0)
{
   Console.Write("введите натуральное число"); 
}

