//задача 29

int[] array = new int[8];
int length=array.Length;
int index=0;

while(index<length)
{
    array[index]= Convert.ToInt32(Console.ReadLine());
    index++;
}

Console.WriteLine("["+string.Join("," , array)+"]");
