//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("найдём точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; ");
Console.Write("введите k1: ");
int k1=Convert.ToInt32(Console.ReadLine());
Console.Write("введите b1: ");
int b1=Convert.ToInt32(Console.ReadLine());
Console.Write("введите k2: ");
int k2=Convert.ToInt32(Console.ReadLine());
Console.Write("введите b2: ");
int b2=Convert.ToInt32(Console.ReadLine());
int x=1;
double y1=k1*x+b1;
double y2=k2*x+b2;

double c= k1*x+(-1)*k2*x;
double c1= (b1+(-1)*b2)*(-1);
double c2= c/x;
double c3= c1/c2;

y1=k1*c3+b1;

Console.WriteLine($"({c3} ; {y1})");