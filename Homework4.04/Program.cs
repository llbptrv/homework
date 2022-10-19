
Console.WriteLine("введите массив чисел(5), каждое из которых не более 100, указав последним числом ноль");
int[] array = new int[5];
int length=array.Length;
int index=0;

int max=0;
int max1=0;

while(index<length)
{
    array[index]= Convert.ToInt32(Console.ReadLine());
    index++;
}
Console.WriteLine("["+string.Join("," , array)+"]");

while(index<length)
{
    if(array[index]>max)  
    {
        max=array[index]; 
        index++;
    }
}
Console.WriteLine($"наибольшее число:{max} ");
    
array[max]=0;

while(index<length)
{
    if(array[index]>max1) 
    {
        max1=array[index]; 
        index++;
    }
}

Console.WriteLine($"второе наибольшее число:{max1} ");