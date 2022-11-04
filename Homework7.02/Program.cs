//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void InputMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i+j;
                       
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
    
}


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в строке: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в столбце: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);




for (int i = 0; i <matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        if(i==a && j==b )
        {
            Console.Write($"выбранный элемент с позицией ({a},{b}): {matrix[i,j]}");
        } 
    }

}