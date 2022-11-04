int s=0;
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            s++;
            if(i%2==0)
                matrix[i, j] = s;
            else
               matrix[i, matrix.GetLength(1) - j - 1] = s;
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

InputMatrix(matrix);
