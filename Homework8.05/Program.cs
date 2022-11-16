void InputMatrix(int[,] matrix)
{
    
    int t=1; 
    int i=0; 
    int j=0;
    while(t<=16)
    {
        matrix[i,j]=t;
        t++;
        if(i<=j+1 && i+j< 3)
            j++;
        else if(i<j && i+j>=3)
            i++;
        else if(i>=j && i+j>3)
            j--;
        else
            i--;
    }
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j =0; j < matrix.GetLength(1); j++)
        {   
            Console.Write(matrix[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4,4];
InputMatrix(matrix);
