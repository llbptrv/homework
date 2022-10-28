//задача 36
void InputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0,10);
    }
}
int CheckArray(int[] array)
{
    int result=0;
    for(int i=0; i<array.Length; i++)
    {
        if(i%2!=0)
        {
            result=result+array[i];
        }
    
    }
    return result;
}


int[] array = new int[7];
InputArray(array);
Console.WriteLine($"[{string.Join(", " , array)}]");
CheckArray(array);
Console.WriteLine($"сумма элементов: {CheckArray(array)}");
