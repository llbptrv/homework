//задача 34
void InputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
}
int CheckArray(int[] array)
{
    int result=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        {
            result++;
        }
    
    }
    return result;
}


int[] array = new int[4];
InputArray(array);
Console.WriteLine($"[{string.Join(", " , array)}]");
CheckArray(array);
Console.WriteLine($"количество элементов: {CheckArray(array)}");