Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
Console.WriteLine("изначальная фотография (бинарное изображение): ");
InputMatrix(matrix);

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,2);
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("неправильный негатив: ");
int[,] reversematrix = new int[n,m];
Input2Matrix(matrix);

void Input2Matrix(int[,] reversematrix)
{
    for (int i = 0; i < reversematrix.GetLength(0); i++)
    {
        for (int j = 0; j < reversematrix.GetLength(1); j++)
        {
            reversematrix[i, j] = new Random().Next(0,2);
            Console.Write($"{reversematrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}


int result=0;
for (int i = 0; i < reversematrix.GetLength(0); i++)
{
    for (int j = 0; j < reversematrix.GetLength(1); j++)
    {
        if(matrix[i,j]!=reversematrix[i,j])
            result++;
        
    }
}
Console.WriteLine($"Число пикселей: {result}");