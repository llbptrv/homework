Console.Write("введите число 1-7, соответствующее дню недели:");
int n= Convert.ToInt32(Console.ReadLine());
if (n>5 && n<8)
    Console.WriteLine("ура, выходной");
else if (n<5 && n>0)
    Console.WriteLine("это не выходной");
else if (n>7 || n<1)
    Console.WriteLine("число не соответствует дню недели");