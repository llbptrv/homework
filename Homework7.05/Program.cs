void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,5);
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);

int max=0;
int maxRow=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        if(matrix[i, j]>max)
        {
            max=matrix[i,j];
            maxRow=i;
        }
    
    }
  
}
Console.WriteLine($"Максимальное значение: {max}");

int result=0;
int result1=1;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {  
        if(matrix[i, j]==max && maxRow!=i)
        {
            result=result+1;
            result1++;
            maxRow=i;
           
        }
    }
       
}
Console.WriteLine($"Кол-во строк: {result1}"); 
Console.WriteLine($"Количество совпадений: {result}");   