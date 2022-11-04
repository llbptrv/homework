//Задача N°357. Состязания - 2
//В метании молота состязается п спортсменов. Каждый из них сделал • бросков. Победителем соревнований объявляется тот спортсмен,
//у которого максимален наилучший результат по всем броскам. Таким образом,
//программа должна найти значение максимального элемента в данном массиве, а также его индексы (то есть номер спортсмена и номер попытки)
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =(i+j)*10;
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
int index1=0;
int index2=0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        if(matrix[i, j]>max)
        {
            max=matrix[i,j];
            index1=i;
            index2=j;
        }
    
    }
  
}
Console.WriteLine($"Максимальное значение: {max}, индексы в таблице: ({index1}, {index2})");