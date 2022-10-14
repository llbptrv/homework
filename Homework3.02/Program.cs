Console.Write("введите координаты 3 точек(x1, x2, x3, y1, y2, y3): ");
int n1=Convert.ToInt32(Console.ReadLine());
int n2=Convert.ToInt32(Console.ReadLine());
int n3=Convert.ToInt32(Console.ReadLine());
int n4=Convert.ToInt32(Console.ReadLine());
int n5=Convert.ToInt32(Console.ReadLine());
int n6=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt((n2-n1)*(n2-n1)+(n3-n4)*(n3-n4)+(n5-n6)*(n5-n6)));
