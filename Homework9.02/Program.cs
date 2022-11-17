//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введите число больше или = 0: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число больше или = 0: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m<0 || n<0)
    Console.Write("Научитесь читать и введите число больше или = 0: ");
else
{
    int ResultNumbers(int m, int n)
    {
        if (m==0)
            return n+1;
        if(n==0)
            return ResultNumbers(m-1, 1);
        return ResultNumbers(m-1, ResultNumbers(m, n-1));
        
    }
    Console.WriteLine(ResultNumbers(m, n));
}    
