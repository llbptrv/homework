//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("сколько чисел вы хотите ввести: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите числа: ");

int result=0;
int i=0;
while(i<n)
{
    int m= Convert.ToInt32(Console.ReadLine());
    if(m>0)
    {
        result++;
    }
    i++;
}
Console.WriteLine($"пользователь ввел {result} чис(ел)(ла)(ло) больше 0");