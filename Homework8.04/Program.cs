void InputMatrix(int[,,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
           for (int k =0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(0, 5);
                Console.WriteLine(matrix[i, j, k] + " ("+ i + "|" + j + "|" + k + ")");
            }           
            
        }
    Console.WriteLine();
    }
    
}



int[,,] matrix = new int[3,3,3];

InputMatrix(matrix);

