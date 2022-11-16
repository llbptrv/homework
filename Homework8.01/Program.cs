//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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



void RealiseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {   
            for (int k=0;  k<matrix.GetLength(1)-1; k++)
            {
                if(matrix[i,k]< matrix[i, k+1])
                {
                    int temp = matrix[i, k+1];
                    matrix [i, k+1] = matrix[i,k];
                    matrix[i,k]= temp;
                }
            }
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}
int[,] matrix = new int[3,3];
InputMatrix(matrix);
Console.WriteLine();
RealiseMatrix(matrix);