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
    int[] SumRow = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {   
            SumRow[i]+= matrix[i,j];

        }
    }
    int t = SumRow[0];
    int k=0;
    for(int i =0;  i<SumRow.Length; i++ )
    {
        if(SumRow[i]<t)
        {
            t=SumRow[i];
            k=i+1;
        }
    }
    Console.WriteLine("минимальная сумма элементов находится в строке "+ k);
    Console.WriteLine("минимальная сумма элементов = "+ t);
}

int[,] matrix = new int[3,3];
InputMatrix(matrix);
Console.WriteLine();
RealiseMatrix(matrix);
