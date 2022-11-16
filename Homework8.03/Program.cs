//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 5);
                       
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
    
}

void RealiseMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[3,3];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j =0; j < matrix1.GetLength(1); j++)
        {   
            matrix3[i,j]=matrix1[i,j]*matrix2[i,j];
            Console.Write(matrix3[i,j]+"\t");
        }
        Console.WriteLine();
    }
    
}

int[,] matrix1 = new int[3,3];
int[,] matrix2 = new int[3,3];
InputMatrix(matrix1);
Console.WriteLine();
InputMatrix(matrix2);
Console.WriteLine();
RealiseMatrix(matrix1, matrix2);

